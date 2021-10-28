using System;

namespace Interfaces3
{
    public class Boeing : Volador
    {
        public string Mensaje = "Estoy volando como un avion!!! 🛫";
        public float Horas = 0;

        public void Volar()
        {
            Horas += 13;
            Console.WriteLine(Mensaje);
            Console.WriteLine("Horas: " + Horas + "⏱  ");
        }

    }
}