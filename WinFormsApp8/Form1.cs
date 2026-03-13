namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { }
private void btnEj8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Dictionary<string, int> dic = new Dictionary<string, int>()
            {
                {"Juan",10},
                {"Maria",20},
                {"Carlos",30}
            };

            foreach (var d in dic)
            {
                listBox1.Items.Add(d.Key + " -> " + d.Value);
            }
        }

    }
}

