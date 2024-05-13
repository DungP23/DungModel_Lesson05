using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DqdLesson05.Models
{
    public class DqdCustomer
    {
        public int customerid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public int yearObirth { get; set; }
    }
}