using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ABM_CLIENTES.Models.Validators 
{
    public class UniquePhoneAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var context = (AbmclientesContext)validationContext.GetService(typeof(AbmclientesContext));
            var telefono = value as string;

            if (context.Clientes.Any(c => c.Telefono == telefono))
            {
                return new ValidationResult("El número de teléfono ya está en uso.");
            }

            return ValidationResult.Success;
        }
    }
}
