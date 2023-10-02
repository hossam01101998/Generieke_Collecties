using Generieke_Collecties;
class Program
{
    static void Main()
    {

        //INTEGER


        Stapel<int> integerStapel = new Stapel<int>();

        integerStapel.Opzetten(1);
        integerStapel.Opzetten(2);
        integerStapel.Opzetten(3);

        Console.WriteLine("INTEGER:");
        Console.WriteLine(integerStapel.ToString());

        int afhaleninteger = integerStapel.Afhalen();

        Console.WriteLine("Afgehaalde waarde : " + afhaleninteger);
        Console.WriteLine(integerStapel.ToString());

        integerStapel.Leegmaken();
        Console.WriteLine(integerStapel.ToString());


        //STRINGS


        Stapel<string> stringstapel = new Stapel<string>();

        stringstapel.Opzetten("AUDI");
        stringstapel.Opzetten("VW");
        stringstapel.Opzetten("LAMBORGHINI");
        stringstapel.Opzetten("TOYOTA");

        Console.WriteLine("STRING:");
        Console.WriteLine(stringstapel.ToString());

        string afhalenstring = stringstapel.Afhalen();

        Console.WriteLine("Afgehaalde string : " + afhalenstring);
        Console.WriteLine(stringstapel.ToString());

        stringstapel.Leegmaken();
        Console.WriteLine(stringstapel.ToString());


        //CLASS

        Auto a1 = new Auto("Mercedes a45", 360);
        Auto a2 = new Auto("Porsche 911", 450);
        Auto a3 = new Auto("Lamborghini Gallardo", 500);
       

        Stapel<Auto> autostapel = new Stapel<Auto>();

        autostapel.Opzetten(a1);
        autostapel.Opzetten(a2);
        autostapel.Opzetten(a3);
        autostapel.Opzetten(new Auto("Volvo", 200));

        Console.WriteLine("Class");
        Console.WriteLine(autostapel.ToString());

        Auto afhalenauto = autostapel.Afhalen();

        Console.WriteLine("Afgehaalde Auto: " + afhalenauto);
        Console.WriteLine(autostapel.ToString());

        autostapel.Leegmaken();
        Console.WriteLine(autostapel.ToString());







    }
}