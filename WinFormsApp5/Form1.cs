namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { }
            private void btnEj5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1,"Uno"},
                {2,"Dos"},
                {3,"Tres"},
                {4,"Cuatro"},
                {5,"Cinco"}
            };

            foreach (var clave in dic.Keys)
            {
                listBox1.Items.Add(clave);
            }
        }
    }
    }

