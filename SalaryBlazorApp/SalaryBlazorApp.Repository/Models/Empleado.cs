using System.ComponentModel.DataAnnotations;

namespace SalaryBlazorApp.Repository.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El legajo es obligatorio")]
        public string Legajo { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El apellido de casada es obligatorio")]
        public string ApellidoCasada { get; set; }
        [Required(ErrorMessage = "Los nombres son obligatorios")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El CUIL es obligatorio")]
        public string Cuil {  get; set; }
        [Required(ErrorMessage = "El C.A.T. es obligatorio")]
        public string Cat { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "La nacionalidad es obligatorio")]
        public string Nacionalidad { get; set; }
        [Required(ErrorMessage = "Seleccione el tipo de sexo")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Seleccione el estado civil")]
        public string EstadoCivil { get; set; }
        [Required(ErrorMessage = "Seleccione el tipo de documento")]
        public string TipoDocumento { get; set; }
        [Required(ErrorMessage = "El número de documento es obligatorio")]
        public string NroDocumento { get; set; }
        [Required(ErrorMessage = "Seleccione la provincia de emisión")]
        public string ProvinciaEmision { get; set; }
        [Required(ErrorMessage = "El domicilio es obligatorio")]
        public string DomicilioCalle { get; set; }
        [Required(ErrorMessage = "El número de domicilio es obligatorio")]
        public string DomicilioNro { get; set; }
        [Required(ErrorMessage = "El piso del domicilio es obligatorio")]
        public string DomicilioPiso { get; set; }
        [Required(ErrorMessage = "El depto del domicilio es obligatorio")]
        public string DomicilioDepto { get; set; }
        [Required(ErrorMessage = "El C.P. es obligatorio")]
        public string DomicilioPostal { get; set; }
        [Required(ErrorMessage = "Seleccione la localidad")]
        public string Localidad { get; set; }
        [Required(ErrorMessage = "Seleccione la provincia")]
        public string Provincia { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Seleccione la situación")]
        public string Situacion { get; set; }
        [Required(ErrorMessage = "El código de baja es obligatorio")]
        public string CodigoBaja { get; set; }
        [Required(ErrorMessage = "El caracter de servicio es obligatorio")]
        public string CaracterServicio { get; set; }
        [Required(ErrorMessage = "La categoría es obligatorio")]
        public string Categoria { get; set; }
        public bool Discapacidad { get; set; }
        [Required(ErrorMessage = "El domicilio de explotación es obligatorio")]
        public string DomicilioExplotacion { get; set; }
        [Required(ErrorMessage = "Las observaciones son obligatorias")]
        public string Observaciones { get; set; }
    }
}
