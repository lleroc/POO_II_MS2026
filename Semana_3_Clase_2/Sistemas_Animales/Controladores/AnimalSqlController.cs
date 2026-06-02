using Sistemas_Animales.Data;
using Sistemas_Animales.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistemas_Animales.Controladores
{
    public class AnimalSqlController
    {
        public List<AnimalModel> todos() {
            return AnmalSqlData.todos();
        }
        public AnimalModel uno(int id) {
            return AnmalSqlData.uno(id);
        }
        public string Nuevo(string nombre, string raza, string sexo, int edad)
        {
            AnimalModel model = new AnimalModel
            {
                Edad = edad,
                Nombre = nombre,
                Raza = raza,
                Sexo = sexo
            };
            return AnmalSqlData.Nuevo(model);
        }
        public string editar(int id, string nombre, string raza, string sexo, int edad)
        {
            AnimalModel model = new AnimalModel
            {
                id = id,
                Edad = edad,
                Nombre = nombre,
                Raza = raza,
                Sexo = sexo
            };
            return AnmalSqlData.Editar(model);
        }
        public string eliminar(int id)
        {
            return AnmalSqlData.Eliminar(id);
        }
    }
}
