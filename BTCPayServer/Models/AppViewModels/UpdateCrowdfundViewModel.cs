﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BTCPayServer.Models.AppViewModels
{
    public class UpdateCrowdfundViewModel
    {
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        
        [MaxLength(50)]
        public string Tagline { get; set; }
        
        [Required]
        public string Description { get; set; }
        public string MainImageUrl { get; set; }
        
        public string NotificationUrl { get; set; }
        
        [Required]
        public bool Enabled { get; set; } = false;
        
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        
        [Required]
        [MaxLength(5)]
        [Display(Name = "The primary currency used for targets and stats")]
        public string TargetCurrency { get; set; }
        
        [Display(Name = "Set a Target amount ")]
        public decimal? TargetAmount { get; set; }
        
        
        [Display(Name = "Do not allow additional contributions after target has been reached")]
        public bool EnforceTargetAmount { get; set; }

        [Display(Name = "Contribution Perks Template")]
        public string PerksTemplate { get; set; }
        
        [MaxLength(500)]
        [Display(Name = "Custom bootstrap CSS file")]
        public string CustomCSSLink { get; set; }

        public string EmbeddedCSS { get; set; }
    }
}
