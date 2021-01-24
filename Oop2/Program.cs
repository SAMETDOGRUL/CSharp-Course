using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GerçekMusteri musteri1 = new GerçekMusteri();
            musteri1.Id = 12;
            musteri1.MusterıNo = "2154653";
            musteri1.Adi = "samet";
            musteri1.Soyadı = "doğrul";
            musteri1.TCNo = "3656560";



            TuzelMüşteri musteri2 = new TuzelMüşteri();
            musteri2.Id = 35;
            musteri2.MusterıNo = "125235";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNO = "2564";

            


            Musteri musteri3 = new GerçekMusteri();
            Musteri musteri4 = new TuzelMüşteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
