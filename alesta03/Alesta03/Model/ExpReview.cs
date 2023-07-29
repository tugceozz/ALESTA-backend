﻿using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Alesta03.Model
{
    public class ExpReview
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public Person Person { get; set; }
        public int ?PersonId { get; set; }

        public Company Company { get; set; }
        public int ?CompanyId { get; set; }
    }
}
