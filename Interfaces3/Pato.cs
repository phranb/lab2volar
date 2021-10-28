using System;

namespace Interfaces3
{
    public class Pato : Volador
    {
        public string Mensaje = "Estoy volando como un pato 🦆! Quack";
        public int Energia = 5;

        public void Volar()
        {
            Energia--;
            Console.WriteLine(Mensaje);
            Console.WriteLine("Mi energia es: " + Energia + "🔋  ");
        }
    }
}