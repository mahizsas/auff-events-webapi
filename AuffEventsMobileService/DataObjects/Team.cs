﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Mobile.Service;
using Newtonsoft.Json;

namespace AuffEventsMobileService.DataObjects
{
    public class Team :EntityData
    {
        public Team()
        {
            EntryForms = new List<EntryForm>();
            TeamMembers = new List<TeamMember>();
        }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateBirth { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        //public string ManagerId { get; set; }
        public string ImageUrl { get; set; }
        [JsonIgnore]
        public virtual ICollection<EntryForm> EntryForms { get; set; }
        [JsonIgnore]
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
    }
}