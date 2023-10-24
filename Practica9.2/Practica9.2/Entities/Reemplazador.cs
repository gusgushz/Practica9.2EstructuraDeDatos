using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9._2.Entities
{
    internal class Reemplazador
    {
        public Stack<int> numeros = new();
        public void AgregarNumeros(int cantidad)
        {
            Random ran = new();
            for (int i = 0; i < cantidad; i++)
            {
                numeros.Push(ran.Next(100));
            }
        }
        public Stack<int> Reemplazar(int viejo, int nuevo)
        {
            Stack<int> alreves = new();
            //Ida para reemplzar valor viejo por valor nuevo
            while (numeros.Count > 0)
            {
                int num = numeros.Pop();
                if(num == viejo)
                {
                    alreves.Push(nuevo);
                } else 
                {
                    alreves.Push(num);
                }
            }
            //Vuelta para dejarlos como estaban.
            while (alreves.Count > 0)
            {
                numeros.Push(alreves.Pop());
            }
            return numeros;
        }
    }
}
