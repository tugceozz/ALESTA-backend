﻿namespace Alesta03.Model
{
    public class Company
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FDate { get; set; }
        public int TotalStaff { get; set; }
        public string Location { get; set; }
        public string Prof { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public DateTime UpdateDate { get; set; }  

        public User Users { get; set; }
        public string UsersId { get; set; }

        public List<ExpReviews> Reviews { get; set; }

        public List<BackEdu> BackEdus { get; set; }

    }
}
