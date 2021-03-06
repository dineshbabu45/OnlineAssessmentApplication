﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineAssessmentProject.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateTestViewModel
    {
        public int TestId { get; set; }
        public int UserId { get; set; }
        
        [Display(Name = "Name of the Test")]
        [Required(ErrorMessage = "Test name is required.")]
        public string TestName { get; set; }
        public string Status { get; set; }
        [Required(ErrorMessage = "Date is required.")]
        [Display(Name = "Date")]
        public DateTime TestDate { get; set; }
        [Required(ErrorMessage = "Subject is required.")]
        public Subject Subject { get; set; }
        [Required(ErrorMessage = "Choose Start Time")]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }
        [Required(ErrorMessage = "Choose End Time")]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }
        [Required]
        public int Passcode { get; set; }
        [Required]
        public DateTime CreatedTime { get; set; }
        [Required]
        public int CreatedBy { get; set; }

        [Required]
        public Grade Grade { get; set; }
    }


}

