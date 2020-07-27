using System;
using Angkot.AngkotClass;

namespace Angkot
{
    class Program
    {
        static void Main(string[] args)
        {
            Kendaran kendaraan;

            Console.WriteLine();
            kendaraan = new Angkot1();
            kendaraan.KodeAngkot();
            kendaraan.Jurusan();
            kendaraan.Operasi();

            Console.WriteLine();
            kendaraan = new Angkot2();
            kendaraan.KodeAngkot();
            kendaraan.Jurusan();
            kendaraan.Operasi();

            Console.WriteLine();
            kendaraan = new Angkot3();
            kendaraan.KodeAngkot();
            kendaraan.Jurusan();
            kendaraan.Operasi();

            Console.WriteLine();
            kendaraan = new Angkot4();
            kendaraan.KodeAngkot();
            kendaraan.Jurusan();
            kendaraan.Operasi();

            Console.WriteLine();
            kendaraan = new Angkot5();
            kendaraan.KodeAngkot();
            kendaraan.Jurusan();
            kendaraan.Operasi();

            Console.ReadKey();
        }
    }
}
