using SRP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SRP.Entities
{
    public class Persona : IBase
    {
        private string? nombre;
        private int edad;
        private string? direccion;
        private string? correoElectronico;

        public void EnviarCorreoElectronico(string mensaje)
        {
            //Logica para enviar correo electronico
        }
        
        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Direccion: {direccion}");
            Console.WriteLine($"Correo electronico: {correoElectronico}");
        }
    }
}
