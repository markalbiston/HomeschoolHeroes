using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace HomeschoolHeroes.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId {get; set;}

        public string Title {get;set;}
        public int GradeLevel {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        //navigatin property for related subjects

        public List<Expert>Experts {get;set;}
        public List<Novice>Novices {get;set;}
    }
}