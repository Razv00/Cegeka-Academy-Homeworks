using PetShelterDemo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelterDemo.Domain
{
    public class Fundraiser
    {

        private int totalDonations = 0;

        private readonly IRegistry<FundRaiserDescription> fundRaiserRegistry;

        private readonly IRegistry<Person> donorRegistry;


        public Fundraiser()
        {
            donorRegistry = new Registry<Person>(new Database());
            fundRaiserRegistry = new Registry<FundRaiserDescription>(new Database());
        }

        public void registerFundRaiser(FundRaiserDescription fundRaiserDescription)
        {
            fundRaiserRegistry.Register(fundRaiserDescription);
        }

        public void donate(Person donor, int amountInRON)
        {
            donorRegistry.Register(donor);
            totalDonations += amountInRON;
        }
        public int getTotalDonations()
        {
            return totalDonations;
        }

        public IReadOnlyList<FundRaiserDescription> getAllFundRaisers()
        {
            return fundRaiserRegistry.GetAll().Result;
        }


        public FundRaiserDescription GetByName(string name)
        {
            return fundRaiserRegistry.GetByName(name).Result;
        }

        public IReadOnlyList<Person> GetAllDonors()
        {
            return donorRegistry.GetAll().Result;
        }
    }
}
