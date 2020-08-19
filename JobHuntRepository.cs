using BlueSite.Data.Entities;
using BlueSite.Data.Interfaces;
using BlueSite.Data.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BlueSite.Data
{
    public class JobHuntRepository: IJobHuntRepository 
    {
        private BlueSiteContext _context;
        
        public JobHuntRepository(BlueSiteContext context)
        {
            _context = context;
        }

        /* ***********************************************************
         * Users / Preferences
         * ******************************************************** */
        public User GetUserFromSignon(string signon = "tom")
        {
            return _context.Users.Where(u => u.SignOn == signon).FirstOrDefault();
        }

        public string GetUserPref(int userId, string pref, string defValue = "")
        {
            UserPref p = _context.UserPrefs.Where(up => up.UserId == userId && up.Pref == pref).FirstOrDefault();
            return (p != null) ? p.Value : defValue;
        }

        public void SaveUserPref(int userId, string pref, string value)
        {
            UserPref p = _context.UserPrefs.Where(up => up.UserId == userId && up.Pref == pref).FirstOrDefault();
            if (p == null)
            {
                _context.UserPrefs.Add(new UserPref(userId, pref, value));
            }
            else
            {
                p.Value = value;
            }
            _context.SaveChanges();
        }

        
        /* ***********************************************************
         * Actions
         * ******************************************************** */
        public List<ActionItem> AllActions
        {
            get
            {
                return _context.ActionItems.Include(b => b.Notes).ToList();
            }
        }

        public ActionType[] Types
        {
            get
            {
                return _context.ActionTypes.OrderBy(f => f.Order).ToArray();
            }
        }

        public ActionType[] GetActionTypes()
        {
            return _context.ActionTypes.OrderBy(f => f.Order).ToArray();
        }

        public ActionItem GetAction(int id)
        {
            return _context.ActionItems.Where(x => x.ActionItemId == id).Include(b => b.Notes).FirstOrDefault();
        }

        public List<ActionItem> GetAllCampaignActions()
        {
            return AllActions.Where(a => a.CampaignId != null).OrderBy(x => x.StartDate).ToList();
        }

        public List<ActionItem> GetActionsForCampaign( int campaignId)
        {
            return _context.ActionItems.Where(a => a.CampaignId == campaignId).OrderBy(x => x.StartDate).ToList();
        }

        public List<ActionSetId> GetActionSetIdList()
        {
            return _context.ActionSetIds.OrderBy(x => x.Name).ToList();
        }

        public List<string> GetActionSetIdListForToDos()
        {
            List<string> returnList = _context.ActionItems.OrderBy(x => x.SetId).Select(x => x.SetId).Distinct().ToList();
            returnList.Insert(0, "All");
            return returnList;
        }

        public bool AddCampaignActionRelationship(int campaignId, int actionId, string description = "")
        {
            try
            {
                CampaignActionRelationship Rel = new CampaignActionRelationship();
                Rel.CampaignId  = campaignId;
                Rel.ActionId    = actionId;
                Rel.Description = description;
                _context.CampaignActionRelationships.Add(Rel);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        /* ***********************************************************
         * Topics
         * ******************************************************** */

        public List<Topic> GetTopicsForParentId(string parentType, int parentId)
        {
            var Topics = _context.Topics.Where(t => t.ParentType == parentType && t.ParentId == parentId).ToList();
            foreach( var topic in Topics)
            {
                topic.Topics = GetTopicPointsForTopic(topic.Id);
            }
            return Topics;
        }



        public List<TopicPoint> GetTopicPointsForTopic(int TopicId)
        {
            var Points = _context.TopicPoints.Where(p => p.TopicId == TopicId).OrderBy(p => p.Order).ToList();
            return Points;
        }

        /* ***********************************************************
         * Campaigns
         * ******************************************************** */

        public List<Campaign> AllCampaigns
        {
            get
            {
                List<Campaign> campaigns = _context.Campaigns.ToList();
                return campaigns;
            }
        }

        public Campaign GetCampaign(int id)
        {
            return _context.Campaigns.Where(x => x.CampaignId == id).FirstOrDefault();
        }


       /* ***********************************************************
         * Companies
         * ******************************************************** */
        public List<Company> AllCompanies
        {
            get
            {
                return _context.Companies.Include(c => c.Phones).ToList();
            }
        }
        public Company GetCompany(int id)
        {
            return _context.Companies.Where(x => x.CompanyId == id).FirstOrDefault();
        }

        public Company GetCompanyFromCampaignId(int id)
        {
            Campaign camp = GetCampaign(id);
            return GetCompany(camp.CompanyId ?? 0);
        }

        public CompanyType[] GetCompanyTypes()
        {
            return _context.CompanyTypes.OrderBy(t => t.Name).ToArray();
        }

        public CompanyInterest[] GetCompanyIntrests()
        {
            return _context.CompanyInterests.OrderBy(t => t.Name).ToArray();
        }

        /* ***********************************************************
         * Contacts
         * ******************************************************** */
        public List<Contact> AllContacts
        {
            get
            {
                return _context.Contacts.Include(c => c.Phones).OrderBy(c => c.LastName).ToList();
            }
        }
        public Contact GetContact(int id)
        {
            return _context.Contacts.Where(x => x.ContactId == id).Include(c => c.Phones).FirstOrDefault();
        }

        public List<Contact> GetAllContacts()
        {
                return _context.Contacts.ToList();
        }

        public List<CompanyContactRelationship> GetCompanyContactRelationships()
        {
                return _context.CompanyContactRelationships.ToList();
        }

        public List<Contact> GetUnrelatedCompanyContacts(int id)
        {
                return _context.Contacts.ToList();
        }

        public List<ContactType> GetContactTypes()
        {
                return _context.ContactTypes.OrderBy(c => c.Order).ToList();
        }


        /* ***********************************************************
         * Phones
         * ******************************************************** */
        public List<PhoneType> GetPhoneTypes()
        {
            return _context.PhoneTypes.OrderBy(p => p.SortOrder).ToList();
        }

        public List<Phone> GetPhonesForCompany(int CompanyId)
        {
            return _context.Phones.Where(p => p.CompanyId == CompanyId).ToList();
        }

        public List<Phone> GetPhonesForContact(int ContactId)
        {
            return _context.Phones.Where(p => p.ContactId == ContactId).ToList();
        }



        /* ***********************************************************
         * Lookup Tables
         * ******************************************************** */

        public List<Status> GetStatuses()
        {
            return _context.Statuses.ToList();
        }


        /* ***********************************************************
         * Notes
         * ******************************************************** */
        public List<Note> GetNotes(string type, int id)
        {
            return _context.Notes.Where(x => x.Type == type && x.NoteId == id).ToList();
        }

        public Note GetNote(int id)
        {
            return _context.Notes.Where(x => x.NoteId == id).FirstOrDefault();
        }

        public string AddNote(int actionItemId, Note note)
        {
            try
            {
                ActionItem action = _context.ActionItems.Where(a => a.ActionItemId == actionItemId).Include(b => b.Notes).First();
                if (action != null)
                {
                    action.Notes.Add(note);
                    _context.SaveChanges();
                }
                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /* ***********************************************************
         * Resume-Related Data
         * ******************************************************** */

        public List<string> GetLanguageNames
        {
            get
            {
                return _context.LanguageEntries.Select(n => n.Name).ToList();
            }
        }

        public List<LanguageEntry> GetLanguages
        {
            get
            {
                return _context.LanguageEntries.ToList();
            }
        }

        public List<LanguageTagMapping> GetLanguageMap
        {
            get
            {
                return _context.LanguageTagMappings.ToList();
            }
        }

    }
}
