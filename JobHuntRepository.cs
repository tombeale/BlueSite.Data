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
                return _context.ActionItems.ToList();
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
            return _context.ActionItems.Where(x => x.ActionItemId == id).FirstOrDefault();
        }

        public Company GetCompany(int id)
        {
            return _context.Companies.Where(x => x.CompanyId == id).FirstOrDefault();
        }

        public List<Note> GetNotes(string type, int id)
        {
            return _context.Notes.Where(x => x.Type == type && x.NoteId == id).ToList();
        }

        public bool AddNote(Note note)
        {
            try
            {
                _context.Notes.Add(note);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
