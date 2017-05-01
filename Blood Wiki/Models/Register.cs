using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blood_Wiki.Models
{
    public class Register
    {
        public virtual int ID { get; set; }
        public virtual string name { get; set; }
        public virtual string place { get; set; }
        public virtual string phone { get; set; }
        public virtual string group { get; set; }
    }
}