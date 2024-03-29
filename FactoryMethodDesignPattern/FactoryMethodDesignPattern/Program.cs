﻿

// Kaynak : https://www.gencayyildiz.com/blog/c-factory-method-design-patternfactory-method-tasarim-deseni/

namespace FactoryMethodDesignMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Creater creater = new Creater();
            Oyun atariOyunu = creater.FactoryMethod(Oyunlar.Atari);
            Oyun pcOyunu = creater.FactoryMethod(Oyunlar.PC);
            Oyun psOyunu = creater.FactoryMethod(Oyunlar.PS);

            atariOyunu.Platform();
            pcOyunu.Platform();
            psOyunu.Platform();

            Console.Read();
        }
    }

    class Creater
    // class Creater<Oyun> where Oyun : Enum
    {

        public Oyun FactoryMethod(Oyunlar OyunTipi)
        {
            Oyun oyun = null;
            switch (OyunTipi)
            {
                case Oyunlar.Atari:
                    oyun = new Atari();
                    break;
                case Oyunlar.PC:
                    oyun = new PC();
                    break;
                case Oyunlar.PS:
                    oyun = new PS();
                    break;
            }
            return oyun;
        }
    }

    enum Oyunlar
    {
        Atari,
        PC,
        PS
    }

    interface Oyun
    {
        void Platform();
    }

    class Atari : Oyun
    {
        public void Platform()
        {
            Console.WriteLine("Bu oyun ATARİ platformunda çalışmaktadır.");
        }
    }

    class PC : Oyun
    {
        public void Platform()
        {
            Console.WriteLine("Bu oyun PC platformunda çalışmaktadır.");
        }
    }

    class PS : Oyun
    {
        public void Platform()
        {
            Console.WriteLine("Bu oyun PS platformunda çalışmaktadır.");
        }
    }
}