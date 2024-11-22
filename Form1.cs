namespace SumadedosNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            TxtN1.Text = "";
            TxtN2.Text = "";
            TxtNr.Text = "";

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double N1, N2, R;
            N1 = double.Parse(TxtN1.Text);
            N2 = double.Parse(TxtN2.Text);
            R = N1 + N2;
            TxtNr.Text = R.ToString();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
