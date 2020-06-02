using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace HomeschoolHeroes.Models
{
    public class Teacher : User
    {
        [Key]
        public int TeacherId {get; set;}

        public string PrimarySubject {get;set;}
        public string GradeTaught {get;set;}
        public int StudentLimit {get;set;}

        //navigation property
        public List<Expert>Experts {get;set;}

    }
}