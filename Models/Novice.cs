using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace HomeschoolHeroes.Models
{
    public class Novice
    {
        public int NoviceId {get; set;}
        public int StudentId {get;set;}
        public int SubjectId {get;set;}

        public Student Student {get;set;}
        public Subject Subject {get;set;}

    }
}