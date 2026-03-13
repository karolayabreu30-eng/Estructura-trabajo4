namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { }
            private void btnEj7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Dictionary<string, int> dic = new Dictionary<string, int>()
            {
                {"A",1},
                {"B",2},
                {"C",3}
            };

            if (dic.ContainsKey("B"))
                listBox1.Items.Add("La clave B existe");
            else
                listBox1.Items.Add("No existe");
        }

    }
}

