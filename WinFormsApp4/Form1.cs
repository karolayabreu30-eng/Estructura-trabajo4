namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { }
        private void btnEj4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Dictionary<string, int> datos = new Dictionary<string, int>()
            {
                {"A",10},
                {"B",20},
                {"C",30}
            };

            datos.Remove("B");

            foreach (var d in datos)
            {
                listBox1.Items.Add(d.Key + " - " + d.Value);
            }
        }
    }
}