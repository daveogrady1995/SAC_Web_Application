﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAC_Web_Application.Models.ClubModel
{
    public class Events
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventID { get; set; }
        [Required]
        [Display(Name ="Event Name")]
        public string EventTitle { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Please enter a valid Date of birth")]
        public DateTime Date { get; set; }
        public string Category { get; set; }
        [Required]
        public string Location { get; set; }

        public List<MemberEvent> MemberEvents { get; set; }
    }
}
