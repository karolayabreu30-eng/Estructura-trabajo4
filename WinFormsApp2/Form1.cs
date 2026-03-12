namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
       
           private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            Dictionary<string, double> productos = new Dictionary<string, double>();

            productos.Add("Laptop", 500);
            productos.Add("Mouse", 20);
            productos.Add("Teclado", 30);

            lstResultados.Items.Add("Precio del Mouse: " + productos["Mouse"]);
        }
    }
    }
