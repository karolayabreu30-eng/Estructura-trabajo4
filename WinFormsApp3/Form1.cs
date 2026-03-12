namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { }
        private void btnEj3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Dictionary<string, int> estudiantes = new Dictionary<string, int>()
            {
                {"Ana",80},
                {"Luis",75},
                {"Pedro",90}
            };

            estudiantes["Luis"] = 95;

            foreach (var e1 in estudiantes)
            {
                listBox1.Items.Add(e1.Key + " - " + e1.Value);
            }
        }

        }
}

