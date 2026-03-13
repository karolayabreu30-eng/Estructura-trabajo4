namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { }
             private void btnEj9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Dictionary<string, int> numeros = new Dictionary<string, int>()
            {
                {"A",5},
                {"B",10},
                {"C",15},
                {"D",20}
            };

            int suma = numeros.Values.Sum();

            listBox1.Items.Add("La suma total es: " + suma);
        }
    }
}
    
