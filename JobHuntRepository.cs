using BlueSite.Data.Entities;
using BlueSite.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueSite.Data
{
    public class JobHuntRepository: IJobHuntRepository 
    {
        private BlueSiteContext _context;
        
        public JobHuntRepository(BlueSiteContext context)
        {
            _context = context;
        }
        
        public List<ActionItem> AllActions
        {
            get
            {
                return _context.ActionItems.Include(b => b.Notes).ToList();
            }
        }

        public List<Company> AllCompanies
        {
            get
            {
                return _context.Companies.ToList();
            }
        }
        public ActionType[] Types
        {
            get
            {
                return _context.ActionTypes.OrderBy(f => f.Order).ToArray();
            }
        }

        public ActionItem GetAction(int id)
        {
            return _context.ActionItems.Where(x => x.ActionItemId == id).Include(b => b.Notes).FirstOrDefault();
        }

        public Company GetCompany(int id)
        {
            return _context.Companies.Where(x => x.CompanyId == id).FirstOrDefault();
        }

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
    }
}
