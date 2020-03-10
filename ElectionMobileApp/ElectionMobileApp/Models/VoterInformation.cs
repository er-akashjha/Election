using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectionMobileApp.Models
{
    public class VoterInformation
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Assembly { get;set; }
        public string Name { get; set; }
        public string RelativeName { get; set; }
        public string RelationType { get; set; }
        public int PartNumber { get; set; }
        public int SNo { get; set; }
        public string Village { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string VoterID { get; set; }
        public string Address { get; set; }
        public string HouseNumber { get; set; }
        public string Booth { get; set; }
        public string  NewAddress { get; set; } //Extended
        public bool Dead { get; set; } //Extended
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; } //Extended
        public string Photo { get; set; }
    }
   public enum Gender{
        Male,
        Female,
        NA
    }
}
