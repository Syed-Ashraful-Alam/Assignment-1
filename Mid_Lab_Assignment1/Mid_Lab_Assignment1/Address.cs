using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment1
{
    class Address
    {
        private string roadNo;
        private string houseNo;
        private string city;
        private string country;


        public string RoadNo
        {
            get { return this.roadNo; }
            set { this.roadNo = value; }
        }

        public string HouseNo
        {
            get { return this.houseNo; }
            set { this.houseNo = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        public string GetAddress ()
        {
          string address = "\nRoad No : " +roadNo + "\nHouse No : " +houseNo + "\nCity : " +city + "\nCountry :" +country + "\n";
          return address;
        }
    }
}
