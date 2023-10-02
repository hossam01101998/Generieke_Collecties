using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generieke_Collecties
{
    internal class Auto
    {
        private static int idTeller = 1;
        public int ID { get; set; }
        public string Naam {  get; set; }
        public int Hp { get; set; }

        public Auto(string naam, int hp)
        {
            ID = idTeller++;
            Naam = naam;
            Hp = hp;

        }
        public override string ToString()
        {
            return $"(Id: {ID}, Naam: {Naam}, Hp: {Hp})";
        }
    }
}
