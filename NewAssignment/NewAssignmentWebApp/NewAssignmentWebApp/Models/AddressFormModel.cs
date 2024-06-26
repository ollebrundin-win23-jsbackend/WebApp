﻿using System.ComponentModel.DataAnnotations;

namespace NewAssignmentWebApp.Models
{
    public class AddressFormModel
    {
        [DataType(DataType.Text)]

        public string? Address1 { get; set; }

        [DataType(DataType.Text)]

        public string? Address2 { get; set; }

        [DataType(DataType.Text)]

        public string? PostalCode { get; set; }

        [DataType(DataType.Text)]
        //Finns städer med namn som är kortare än 2 bokstäver, så gör ingen MinLength här.

        public string? City { get; set; }

        public bool OnInitAlreadyLoaded { get; set; } = false;
    }
}
