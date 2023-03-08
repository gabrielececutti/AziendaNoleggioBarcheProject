using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AziendaNoleggioBarche.Core
{

    public class Barca
    {
        public int CodiceIdentificativo { get; init; }
        public TipoDiBarca TipoDiBarca { get; init; }
        public string Marca { get; init; }
        public double Dimensioni { get; init; }
        public List<string> AltreCaratteristiche { get; init; } // farle lower case
        public bool Occupata { get; init; }

        public ServiziDatabaseBarche ServiziDatabaseBarche { get; init; }

        // per istanziare i servizi del database 
        public Barca(ServiziDatabaseBarche servizioDatabaseBarche)
        {
            ServiziDatabaseBarche = servizioDatabaseBarche;
        }

        public Barca(int codiceIdentificativo, TipoDiBarca tipoDiBarca, string marca, double dimensioni, List<string> altreCaratteristiche, bool occupata)
        {
            CodiceIdentificativo = codiceIdentificativo;
            TipoDiBarca = tipoDiBarca;
            Marca = marca;
            Dimensioni = dimensioni;
            AltreCaratteristiche = altreCaratteristiche;
            Occupata = occupata;
        }

        public void Save()
        {
            ServiziDatabaseBarche.SalvaNelDatabase(this);
        }

        public override string ToString()
        {
            string caratteristiche = "";
            if (AltreCaratteristiche.Any())
            {
                caratteristiche = "nessuna";
            }else
            {
                caratteristiche = String.Join(", ", AltreCaratteristiche.ToArray());
            }
            return  $"Tipo di barca: {TipoDiBarca}, marca: {Marca}, dimensioni: {Dimensioni}m, altre caratteristiche: {caratteristiche}. ";
        }

    }







    
}
