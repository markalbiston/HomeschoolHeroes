using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace HomeschoolHeroes.Models
{
    public class Expert
    {
        public int ExpertId {get; set;}
        public int TeacherId {get;set;}
        public int SubjectId {get;set;}

        public Teacher Teacher {get;set;}
        public Subject Subject {get;set;}

    }
}