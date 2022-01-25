using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijaList
{
    class Ucenik
    {
        string ime;
        string prezime;
        string razred;
        int godRod;

        public Ucenik(string ime, string prezime, string razred, int godRod)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.razred = razred;
            this.godRod = godRod;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Razred { get => razred; set => razred = value; }
        public int GodRod { get => godRod; set => godRod = value; }

        public override string ToString()
        {
            string ispis = "Ime: " + this.ime + " Prezime: " + this.prezime + " Razred: " + this.razred + " Godina rođenja: " + this.godRod;
            return ispis;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime;
            string prezime;
            string razred;
            int godRod;
            int kontrola;

            List<Ucenik> listaUcenika = new List<Ucenik>();

            do
            {
                Console.WriteLine("Unesi ime: ");
                ime = Console.ReadLine();
                Console.WriteLine("Unesi prezime ");
                prezime = Console.ReadLine();
                Console.WriteLine("Unesi razred: ");
                razred = Console.ReadLine();
                Console.WriteLine("Unesi godinu rođenja: ");
                godRod = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Unesi '0' za kraj, ili '1' za nastavak: ");
                kontrola = Convert.ToInt32(Console.ReadLine());

                Ucenik ucenik = new Ucenik(ime, prezime, razred, godRod);

                listaUcenika.Add(ucenik);
            }
            while (kontrola != 0);

            foreach (Ucenik ucenik in listaUcenika)
            {
                if (ucenik.Ime == "David")
                {
                    Console.WriteLine(ucenik.ToString());
                    ucenik.Ime = "Dinko";
                    Console.WriteLine(ucenik.ToString());
                }
              

            }

            Console.ReadKey();
        }
    }
}
