namespace Interface_graphique
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnConvertir_Click(object sender, EventArgs e)
    {
      if (decimal.TryParse(txtTemperature.Text, out decimal tc))
      {
        decimal tf = tc * 9 / 5 + 32;
        lblF.Text = tf.ToString("F2") + " °F";
      }
      else
      {
        MessageBox.Show("Veuillez entrer une température valide.", "Erreur",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }
}
