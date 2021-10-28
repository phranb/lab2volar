using System;

namespace Interfaces3
{
    public class Superman : Volador
    {
        public string Mensaje = "Estoy volando como un campeon!! 🦸‍️";
        public float Experiencia = 0;

        public void Volar()
        {
            Experiencia += 3;
            Console.WriteLine(Mensaje);
            Console.WriteLine("Tengo Experiencia! " + Experiencia + "✨  ");
        }
    }
}