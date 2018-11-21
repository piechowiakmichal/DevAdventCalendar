﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevAdventCalendarCompetition.Repository.Models
{
    [Table("WrongAnswer")]
    public class TestWrongAnswer : ModelBase
    {
        [Required]
        [MaxLength(450)]
        [ForeignKey("User")]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public DateTime Time { get; set; }

        public String Answer { get; set; }
    }
}