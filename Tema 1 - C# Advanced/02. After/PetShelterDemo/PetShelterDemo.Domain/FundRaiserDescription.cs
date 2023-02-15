using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelterDemo.Domain
{
    public class FundRaiserDescription:INamedEntity
    {
        public string Name { get; }
        public string description { get; }

        public string causeForDonation { get; set; }


        public FundRaiserDescription(string name, string description, string causeForDonation)
        {
            this.Name = name;
            this.description = description;
            this.causeForDonation = causeForDonation;
        }
    }
}
