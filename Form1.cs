using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Premeny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool nacitane = false;
        public bool ukladanie = false;
        public int typ = 0;
        public string[][] jednotkymeno = new string[12][];
        public double[][] jednotkyrad = new double[12][];
        public string history = "";
        public string file;

        public void getdata()
        {
            nacitane = false;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                    System.IO.StreamReader sr = new
                       System.IO.StreamReader(openFileDialog1.FileName);
                try
                {
                    string[] data = new string[2];
                    int datatypes = -1;
                    List<string> zoznam = new List<string>();

                    while (!sr.EndOfStream)
                    {

                        string riadok = sr.ReadLine();
                        Console.WriteLine(riadok);
                        if (riadok.StartsWith("Velicina"))
                        {
                            if (datatypes == -1)
                            {
                                datatypes++;
                                continue;
                            }
                            jednotkymeno[datatypes] = new string[zoznam.Count];
                            jednotkyrad[datatypes] = new double[zoznam.Count];
                            for (int j = 0; j < zoznam.Count(); j++)
                            {
                                data = zoznam[j].Split('=');
                                jednotkymeno[datatypes][j] = data[0];
                                jednotkyrad[datatypes][j] = Convert.ToDouble(data[1]);
                            }
                            datatypes++;
                            zoznam.Clear();
                        }
                        else
                            zoznam.Add(riadok);

                    }

                    jednotkymeno[datatypes] = new string[zoznam.Count];
                    jednotkyrad[datatypes] = new double[zoznam.Count];
                    for (int j = 0; j < zoznam.Count(); j++)
                    {
                        data = zoznam[j].Split('=');
                        jednotkymeno[datatypes][j] = data[0];
                        jednotkyrad[datatypes][j] = Convert.ToDouble(data[1]);
                    }
                    sr.Dispose();
                    nacitane = true;
                }
                catch { MessageBox.Show("Problem so suborom", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                finally { sr.Dispose(); }
                
                

            }
        }

        public void jednotky(int druh)
        {
            if (!nacitane)
            {
                DialogResult nacitat = MessageBox.Show("Nie je načítaný súbor s konverziamy. Chcete ho načítať?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (nacitat.Equals(DialogResult.OK))
                {
                    getdata();
                }
                else
                {
                    return;
                }
            }
            if (!nacitane)
                return;
            typ = druh;
            vstuph.Clear();
            vystuph.Clear();
            vstupj.Items.Clear();
            vystupj.Items.Clear();
            for (int i = 0; i < jednotkymeno[druh].Length; i++)
                {
                    vstupj.Items.Add(jednotkymeno[typ][i]);
                    vystupj.Items.Add(jednotkymeno[typ][i]);
                }
            vstupj.Text = jednotkymeno[typ][0];
            vystupj.Text = jednotkymeno[typ][0];

        }

        private void konverzia()
        {
            double vstuprad=0;
            double vystuprad=0;
            double vstuphodnota=0;
            double vystuphodnota=0;
            if (vstuph.Text.Equals(""))
                return;

                try
            {
                vstuphodnota = Convert.ToDouble(vstuph.Text);
                for (int i = 0; i < jednotkymeno[typ].Length; i++)
                {
                    if (jednotkymeno[typ][i] == vstupj.Text)
                        vstuprad = jednotkyrad[typ][i];
                    if (jednotkymeno[typ][i] == vystupj.Text)
                        vystuprad = jednotkyrad[typ][i];
                }
                vystuphodnota = (vstuphodnota * vstuprad) / vystuprad;
                vystuph.Text = Convert.ToString(vystuphodnota);
                if (autosave.Checked)
                    ulozenie();
                
            }
            catch(Exception)
            {
                MessageBox.Show("Nesprávny vstup", "Problem");

            }

        }
        public void ulozenie()
        {
            if ((!ukladanie) && (saveFileDialog1.ShowDialog() == DialogResult.OK))
            {
                file = saveFileDialog1.FileName;
                ukladanie = true;
                System.IO.StreamWriter write = File.CreateText(file);
                write.WriteLine(vstuph.Text + vstupj.Text + " = " + vystuph.Text + vystupj.Text + "\n");
                write.Dispose();
            }
            try
            {
                System.IO.StreamWriter write = File.AppendText(file);
                write.WriteLine(vstuph.Text + vstupj.Text + " = " + vystuph.Text + vystupj.Text + "\n");
                write.Dispose();
            }
            catch
            {
                MessageBox.Show("Nespravne zvolený výstupný súbor", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ukladanie = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();

        }

        private void vstrupj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void input_Paint(object sender, PaintEventArgs e)
        {

        }

        private void konverzia(object sender, EventArgs e)
        {
            konverzia();
        }

        private void dlzka_CheckedChanged(object sender, EventArgs e)
        {
            if (dlzka.Checked)
                jednotky(0);
        }

        private void hmotnost_CheckedChanged(object sender, EventArgs e)
        {
            if (hmotnost.Checked)
                jednotky(1);
        }

        private void cas_CheckedChanged(object sender, EventArgs e)
        {
            if (cas.Checked)
                jednotky(2);
        }

        private void obsah_CheckedChanged(object sender, EventArgs e)
        {
            if (obsah.Checked)
                jednotky(3);
        }

        private void hustota_CheckedChanged(object sender, EventArgs e)
        {
            if (hustota.Checked)
                jednotky(4);
        }

        private void rychlost_CheckedChanged(object sender, EventArgs e)
        {
            if (rychlost.Checked)
                jednotky(5);
        }

        private void objem_CheckedChanged(object sender, EventArgs e)
        {
            if (objem.Checked)
                jednotky(6);
        }

        private void sila_CheckedChanged(object sender, EventArgs e)
        {
            if (sila.Checked)
                jednotky(7);

        }

        private void vykon_CheckedChanged(object sender, EventArgs e)
        {
            if (vykon.Checked)
                jednotky(8);
        }

        private void uhol_CheckedChanged(object sender, EventArgs e)
        {
            if (uhol.Checked)
                jednotky(9);
        }

        private void informacia_CheckedChanged(object sender, EventArgs e)
        {
            if (informacia.Checked)
                jednotky(10);
        }

        private void praca_CheckedChanged(object sender, EventArgs e)
        {
            if (praca.Checked)
                jednotky(11);
        }

        private void save_Click(object sender, EventArgs e)
        {
            ulozenie();
          
        }
    }
}
