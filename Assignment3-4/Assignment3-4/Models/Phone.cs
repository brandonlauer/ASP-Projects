using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3_4.Models
{
    public class Phone
    {
        public int ID { get; set; }
        public string PhoneName { get; set; }

        public Brand Brand { get; set; }
        public int BrandID { get; set; }

        public DateTime DateReleased { get; set; }
        public string ScreenSize { get; set; }

        public PhoneType PhoneType { get; set; }
        public int PhoneTypeID { get; set; }
    }
}