namespace kigyos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int fej_x = 100;
        int fej_y = 100;
        int irany_x = 1;
        int irany_y = 0;
        int lepesszam = 0;
        int hossz = 10;  

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                lepesszam++;


                fej_x += irany_x * KigyoElem.Meret;
                fej_y += irany_y * KigyoElem.Meret;

                

                foreach (KigyoElem item in Controls) 
                {
                    if (item.Top == fej_y && item.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

                KigyoElem ke = new KigyoElem();
                ke.Top = fej_y;
                ke.Left = fej_x;
                Controls.Add(ke);

                if (Controls.Count > hossz)
                {
                    Controls.RemoveAt(0);
                }

                if (lepesszam % 2 == 0) ke.BackColor = Color.Yellow;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) 
            {
                irany_y = -1;
                irany_x = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                irany_y = 1;
                irany_x = 0;
            }
            if (e.KeyCode == Keys.Left)
             {
                irany_y = 0;
                irany_x = -1;
            }
            if (e.KeyCode == Keys.Right)
            {
                irany_y = 0;
                irany_x = 1;
            }
            
        }
    }
}