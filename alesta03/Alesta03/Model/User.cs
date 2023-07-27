﻿namespace Alesta03.Model
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string UserType { get; set; }

        public List<Company> Companies { get; set; }
        public List<Person> People { get; set; }

        public Roles Roles { get; set; }
        public string RolesId { get; set; }
    }
}
