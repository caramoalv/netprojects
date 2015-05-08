using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETMVC.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Saludo { get; set; }

        public Persona()
        {
            Saludo = "Hola ";
            Nombre = string.Empty;
        }
}