using Sistemas_Animales.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistemas_Animales.Data
{
    public static class AnimalData
    {
        private static List<AnimalModel> _lista_animales = new List<AnimalModel>() {
            new AnimalModel{
                id = 1,
                Edad = 3,
                Nombre = "Lulu",
                Raza ="pastor aleman",
                Sexo = "Hembra"
            },
            new AnimalModel{
                id = 2,
                Edad = 2,
                Nombre = "Ñato",
                Raza ="Gato Persa",
                Sexo = "Macho"
            }
        };
        public static List<AnimalModel> Todos() {
            return _lista_animales;
        }
        public static AnimalModel uno(int id) {
            return _lista_animales.FirstOrDefault(a => a.id == id);
        }
        public static string Nuevo(AnimalModel animal) {
            try
            {
                animal.id = _lista_animales.Count > 0 ? _lista_animales.Max(a => a.id) + 1 : 1;
                _lista_animales.Add(animal);
                return "ok";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }
        public static string Editar(AnimalModel animal)
        {
            try
            {
                AnimalModel animalexistennte = uno(animal.id);
                if (animalexistennte == null)
                {
                    return "Error al editar";
                }
                if (animal.id != animalexistennte.id)
                {
                    return "Error al editar";
                }
                animalexistennte.Raza = animal.Raza;
                animalexistennte.Edad = animal.Edad;
                animalexistennte.Nombre = animal.Nombre;
                animalexistennte.Sexo = animal.Sexo;
                return "ok";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }

        public static string Eliminar(int id) { 
            AnimalModel animalModel = uno(id);
            if (animalModel != null)
            {
                _lista_animales.Remove(animalModel);
                return "ok";
            }
            
            else {
                return "Eror al eliminar";
            }
        }
    }
}
