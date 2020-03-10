using System;
using System.Collections.Generic;
using System.Text;

namespace ElectionMobileApp.Services
{
    public class CommonLists
    {
        public List<string> getCaste()
        {
            List<string> caste = new List<string>();
            caste.Add("Hindu");
            caste.Add("Mushlim");
            caste.Add("Sikh");
            caste.Add("Esai");
            caste.Add("Add More");
            return caste;
        }
        public List<string> getOccupation()
        {
            List<string> caste = new List<string>();
            caste.Add("Farmer");
            caste.Add("Doctor");
            caste.Add("Engineer");
            caste.Add("Lawer");
            caste.Add("Add More");
            return caste;
        }
    }
}
