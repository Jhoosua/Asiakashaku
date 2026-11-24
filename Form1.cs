using System;
using System.Collections.Generic;
using System.Xml;
namespace Asiakashaku
{
    public partial class Form1 : Form
    {
        private XmlNodeList asiakkaat;

        List<Asiakas> asiakkuudet = new List<Asiakas>();
        public Form1()
        {
            InitializeComponent();
            LataaAsiakkaat();
        }
        //Lataa asiakastiedot XML-tiedostosta ja tallentaa ne ohjelman käyttöön
        void LataaAsiakkaat()
        {
            XmlDocument dokumentti = new XmlDocument();
            dokumentti.Load("asiakasrekisteri.xml");

            asiakkaat = dokumentti.SelectNodes("/asiakkaat/asiakas");

            //Käydään XML-tiedoston asiakastietueet yksitellen läpi
            foreach (XmlNode solmu in asiakkaat)
            {
                //Luodaan uusi asiakas-olio jokaiselle XML-tietueelle
                Asiakas asiakas = new Asiakas();

                //Siirretään XML-tiedoston tiedot Asiakas olion ominaisuuksiin
                asiakas.Etunimi = solmu["etunimi"].InnerText;
                asiakas.Sukunimi = solmu["sukunimi"].InnerText;
                asiakas.Puhelinnumero = solmu["puhelinnumero"].InnerText;
                asiakas.Taloyhtio = solmu["taloyhtio"].InnerText;
                asiakas.Rappu = solmu["rappu"].InnerText[0];
                asiakas.Asunnonnro = solmu["asuntonro"].InnerText;
                asiakas.Tyyppi = solmu["tyyppi"].InnerText;
                asiakas.Neliot = double.Parse(solmu["neliot"].InnerText);
                asiakas.Isannoitsija = solmu["isannoitsija"].InnerText;

                asiakkuudet.Add(asiakas);
            }
            //Tyhjennetään pudotusvalikko ennen taloyhtiöiden lisäämistä
            cmbTaloyhtio.Items.Clear();

            //Käydään asiakaslista läpi ja lisätään taloyhtiöt pudotusvalikkoon vain kerran
            foreach (Asiakas asiakas in asiakkuudet)
            {
                if (!cmbTaloyhtio.Items.Contains(asiakas.Taloyhtio))
                {
                    cmbTaloyhtio.Items.Add(asiakas.Taloyhtio);
                }
            }
        }

        private void btnHaeTiedot_Click(object sender, EventArgs e)
        {
            //Haetaan asiakasta etu- ja sukunimen perusteella
            //Tyhjennetään edellisen haun tulokset ja asuntohaun kentät
            txtTulokset.Clear();

            cmbTaloyhtio.SelectedIndex = -1;
            txtboxAsunnonTunnus.Clear();

            //Muuttuja kertoo löytyikö asunnosta asukkaita
            bool loytyikoAsukkaita = false;

            //Luetaan hakuehdot lomakkeen tekstikentistä
            string haettuEtunimi = txtEtunimi.Text;
            string haettuSukunimi = txtSukunimi.Text;

            //Käydään asiakaslista läpi ja etsitään vastaavaa nimeä
            foreach (Asiakas asiakas in asiakkuudet)
            {
                //Tarkistetaan vastaako asiakkaan etu- ja sukunimi hakuehtoja
                if (asiakas.Etunimi == haettuEtunimi && asiakas.Sukunimi == haettuSukunimi)
                {
                    //Näytetään löydetyn asiakkaan tiedot tulosalueella
                    txtTulokset.Text = "Etunimi: " + asiakas.Etunimi
                    + "\r\nSukunimi: " + asiakas.Sukunimi
                    + "\r\nPuhelinnumero: " + asiakas.Puhelinnumero
                    + "\r\nTaloyhtiö: " + asiakas.Taloyhtio
                    + "\r\nRappu: " + asiakas.Rappu
                    + "\r\nAsunnon nro" + asiakas.Asunnonnro
                    + "\r\nAsunnon Tyyppi: " + asiakas.Tyyppi
                    + "\r\nNeliöt: " + asiakas.Neliot
                    + "\r\nIsännöitsijä: " + asiakas.Isannoitsija;

                    loytyikoAsukkaita = true;
                }
            }

            //Ilmoitetaan jos asiakasta ei löytynyt
            if (loytyikoAsukkaita == false)
            {
                txtTulokset.Text = "Annetuilla tiedoilla ei löytynyt hakutuloksia.";
            }
        }

        private void btnHaeAsukkaat_Click(object sender, EventArgs e)
        {
            //Haetaan asunnon asukkaat taloyhtiön ja asuntotunnuksen perusteella
            //Tyhjennetään edellisen haun tuloksen ja henkilökentät
            txtTulokset.Clear();

            txtEtunimi.Clear();
            txtSukunimi.Clear();

            //Muuttuja kertoo, löytyikö asunnosta asukkaita
            bool loytyikoAsukkaita = false;

            //Luetaan valittu taloyhtiö ja asuntotunnus
            string haettuTaloyhtio = cmbTaloyhtio.Text;
            string haettuAsuntotunnus = txtboxAsunnonTunnus.Text;

            //Käydään kaikki asiakkaat läpi
            foreach (Asiakas asiakas in asiakkuudet)
            {
                //Muodostetaan asuntotunnus asunnon rapusta ja asunnon numerosta
                string AsiakkaanAsuntotunnus = asiakas.Rappu + asiakas.Asunnonnro;

                //Tarkistetaan vastaavatko taloyhtiö ja asuntotunnus hakuehtoja
                if (asiakas.Taloyhtio == haettuTaloyhtio && AsiakkaanAsuntotunnus == haettuAsuntotunnus)
                {
                    //Näytetään kyseisen asunnon asukkaiden tiedot tulosalueella
                    txtTulokset.Text += "\r\n\r\nEtunimi: " + asiakas.Etunimi
                    + "\r\nSukunimi: " + asiakas.Sukunimi
                    + "\r\nPuhelinnumero: " + asiakas.Puhelinnumero
                    + "\r\nTaloyhtiö: " + asiakas.Taloyhtio
                    + "\r\nRappu: " + asiakas.Rappu
                    + "\r\nAsunnon nro" + asiakas.Asunnonnro
                    + "\r\nAsunnon Tyyppi: " + asiakas.Tyyppi
                    + "\r\nNeliöt: " + asiakas.Neliot
                    + "\r\nIsännöitsijä: " + asiakas.Isannoitsija;

                    loytyikoAsukkaita = true;
                }
            }

            //Ilmoitetaan jos asunnosta ei löytynyt asukkaita
            if (loytyikoAsukkaita == false)
            {
                txtTulokset.Text = "Annetuilla tiedoilla ei löytynyt hakutuloksia.";
            }
        }
    }
}
