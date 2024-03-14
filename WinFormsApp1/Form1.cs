using HajosTeszt;
using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Kerdes> OsszesKerdes;
        List<Kerdes> AktualisKerdesek;
        int MegjelenitettKerdesSzama = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OsszesKerdes = KerdesekBetoltese();
            AktualisKerdesek = new List<Kerdes>();

            for (int i = 0; i < 7; i++)
            {
                AktualisKerdesek.Add(OsszesKerdes[0]);
                OsszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisKerdesek;
            KerdesMegjelenites(AktualisKerdesek[MegjelenitettKerdesSzama]);
        }

        List<Kerdes> KerdesekBetoltese()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {

                string sor = sr.ReadLine() ?? "n/a";
                string[] tomb = sor.Split("\t");

                if (tomb.Length != 7) continue;

                Kerdes k = new Kerdes();
                k.KerdesSzoveg = tomb[1].ToUpper().Trim('"');
                k.Valasz1 = tomb[2].Trim('"');
                k.Valasz2 = tomb[3].Trim('"');
                k.Valasz3 = tomb[4].Trim('"');
                k.URL = tomb[5];

                int x = 0;
                int.TryParse(tomb[6], out x);

                k.HelyesValasz = x;

                kerdesek.Add(k);

            }

            sr.Close();
            return kerdesek;
        }

        void KerdesMegjelenites(Kerdes kerdes)
        {
            label1.Text = kerdes.KerdesSzoveg;
            textBox1.Text = kerdes.Valasz1;
            textBox2.Text = kerdes.Valasz2;
            textBox3.Text = kerdes.Valasz3;

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;

            if (string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kerdes.URL);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MegjelenitettKerdesSzama++;
            if (MegjelenitettKerdesSzama == AktualisKerdesek.Count) MegjelenitettKerdesSzama = 0;

            KerdesMegjelenites(AktualisKerdesek[MegjelenitettKerdesSzama]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Salmon;
            Szinezes();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Salmon;
            Szinezes();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Salmon;
            Szinezes();
        }
        void Szinezes()
        {
            int helyesValasz = AktualisKerdesek[MegjelenitettKerdesSzama].HelyesValasz;
            if (helyesValasz == 1) textBox1.BackColor = Color.LightGreen;
            if (helyesValasz == 2) textBox2.BackColor = Color.LightGreen;
            if (helyesValasz == 3) textBox3.BackColor = Color.LightGreen;

        }
    }
}