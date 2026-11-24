using System;
using System.Collections.Generic;
using System.Text;

namespace Asiakashaku
{
    //Määritellään asiakasluokka ja sen sisältämät tiedot
    internal class Asiakas
    {
       //asiakkaan henkilö- ja asuntotiedot
        public string Etunimi {  get; set; }
        public string Sukunimi { get; set; } 
        public string Puhelinnumero { get; set; }
        public string Taloyhtio { get; set; }
        public char Rappu {  get; set; }
        public string Asunnonnro {  get; set; }
        public string Tyyppi {  get; set; }
        public double Neliot {  get; set; }
        public string Isannoitsija { get; set; }
    }
}
