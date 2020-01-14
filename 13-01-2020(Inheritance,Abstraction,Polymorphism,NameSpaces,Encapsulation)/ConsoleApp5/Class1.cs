using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Address
    {
        public String addressLine, city, state, country;
        public Address(String addressLine, String city, String state, String country)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
            this.country = country;
        }
    }
}
