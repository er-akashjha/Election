using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectionMobileApp.Models
{
    public class VoterInformationExtended
    {
        [PrimaryKey]
        public int ID { get; set; }
        public bool isCalled { get; set; }
        public bool isCustomWhatsappSent { get; set; }
        public bool isCustomSMSSent { get; set; }
        public bool isVoterSlipSent { get; set; }
        public bool isFamilySlipSent { get; set; }
        public bool isSlipWithSameNameSent { get; set; }
        public bool isPrinted { get; set; }
        public bool isFavourate { get; set; }
        public bool isSurvey { get; set; }
        public string isVotingUs { get; set; }
        public bool isVoted { get; set; }
        public string caste { get; set; }
        public string emailID { get; set; }
        public string occupation { get; set; }
        public string dateOfBirth { get; set; }
        public string MobileNumber1 { get; set; }
        public string MobileNumbe2 { get; set; }

    }
}
