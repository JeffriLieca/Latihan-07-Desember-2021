using System;
using System.Collections.Generic;
using System.Linq;

namespace Latihan_07_Desember_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INPUT KALIMAT: ");
            string kalimat = Console.ReadLine().ToUpper();
            var listHuruf = new List<char>();
            var tampung = new List<char>();
            var huruf = new List<char>();
            int jumlahHurufTotal = 0;
            while (kalimat.Split().Length - 1 < 3)
            {
                Console.WriteLine("KATA PADA KALIMAT KURANG PANJANG");
                Console.Write("INPUT KALIMAT: ");
                kalimat = Console.ReadLine().ToUpper();
            }
            for (int i = 0; i < kalimat.Length; i++)
                listHuruf.Add(kalimat[i]);
            Console.Write("INPUT KATA: ");
            string kata = Console.ReadLine().ToUpper();
            while (kata.Length <= 1)
            {
                Console.WriteLine("HURUF PADA KATA KURANG PANJANG");
                Console.Write("INPUT KATA: ");
                kata = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("OUTPUT");
            Console.WriteLine("STATISTIK HURUF:");
            var query = listHuruf.GroupBy(x => x).Where(g => g.Count() >= 1).Select(y => y.Key).ToList();
            query.Remove(' ');
            for (int i = 0; i < query.Count;i++)
                if (char.IsLetterOrDigit(query[i]))
                    tampung.Add(query[i]);
            tampung.Sort();
            for (int i = 0; i < query.Count; i++)
            {
                if (char.IsLetterOrDigit(query[i])) { }
                else
                    tampung.Add(query[i]);
            }
            for (int i = 0; i < tampung.Count; i++)
            {
                int jumlahHuruf=kalimat.Split(tampung[i]).Count()-1;
                Console.WriteLine($"{tampung[i]}: {jumlahHuruf} HURUF");
                jumlahHurufTotal+= jumlahHuruf;
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("STATISTIK KATA:");
            Console.WriteLine($"{kata}: {kalimat.Split(kata).Length-1} KATA");
            Console.WriteLine();
            Console.WriteLine($"JUMLAH HURUF: {jumlahHurufTotal} HURUF");

        }
    }
}
