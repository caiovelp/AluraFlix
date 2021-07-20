using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AluraChallenge.Models
{
    public class Video
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo título é obrigatório.")]
        [StringLength(100, ErrorMessage = "Deve conter no máximo 100 caracteres")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        [StringLength(5000, ErrorMessage = "Deve conter no máximo 5000 caracteres")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo url é obrigatório.")]
        [RegularExpression("^((?:https?:)?\\/\\/)?((?:www|m)\\.)?((?:youtube\\.com|youtu.be))(\\/(?:[\\w\\-]+\\?v=|embed\\/|v\\/)?)([\\w\\-]+)(\\S+)?$", ErrorMessage ="Informe uma URL válida")]
        public string URL { get; set; }

    }
}
