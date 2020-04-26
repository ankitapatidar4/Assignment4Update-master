using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace GHI.Models
{
    public class ChartRoot
    {
        public Hospital[] chart { get; set; }
    }

    public class Hospital
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public List<Hospital> Hospitals { get; set; }
        public Guid Id { get; set; }
        public string hospital_name { get; set; }
        public string city { get; set; }
        public string phone_number { get; set; }
        public string hospital_overall_rating { get; set; }
       
    }
}
