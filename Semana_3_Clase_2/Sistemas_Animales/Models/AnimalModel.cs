using System;
using System.Collections.Generic;
using System.Text;

namespace Sistemas_Animales.Models
{
    public class AnimalModel
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
    }
}
