﻿using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace ABM_CLIENTES.Models.Validators

{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var context = (AbmclientesContext)validationContext.GetService(typeof(AbmclientesContext));
            var email = value as string;

            if (context.Clientes.Any(c => c.Email == email))
            {
                return new ValidationResult("El email ya está en uso.");
            }

            return ValidationResult.Success;
        }
    }
}
