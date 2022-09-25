using System;


namespace Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public Company Company { get; set; }

       
       public User(int id, string name, string username, string email, Address address, string phone, string website, Company company)
       {
           Id = id;
           Name = name;
           Username = username;
           Email = email;
           Address = address;
           Phone = phone;
           Website = website;
           Company = company;
       }


    }





}