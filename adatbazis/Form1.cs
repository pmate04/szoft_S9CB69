namespace adatbazis
{
    public partial class Form1 : Form
    {
        Models.StudentContext studentContext = new Models.StudentContext();
        public Form1()
        {
            InitializeComponent();
            studentBindingSource.DataSource = studentContext.Students.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.InnerException.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var er = from x in studentContext.Students
                     where x.Name.StartsWith(textBox3.Text)
                     select x;
            studentBindingSource.DataSource = er.ToList();
        }
    }
}