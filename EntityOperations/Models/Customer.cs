﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityOperations
{
    public partial class Customer
    {
        public int Identifier { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string AccountNumber { get; set; } 
        public int? ContactTypeIdentifier { get; set; }
        public int? GenderIdentifier { get; set; }
        [NotMapped]
        public string Gender => GenderIdentifierNavigation.GenderType;
        [NotMapped]
        public string ContactType => ContactTypeIdentifierNavigation.ContactType;

        public virtual ContactTypes ContactTypeIdentifierNavigation { get; set; }
        public virtual Genders GenderIdentifierNavigation { get; set; }
    }
}