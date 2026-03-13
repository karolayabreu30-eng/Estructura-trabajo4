namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { }
        private void btnEj6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1,"Rojo"},
                {2,"Azul"},
                {3,"Verde"},
                {4,"Amarillo"},
                {5,"Negro"}
            };

            foreach (var valor in dic.Values)
            {
                listBox1.Items.Add(valor);
            }
        }
    }
}