using System;

namespace Interfaces3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            Boeing boeing747 = new Boeing();
            Superman superman = new Superman();
            TorreDeControl torreDeControl = new TorreDeControl();

            pato.Volar();
            boeing747.Volar();
            boeing747.Volar();
            superman.Volar();
            
            torreDeControl.AgregarVolador(pato);
            torreDeControl.AgregarVolador(boeing747);
            torreDeControl.AgregarVolador(superman);
            Console.WriteLine("* ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ *");
            Console.WriteLine("*Arrancan volando todos!*");
            torreDeControl.VuelenTodos();
            
            
        }
    }
}