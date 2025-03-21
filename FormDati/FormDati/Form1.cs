using static System.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace FormDati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdoMaschio.Checked = true;
            rdoCalcolo.Checked = true;
            VisualizzaDati();
        }

        string path = "../../../files/Lista.txt";
        Persona[] listaPersone = new Persona[20];
        int index = 0;

        public struct Persona
        {
            public int peso;
            public int altezza;
            public string nome;
            public string sesso;

            public Persona(int Peso, int Altezza, string Nome, string Sesso)
            {
                peso = Peso;
                altezza = Altezza;
                nome = Nome;
                sesso = Sesso;
            }
        }

        public void Aggiungi(Persona persona)
        {
            string stringa = persona.nome +", "+ persona.altezza.ToString() + ", " + persona.peso.ToString() + ", "+ persona.sesso;

            lst_main.Items.Add(stringa);
            using (StreamWriter sr = File.AppendText(path)) 
            {
                sr.WriteLine(stringa);
            }
            Pulisci();
        }

        public void Pulisci()
        {
            txtAltezza.Clear();
            txtNome.Clear();
            txtPeso.Clear();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            bool tempAltezza = int.TryParse(txtAltezza.Text, out int altezza);
            bool tempPeso = int.TryParse(txtPeso.Text, out int peso);

            string nome = txtNome.Text;
            if (tempAltezza && tempPeso && altezza > 0 && peso > 0 && altezza < 250 && peso < 220 && nome != null)
            {
                altezza = int.Parse(txtAltezza.Text);
                peso = int.Parse(txtPeso.Text);
                string sesso = rdoFemmina.Checked ? "F" : "M";
                listaPersone[index] = new Persona(peso, altezza, nome, sesso);

                Aggiungi(listaPersone[index]);

                index++;
            } 
            
            else 
            
            {

                MessageBox.Show("input errati!");
                Pulisci();
            }

            
        }


        public void VisualizzaDati()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string riga = sr.ReadLine();
                    if ( !string.IsNullOrEmpty(riga))
                    {
                        string[] dati = riga.Split(',');
                        listaPersone[index] = new Persona(int.Parse(dati[2]), int.Parse(dati[1]), dati[0].Trim(), dati[3].Trim());
                        lst_main.Items.Add(riga);
                    }
                    index++;

                }
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lst_main.Items.Clear();

            VisualizzaDati();
        }
        private void btnEsegui_Click(object sender, EventArgs e)
        {
            if (rdoCalcolo.Checked)
            {
                int i = lst_main.SelectedIndex;
                if (i >= 0)
                {
                    float peso = listaPersone[i].peso;
                    float altezza = listaPersone[i].altezza;
                    altezza = altezza / 100;
                    float IMC = peso / (altezza * altezza);
                    MessageBox.Show($" L'IMC di {listaPersone[i].nome} è {Math.Round(IMC, 2)}");
                } else
                {
                    MessageBox.Show($"Selezionare un elemento");
                }


            } else if (rdoMedia.Checked)
            {
                float media = 0; 
                for (int i = 0; i < listaPersone.Length && listaPersone[i].nome != null; i++)
                {
                        float peso = listaPersone[i].peso;
                        float altezza = listaPersone[i].altezza;
                        altezza /= 100;
                        float IMC = peso / (altezza * altezza);
                        media += IMC;
                }
                media /= index;
                MessageBox.Show($" La media dell' IMC è {Math.Round(media,2)}");

            } else if (rdoMediana.Checked)
            {
                MessageBox.Show("mediana");

            } else if ( rdoModa.Checked )
            {
                MessageBox.Show("moda");
            } else
            {
                MessageBox.Show("variante");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lst_main_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoMaschio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoFemmina_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rdoCalcolo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoMedia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoMediana_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoModa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoVarianza_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
