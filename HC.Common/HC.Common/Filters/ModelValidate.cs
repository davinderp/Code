﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HC.Common.Filters
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }

    public class RequiredDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // your validation logic

            var types = Enum.GetNames(typeof(System.TypeCode));

            if (value.GetType().ToString().ToLower() == "system.datetime" && (DateTime)value > Convert.ToDateTime("01/01/0001"))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("The "+ validationContext.DisplayName + " field is required.");
            }


        }
    }

    public class RequiredNumber : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // your validation logic
            try
            {
          
            var types = Enum.GetNames(typeof(System.TypeCode));

            if ((value.GetType().ToString() == "System.Int32" || value.GetType().ToString() == "System.Int64"|| value.GetType().ToString() == "System.Double") && !value.Equals(0) )
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("The " + validationContext.DisplayName + " field is required.");
            }
            }
            catch (Exception ex)
            {

                throw;
            }



        }
    }

    //public class RequiredBoolean : ValidationAttribute
    //{
    //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    {
    //        // your validation logic

    //        var types = Enum.GetNames(typeof(System.TypeCode));

    //        if (value.GetType().ToString() == "System.Boolean" && (bool)value > 0)
    //        {
    //            return ValidationResult.Success;
    //        }
    //        else
    //        {
    //            return new ValidationResult("The " + validationContext.DisplayName + " field is required.");
    //        }


    //    }
    //}




}
