using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generieke_Collecties
{
    internal class Stapel<T>
    {

        private List<T> items;   

        public Stapel()     
        {

            items = new List<T>();
         }

        public void Opzetten(T item)
        {
            items.Add(item);
        }

        public T Afhalen()
        {

            if (items.Count == 0)
            {
                throw new InvalidOperationException("De stapel is leeg.");
            }

            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public void Leegmaken()
        {
            items.Clear();
        }

        public override string ToString()
        {

            string result = "Stapel Inhoud:\n";

            for (int i = items.Count - 1; i >= 0; i--){

                string indent = new string(' ', items.Count - 1 - i);
                result += $"{indent}{items[i]}\n";

            }
            return result;
        }
    }
}
