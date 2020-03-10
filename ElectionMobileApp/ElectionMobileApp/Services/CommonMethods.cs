using ElectionMobileApp.Models;
using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace ElectionMobileApp.Services
{
   public class CommonMethods
    {
        public string getVoterSlip(VoterInformation vInformation)
        {
            StringBuilder sb = new StringBuilder();
            sb = getHeader();
            sb.AppendLine("Name : " + vInformation.Name + ", " + vInformation.RelativeName);
            sb.AppendLine("Part No : " + vInformation.PartNumber);
            sb.AppendLine("SR. No : " + vInformation.SNo);
            sb.AppendLine("Voter ID : " + vInformation.VoterID);
            sb.AppendLine("Booth : " + vInformation.Booth);
            sb.AppendLine();
            sb.AppendLine("Thank You");
            return sb.ToString();
        }
        public StringBuilder getVoterSlipByFamily(VoterInformation vInformation)
        {
            //Logic to get voter with same name or family name



            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name : " + vInformation.Name + ", " + vInformation.RelativeName);
            sb.AppendLine("Part No : " + vInformation.PartNumber);
            sb.AppendLine("SR. No : " + vInformation.SNo);
            sb.AppendLine("Voter ID : " + vInformation.VoterID);
            sb.AppendLine("Booth : " + vInformation.Booth);
            sb.AppendLine();
            return sb;
        }
        private StringBuilder getHeader()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Namaskar");
            sb.AppendLine("Candidate : Test");
            sb.AppendLine("Party Name : Test Party");
            sb.AppendLine("Voting Symbol : Test");
            sb.AppendLine();
            sb.AppendLine("----------Voter Details-----------");
            return sb;
        }
        public Response SendWhatsappMessage(string phoneNumber, string message = null)
        {
            Response res = new Response();
            try
            {
                var uriString = "whatsapp://send?phone=" + 91 + "" + phoneNumber;
                if (!string.IsNullOrWhiteSpace(message))
                    uriString += "&text=" + message;
                 Launcher.OpenAsync(new Uri(uriString));
                res.Result = true;
                //await DisplayAlert("Completed with ", "Pta nahi", "Close");
            }
            catch (Exception ex)
            {
                res.Result = false;
                 res.Exception="Exception"+ ex.Message;
            }
            return res;
        }

        public Response SendSMS(string phone,string message=null)
        {
            Response res = new Response();
            var smsMessenger = CrossMessaging.Current.SmsMessenger;
            try
            {
                smsMessenger.SendSms(phone, message);
                res.Result = true;   
            }
            catch(Exception er)
            {
                res.Result = false;
                res.Exception = er.ToString();
            }
            return res;
        }
        public class Response
        {
            public bool Result { get; set; }
            public string Exception { get; set; }
        }

        public Response MakePhoneCall(string phoneNumber, string name)
        {
            Response result = new Response();
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
            {
                result.Result = true;
                phoneDialer.MakePhoneCall(phoneNumber, name);
            }
            else
            {
                result.Result = false;
                result.Exception = "Unable to make call at this time";

            }
            return result;
        }

    }
    
}
