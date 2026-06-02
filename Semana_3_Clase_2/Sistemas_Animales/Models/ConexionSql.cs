using System;
using System.Collections.Generic;
using System.Text;

namespace Sistemas_Animales.Models
{
    public static class ConexionSql
    {
        public static string cadena = "server=.;uid=sa;pwd=123;database=Veterinaria;Trusted_Connection=True;TrustServerCertificate=True";
        //con usuario y contraseña   -- ya cuando este en produccion
        //server
        //database
        //uid
        //pwd
        //Trusted_Connection=True
        //TrustServerCcertificate=True
        //public static string cadena = "server=.;database=Veterinaria;Trusted_Connection=True;TrustServerCcertificate=True";
        //conectarse con el usuario dde windows  -- en desarrollo
        //server
        //database
        //Trusted_Connection=True
        //TrustServerCcertificate=True



    }
}
