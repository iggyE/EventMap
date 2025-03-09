using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Media;

namespace EventMap.Back
{

    // Definicija klase Lokacija
    public class Lokacija
    {
        [Key]
        public int Id { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }

        public Lokacija() { }
        public Lokacija(int id,string drzava, string grad)
        {
            Id = id;
            Drzava = drzava;
            Grad = grad;
        }
    }

    public class TipDogadjaja
    {

        public string TipOznaka { get; set; }
        public string TipNaziv { get; set; }
        public string TipIkona { get; set; }
        public string TipOpis { get; set; }


        public TipDogadjaja()
        {

        }

        public TipDogadjaja(string oznaka, string naziv, string ikona, string opis)
        {
            TipOznaka = oznaka;
            TipNaziv = naziv;
            TipIkona = ikona;
            TipOpis = opis;
        }
    }

    public enum Posecenost
    {
        less1000,
        over1000to5000,
        over5000to10000,
        over10000
    }

    // Definicija klase Dogadjaj
    public class Dogadjaj
    {
        public string Oznaka { get; set; }
       // public string Ikona { get; set; }
        public string Naziv { get; set; }
        public string Ikona { get; set; }
        public string Opis { get; set; }
        public TipDogadjaja TipDogadjaja { get; set; }
        public string TipOznaka { get; set; }
        public Posecenost Posecenost { get; set; }
        public string Grad { get; set; }
        public string Drzava { get; set; }
        public bool Humanitarni { get; set; }
        public decimal ProsecanTrosak { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public Lokacija Lokacija { get; set; }
        public List<DateTime> IstorijaDatuma { get; set; }
        public DateTime DatumOdrzavanja { get; set; }

        public Dogadjaj() { 
            IstorijaDatuma = new List<DateTime>();
        }
        public Dogadjaj(string oznaka, string ikona ,string naziv, string opis, TipDogadjaja tip, string tipOznaka, Posecenost posecenost,string grad,string drzava, bool humanitarni, decimal prosecanTrosak, double x,double y, Lokacija lokacija, List<DateTime> istorijaDatuma, DateTime datumOdrzavanja)
        {
            Oznaka = oznaka;
            Ikona = ikona;
            Naziv = naziv;
            Opis = opis;
            TipDogadjaja = tip;
            TipOznaka = tipOznaka;
            Posecenost = posecenost;
            Grad = grad;
            Drzava = drzava;
            Humanitarni = humanitarni;
            ProsecanTrosak = prosecanTrosak;
            X = x;
            Y = y;
            Lokacija = lokacija;
            IstorijaDatuma = istorijaDatuma;
            DatumOdrzavanja = datumOdrzavanja;
        }
    }


    public class Etiketa
    {
        public string Oznaka { get; set; }
        public string Boja { get; set; }
        public string Opis { get; set; }

        public Etiketa() { }

        public Etiketa(string oznakaEtikete, string boja, string opis)
        {
            Oznaka = oznakaEtikete;
            Boja = boja;
            Opis = opis;
        }
    }
}
