﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidPlace.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            // if customer chooses pay as you go --> no validation error
            if (customer.MembershipId == Membership.Unknown || customer.MembershipId == Membership.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            
            // Customer chose other plans (Monthly, Quarterly, Annual)
            // When birthdate is not entered
            if(customer.Birthdate == null)
            {
                return new ValidationResult("Your birthdate is required for a paid plan");
            }

            // Calculate the age
            var age = DateTime.Now.Year - customer.Birthdate.Value.Year;

            return (age >= 18) ?
                ValidationResult.Success :
                new ValidationResult("You must be at least 18 years old to register for a paid plan.");
        }
    }
}