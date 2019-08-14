using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactUs.Models
{
    public class ContactUsContext : DbContext
    { 
        public ContactUsContext() : base("ContactUsDB")
        {
        }

        public static ContactUsContext Create()
        {
            return new ContactUsContext();
        }

        public System.Data.Entity.DbSet<ContactUs.Models.Contact> Contacts { get; set; }
    
    }
}
