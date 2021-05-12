using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Diploma.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength =3)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Url)]
        [Display(Name ="Ссылка на картинку")]
        public string Url { get; set; }
        public bool OnMainPage { get; set; }

    }
}
