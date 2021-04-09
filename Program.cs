using System;

namespace ArcheryScorer
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Selamat datang di ArcheryScorer!");

            Console.WriteLine("Merk busur?");
            string Brand = Console.ReadLine();

            Console.WriteLine("Model busur?");
            string Name = Console.ReadLine();

            Console.WriteLine("Tipe busur?\n1:Compound\n2:Recurve");
            string Type = Console.ReadLine();

            if (Type == "1")
                Type = "Compound";
            else
                Type = "Recurve";

            Console.WriteLine("Panjang tarikan? (inch)");
            double DrawLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Berat tarikan? (lbs)");
            double DrawWeight = Convert.ToDouble(Console.ReadLine());

            Bow Compound = new Bow(Brand, Name, Type, DrawLength, DrawWeight);
            RecurveBow Recurve = new RecurveBow(Brand, Name, Type, DrawLength, DrawWeight);

            int jumlah = 0;
            int A = 0;
            decimal ratarata = 0;

            Console.WriteLine("Masukkan nilai skor anda per rambahan");

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("Rambahan {0}:", i);
                for (int j = 1; j <=6 ; j++)
                {
                    Console.Write("Anak panah {0}: ", j);
                    A = int.Parse(Console.ReadLine());
                    jumlah = jumlah + A;
                    Console.Write("\n");
                }
            }
            ratarata = jumlah / 36;

            Console.WriteLine("Skor anda dalam satu sesi adalah: {0} poin dengan rata-rata per anak panah {1} poin", jumlah, ratarata);

            if (Type == "Compound")
            {
                Compound.showBowInformation();

                double speed = Compound.SpeedRating(DrawLength, DrawWeight);
                Console.WriteLine("Rating kecepatan dari busur ini adalah {0} fps", speed);
            }
            else
            {
                Console.WriteLine("Busur anda adalah {2} {0} {1} dengan {3} lbs draw weight dan {4} inch draw length", Brand, Name, Type, DrawWeight, DrawLength);
            
                double speed = Recurve.SpeedRating(DrawLength, DrawWeight);
                Console.WriteLine("Rating kecepatan dari busur ini adalah {0} fps", speed);
            }
        }
    }
}
