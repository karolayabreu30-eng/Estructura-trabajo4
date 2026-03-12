namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Dictionary<string, string> paises = new Dictionary<string, string>()
            {
                {"Republica Dominicana","Santo Domingo"},
                {"Mexico","Ciudad de Mexico"},
                {"España","Madrid"}
            };

            foreach (var p in paises)
            {
                listBox1.Items.Add(p.Key + " - " + p.Value);
            }
        }
    }
}


