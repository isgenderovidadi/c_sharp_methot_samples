using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpFundamentals
{
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; }
        public int MaxHiz { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Marka}-{Model} çalıştı.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Marka}-{Model} stop edildi.");
        }

        public void Yavasla()
        {
            Console.WriteLine($"{Marka}-{Model} yavaşlıyor.");
        }

        public void Hizlan()
        {
            Console.WriteLine($"{Marka}-{Model} hızlanıyor.");
        }

        public void Hizlan(int km)
        {
            if (km > MaxHiz)
            {
                Console.WriteLine("Maksimum hızı aşamayız");
            }
            else
            {
                Console.WriteLine($"{Marka} {Model} {km} km hıza getiriliyor.");
            }
        }

        public void Hizlan(int km, string mod)
        {

        }

        public void Menu()
        {
            string komut = "";
            do
            {
                Console.WriteLine("Seçiminiz : 1-Start 2-Hızlan 3-Yavaşla 4-Stop");
                komut = Console.ReadLine();

                switch (komut)
                {
                    case "1":
                        this.Start();
                        break;
                    case "2":
                        Console.WriteLine("Hız bilgisi girmek istiyor musunuz ? (e/h)");
                        string secim = Console.ReadLine();

                        if (secim == "e")
                        {
                            Console.WriteLine("km :");
                            int km = int.Parse(Console.ReadLine());
                            this.Hizlan(km);
                        }
                        else
                        {
                            this.Hizlan();
                        }

                        break;
                    case "3":
                        this.Yavasla();
                        break;
                    case "4":
                        this.Stop();
                        break;
                    default:
                        break;
                }

            } while (komut != "Ç");
        }

        public string Yaz()
        {
            return string.Format($"Marka : {this.Marka} Model : {this.Model} Renk : {this.Renk} Otomatik : {this.Otomatik}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Araba opel = new Araba();

            opel.Marka = "Opel";
            opel.Model = "Astra";
            opel.Renk = "Beyaz";
            opel.Otomatik = true;
            opel.MaxHiz = 200;

            Araba mazda = new Araba();
            mazda.Marka = "Mazda";
            mazda.Model = "CX3";
            mazda.Renk = "Beyaz";
            mazda.Otomatik = false;
            mazda.MaxHiz = 180;

            //opel.Start();
            //opel.Hizlan();
            //opel.Yavasla();
            //opel.Stop();

            opel.Menu();
            //mazda.Menu();
        }
    }
}