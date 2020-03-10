using ElectionMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionMobileApp.Services
{
    class VoterDetailsMockDataStore : IDataStore<VoterInformation>
    {
        Type d1 = typeof(List<>);

        List<VoterInformation> items;

        public VoterDetailsMockDataStore()
        {
            items = new List<VoterInformation>();
            var mockItems = new List<VoterInformation>
            {
                new VoterInformation {  ID= 111, Address = "BLOCK B(NEAR DISPENSARY) KUSUM PUR PHARI", Age=26,Assembly="45-Mehrauli",Booth="1: CHINMAYA SCHOOL, VASANT VIHAR KUSUMPUR PAHARI",Dead =false,Gender=Gender.Male,HouseNumber="42",Mobile1="9665097335",Mobile2="9999834748",Name="MD RAZIDUDDIN SIDDIK",PartNumber=1,SNo=61,RelativeName="MOHAMMAD MOINUDDIN SIDDIK",Village="KUSUMPUR PAHARI",VoterID="UBV2324539" },
                new VoterInformation {  ID= 222, Address = "145/9 K", Age=22,Assembly="45-Saket",Booth="1: Chinmaya School",Dead =false,Gender=Gender.Male,HouseNumber="142",Mobile1="9999163628",Mobile2="9999834748",Name="Mama",PartNumber=1,SNo=2,RelativeName="S.N Jha",Village="J ",VoterID="UBV1905669" },
                new VoterInformation {  ID= 333, Address = "142/9 R", Age=22,Assembly="45-Kutub",Booth="1: Chinmaya School",Dead =false,Gender=Gender.Male,HouseNumber="142",Mobile1="9665097335",Mobile2="9999834748",Name="Akash",PartNumber=1,SNo=3,RelativeName="S.N Jha",Village="T ",VoterID="UBV1905669" },
                new VoterInformation {  ID= 444, Address = "142/9 S", Age=22,Assembly="45-Water",Booth="1: Chinmaya School",Dead =false,Gender=Gender.Male,HouseNumber="142",Mobile1="9665097335",Mobile2="9999834748",Name="Akash",PartNumber=1,SNo=4,RelativeName="S.N Jha",Village="T ",VoterID="UBV1905669" },
                new VoterInformation {  ID= 555, Address = "142/9 D", Age=22,Assembly="45-Diwar",Booth="1: Chinmaya School",Dead =false,Gender=Gender.Male,HouseNumber="142",Mobile1="9665097335",Mobile2="9999834748",Name="Akash",PartNumber=1,SNo=5,RelativeName="S.N Jha",Village="M",VoterID="UBV1905669" },
                new VoterInformation {  ID= 666, Address = "142/9 A", Age=22,Assembly="45-Sonata",Booth="1: Chinmaya School",Dead =false,Gender=Gender.Male,HouseNumber="142",Mobile1="9665097335",Mobile2="9999834748",Name="Akash",PartNumber=1,SNo=6,RelativeName="S.N Jha",Village="Ki",VoterID="UBV1905669" },
                new VoterInformation {  ID= 777, Address = "142/9 H", Age=22,Assembly="45-Vik",Booth="1: Chinmaya School",Dead =false,Gender=Gender.Male,HouseNumber="142",Mobile1="9665097335",Mobile2="9999834748",Name="Akash",PartNumber=1,SNo=7,RelativeName="S.N Jha",Village="Ku",VoterID="UBV1905669" },
                new VoterInformation {  ID = 88, Address = "142/9 a", Age = 22, Assembly = "45-Mehrauli", Booth = "1: Chinmaya School", Dead = false, Gender = Gender.Male, HouseNumber = "142", Mobile1 = "9665097335", Mobile2 = "9999834748", Name = "Arash", PartNumber = 1, SNo = 8, RelativeName = "S.N Jha", Village = "Kusumpur Pahari", VoterID = "UBV1905669" },
                new VoterInformation {  ID = 99, Address = "142/9 h", Age = 22, Assembly = "45-Mehrauli", Booth = "1: Chinmaya School", Dead = false, Gender = Gender.Male, HouseNumber = "142", Mobile1 = "9665097335", Mobile2 = "9999834748", Name = "Aarsh", PartNumber = 1, SNo = 9, RelativeName = "S.N Jha", Village = "Kusumpur Pahari", VoterID = "UBV1905669" },
                new VoterInformation {  ID = 1011, Address = "142/9 r", Age = 22, Assembly = "45-Mehrauli", Booth = "1: Chinmaya School", Dead = false, Gender = Gender.Male, HouseNumber = "142", Mobile1 = "9665097335", Mobile2 = "9999834748", Name = "Aasth", PartNumber = 1, SNo = 10, RelativeName = "S.N Jha", Village = "Kusumpur Pahari", VoterID = "UBV1905669" },
                new VoterInformation {  ID = 1022, Address = "142/9 o", Age = 22, Assembly = "45-Mehrauli", Booth = "1: Chinmaya School", Dead = false, Gender = Gender.Male, HouseNumber = "142", Mobile1 = "9665097335", Mobile2 = "9999834748", Name = "Ayash", PartNumber = 1, SNo = 11, RelativeName = "S.N Jha", Village = "Kusumpur Pahari", VoterID = "UBV1905669" },
                new VoterInformation {  ID = 1033, Address = "142/9 d", Age = 22, Assembly = "45-Mehrauli", Booth = "1: Chinmaya School", Dead = false, Gender = Gender.Male, HouseNumber = "142", Mobile1 = "9665097335", Mobile2 = "9999834748", Name = "Aaush", PartNumber = 1, SNo = 12, RelativeName = "S.N Jha", Village = "Kusumpur Pahari", VoterID = "UBV1905669" },
                new VoterInformation {  ID = 1044, Address = "142/9 Delhi", Age = 22, Assembly = "45-Lady", Booth = "1: Chinmaya School", Dead = false, Gender = Gender.Male, HouseNumber = "142", Mobile1 = "9665097335", Mobile2 = "9999834748", Name = "Aiash", PartNumber = 1, SNo = 13, RelativeName = "S.N Jha", Village = "Kusumpur Pahari", VoterID = "UBV1905669" },
                new VoterInformation {  ID = 1055, Address = "142/9 Mumbai", Age = 22, Assembly = "45-Alpharetta", Booth = "1: Chinmaya School", Dead = false, Gender = Gender.Male, HouseNumber = "142", Mobile1 = "9665097335", Mobile2 = "9999834748", Name = "A1kash", PartNumber = 14, SNo = 1, RelativeName = "S.N Jha", Village = "Kusumpur Pahari", VoterID = "UBV1905669" },
                new VoterInformation {  ID = 1066, Address = "142/9 Pune", Age = 22, Assembly = "45-Sakoorbasti", Booth = "1: Chinmaya School", Dead = false, Gender = Gender.Male, HouseNumber = "142", Mobile1 = "9665097335", Mobile2 = "9999834748", Name = "Akash Jha", PartNumber = 15, SNo = 1, RelativeName = "S.N Jha", Village = "Kusumpur Pahari", VoterID = "UBV1905669" },
                new VoterInformation {  ID = 1077, Address = "142/9 Maharastra", Age = 22, Assembly = "45-Sikha", Booth = "1: Chinmaya School", Dead = false, Gender = Gender.Male, HouseNumber = "142", Mobile1 = "9665097335", Mobile2 = "9999834748", Name = "Asdf", PartNumber = 16, SNo = 1, RelativeName = "S.N Jha", Village = "Kusumpur Pahari", VoterID = "UBV1905669" },
                new VoterInformation {  ID = 1088, Address = "142/9 Gurgoan", Age = 22, Assembly = "45-Vivek", Booth = "1: Chinmaya School", Dead = false, Gender = Gender.Male, HouseNumber = "142", Mobile1 = "9665097335", Mobile2 = "9999834748", Name = "Akashsf", PartNumber = 17, SNo = 1, RelativeName = "S.N Jha", Village = "Kusumpur Pahari", VoterID = "UBV1905669" },
                new VoterInformation {  ID = 1099, Address = "142/9 Metro", Age = 22, Assembly = "45-New", Booth = "1: Chinmaya School", Dead = false, Gender = Gender.Male, HouseNumber = "142", Mobile1 = "9665097335", Mobile2 = "9999834748", Name = "Akashsdf", PartNumber = 18, SNo = 1, RelativeName = "S.N Jha", Village = "Kusumpur Pahari", VoterID = "UBV1905669" } };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }
        public async Task<bool> AddItemAsync(VoterInformation item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(VoterInformation item)
        {
            var oldItem = items.Where((VoterInformation arg) => arg.ID == item.ID).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = items.Where((VoterInformation arg) => arg.ID == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<VoterInformation> GetItemAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.ID == id));
        }

        public async Task<IEnumerable<VoterInformation>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }



    }
}
