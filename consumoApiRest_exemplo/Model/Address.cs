using System;

namespace Model
{
    public class Address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public Geo Geo { get; set; }

        public Address(string street, string suite, string city, string zipcode, Geo geo)
        {
            Street = street;
            Suite = suite;
            City = city;
            Zipcode = zipcode;
            Geo = geo;
        }


    }
}




