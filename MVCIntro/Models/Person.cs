using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIntro.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get
            {
                int year = DateTime.Now.Year;
                return year - Birthdate.Year;
            }
        }
    }
}