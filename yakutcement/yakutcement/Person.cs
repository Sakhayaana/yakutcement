﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
    public enum Position { Manager, Keeper, Admin, PlantMan, QuarryMan }
    public enum Level { Manager, Keeper, Admin, PlantMan, QuarryMan, Client }

    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String SecondName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Position Position { get; set; }
        public double Salary { get; set; }
        public Level Level { get; set; }
        [StringLength(30)]
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
