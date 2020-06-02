using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace HomeschoolHeroes.Models
{
    public class Student : User
    {
        [Key]
        public int StudentId {get; set;}

        public int GradeLevel {get;set;}

        public List<Novice>Novices {get;set;}

    }
}