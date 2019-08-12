using System;
using System.Data.Entity;

namespace ContactUs.Models
{
    public class contact
    {
        public string Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime timeToCall { get; set; }
    }
}