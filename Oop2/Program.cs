﻿using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //sahis
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "1234567890";

            //kodlama İo


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


        }
    }
}
