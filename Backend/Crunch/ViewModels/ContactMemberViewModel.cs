using System;
using System.Collections.Generic;
using Crunch.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Crunch.ViewModels
{
    public class ContactMemberViewModel
    {
        [Required]
        public Email  email  { get; set; }
        public User user { get; set; }

        [Required(ErrorMessage = "Please click on the 'I\'m not a robot' box at the bottom of the page")]
        [FromForm(Name = "g-recaptcha-response")]
        public string ReCaptcha { get; set; }
    }

    public class CaptchaVerification
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error-codes")]
        public List<String> Errors { get; set; }
    }
}
