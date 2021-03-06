﻿namespace BusinessObjects.BusinessRules
{
    
    // credit card validation rule.
    // match a credit card number to be entered as four sets of four digits separated 
    // by a space, -, or no character at all

    public class ValidateCreditcard : ValidateRegex
    {
        
        public ValidateCreditcard(string propertyName) :
            base(propertyName, @"^((\d{4}[- ]?){3}\d{4})$")
        {
            Error = propertyName + " is not a valid credit card number";
        }

        public ValidateCreditcard(string propertyName, string errorMessage) :
            this(propertyName)
        {
            Error = errorMessage;
        }
    }
}
