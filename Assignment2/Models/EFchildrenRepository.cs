﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Models;

namespace Assignment2.Models
{
    public class EFChildrenRepository : MocKchildrenRepository
    {
        // database connection moved here from  children controller
        private CompanyModel db = new CompanyModel();
        public IQueryable<child> children { get { return db.children; } }

        public void Delete(child child)
        {
            db.children.Remove(child);
            db.SaveChanges();
        }

        public child Save(child child)
        {
            //db.Entry()
            return child;
        }

       // public child
    }
}