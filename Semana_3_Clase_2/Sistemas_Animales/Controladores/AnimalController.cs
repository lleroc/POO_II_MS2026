using Sistemas_Animales.Data;
using Sistemas_Animales.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Sistemas_Animales.Controladores
{
    public class AnimalController
    {
        public List<AnimalModel> todos() {
            return AnimalData.Todos();
        }
        
        public AnimalModel uno(int id) {
            return AnimalData.uno(id);
        }
        public string Nuevo(string nombre,string raza, string sexo, int edad) {
            AnimalModel model = new AnimalModel { 
                Edad = edad,
                Nombre = nombre,
                Raza = raza,
                Sexo = sexo
            };
            return AnimalData.Nuevo(model);
        }
        public string editar(int id, string nombre, string raza, string sexo, int edad) {
            AnimalModel model = new AnimalModel
            {
                id = id,
                Edad = edad,
                Nombre = nombre,
                Raza = raza,
                Sexo = sexo
            };
            return AnimalData.Editar(model);
        }
        public string eliminar(int id) 
        { 
            return AnimalData.Eliminar(id);
        }



    }
}
