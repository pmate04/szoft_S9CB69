namespace csillagterkep
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Yellow);
            Brush brush = new SolidBrush(Color.WhiteSmoke);

            //g.FillEllipse(brush, 0, 0, 100, 100);

            Models.HajosContext hajosContext = new Models.HajosContext();
            var stars = (from s in hajosContext.StarData select new { s.Hip, s.X, s.Y, s.Magnitude }).ToList();

            double nagyitas = Math.Min(ClientRectangle.Height, ClientRectangle.Width) / 2;
            int ox = ClientRectangle.Width / 2, oy = ClientRectangle.Height / 2;

            g.Clear(Color.DarkBlue);

            foreach (var s in stars)
            {
                if (Math.Sqrt(Math.Pow(s.X, 2) + Math.Pow(s.Y, 2)) > 1) continue;
                if (s.Magnitude > 6) continue;

                double size = 20 * Math.Pow(10, s.Magnitude / -2.5);
                if (size < 1) size = 1;

                double x = s.X * nagyitas + ox;
                double y = s.Y * nagyitas + oy;

                g.FillEllipse(brush, (float)(x - size / 2), (float)(y - size / 2), (float)size, (float)size);
            }

            var lines = hajosContext.ConstellationLines.ToList();

            foreach (var l in lines)
            {

                var s1 = (from x in stars where x.Hip == l.Star1 select x).FirstOrDefault();
                var s2 = (from x in stars where x.Hip == l.Star2 select x).FirstOrDefault();

                if (s1 == null || s2 == null) continue;

                double x1 = s1.X * nagyitas + ox;
                double y1 = s1.Y * nagyitas + oy;
                double x2 = s2.X * nagyitas + ox;
                double y2 = s2.Y *  nagyitas + oy;

                g.DrawLine(pen,(float)x1,(float)y1, (float)x2, (float)y2);
            }
        }
    }
}