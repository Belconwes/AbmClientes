using ABM_CLIENTES.Models.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ABM_CLIENTES.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    [Required(ErrorMessage = "El campo Email es obligatorio.")]
    [EmailAddress(ErrorMessage = "Ingrese un email válido.")]
    [UniqueEmail] // Validación personalizada
    public string? Email { get; set; }
    [Required(ErrorMessage = "El campo Teléfono es obligatorio.")]
    [Phone(ErrorMessage = "Ingrese un número de teléfono válido.")]
    [UniquePhone] // Validación personalizada
    public string? Telefono { get; set; }
    [Required(ErrorMessage = "El campo Dirección es obligatorio.")]
    public string? Direccion { get; set; }
    [Required(ErrorMessage = "El campo Ciudad es obligatorio.")]
    public string? Ciudad { get; set; }
    [Required(ErrorMessage = "El campo Código Postal es obligatorio.")]
    public string? Pais { get; set; }

    public string? CodigoPostal { get; set; }
    [Required(ErrorMessage = "El campo Fecha de Registro es obligatorio.")]
    [DataType(DataType.Date)]
    public DateOnly? FechaRegistro { get; set; }
}
