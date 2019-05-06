using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Buyer
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string SocialSecurityNumber { get; set; }

        public string UPIN { get; set; }

        public string StreetAddress { get; set; }

        public string  ZipCode { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string State { get; set; }

        // second Residence
        public string StreetAddress2 { get; set; }

        public string ZipCode2 { get; set; }

        public string City2 { get; set; }

        public string County2 { get; set; }

        public string State2 { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public string BirthState { get; set; }

        public string BirthCity { get; set; }

        public string ForeignCountryOfBirth { get; set; }

        public bool Male { get; set; }
        public bool Female { get; set; }

        public string HeightFt { get; set; }

        public string HeightIn { get; set; }

        public string Weight  { get; set; }

        
        public bool HispanicLatino { get; set; }

        public bool NotHispanicLatino { get; set; }

        public bool AmericanIndian { get; set; }

        public bool BlackOrAfricanAmerican { get; set; }
        public bool White { get; set; }

        public bool Asian { get; set; }

        public bool Hawaiian { get; set; }


    }
}