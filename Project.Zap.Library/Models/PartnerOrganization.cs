﻿using System;
using System.Text.Json.Serialization;

namespace Project.Zap.Library.Models
{
    public class PartnerOrganization
    {
        [JsonPropertyName("id")]
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }

        public string RegistrationCode { get; set; }
    }

}
