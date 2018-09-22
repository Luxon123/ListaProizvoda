using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Items.Models
{
    public class Proizvod
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(25)]
        public string Opis { get; set; }

        [Required]
        [StringLength(25)]
        public string Kategorija { get; set; }

        [Required]
        [StringLength(25)]
        public string Proizvodjac { get; set; }

        [Required]
        [StringLength(25)]
        public string Dobavljac { get; set; }


        public float Cena { get; set; }
    }
}