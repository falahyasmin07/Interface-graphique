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
      // Température
      cmbFromTemp.Items.AddRange(new string[] { "Celsius (°C)", "Fahrenheit (°F)", "Kelvin (K)" });
      cmbToTemp.Items.AddRange(new string[] { "Celsius (°C)", "Fahrenheit (°F)", "Kelvin (K)" });
      cmbFromTemp.SelectedIndex = 0;
      cmbToTemp.SelectedIndex = 1;

      // Masse
      cmbFromMasse.Items.AddRange(new string[] { "Kilogramme (kg)", "Gramme (g)", "Milligramme (mg)", "Livre (lb)", "Once (oz)", "Tonne (t)" });
      cmbToMasse.Items.AddRange(new string[] { "Kilogramme (kg)", "Gramme (g)", "Milligramme (mg)", "Livre (lb)", "Once (oz)", "Tonne (t)" });
      cmbFromMasse.SelectedIndex = 0;
      cmbToMasse.SelectedIndex = 3;

      // Distance
      cmbFromDistance.Items.AddRange(new string[] { "Mètre (m)", "Kilomètre (km)", "Centimètre (cm)", "Millimètre (mm)", "Mile (mi)", "Pied (ft)", "Pouce (in)" });
      cmbToDistance.Items.AddRange(new string[] { "Mètre (m)", "Kilomètre (km)", "Centimètre (cm)", "Millimètre (mm)", "Mile (mi)", "Pied (ft)", "Pouce (in)" });
      cmbFromDistance.SelectedIndex = 1;
      cmbToDistance.SelectedIndex = 4;

      // Devise
      cmbFromDevise.Items.AddRange(new string[] { "Euro (EUR €)", "Dollar US (USD $)", "Livre sterling (GBP £)", "Yen japonais (JPY ¥)", "Franc suisse (CHF)", "Dollar canadien (CAD $)", "Dollar australien (AUD $)" });
      cmbToDevise.Items.AddRange(new string[] { "Euro (EUR €)", "Dollar US (USD $)", "Livre sterling (GBP £)", "Yen japonais (JPY ¥)", "Franc suisse (CHF)", "Dollar canadien (CAD $)", "Dollar australien (AUD $)" });
      cmbFromDevise.SelectedIndex = 0;
      cmbToDevise.SelectedIndex = 1;
    }

    // ── Température
    private void btnConvertirTemp_Click(object sender, EventArgs e)
    {
      if (!decimal.TryParse(txtTemp.Text, out decimal v))
      {
        MessageBox.Show("Veuillez entrer une valeur valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // Convertir vers Celsius
      decimal enCelsius = cmbFromTemp.SelectedIndex switch
      {
        0 => v,
        1 => (v - 32) * 5 / 9,
        2 => v - 273.15m,
        _ => v
      };

      decimal resultat = cmbToTemp.SelectedIndex switch
      {
        0 => enCelsius,
        1 => enCelsius * 9 / 5 + 32,
        2 => enCelsius + 273.15m,
        _ => enCelsius
      };

      string[] unites = { "°C", "°F", "K" };
      lblResultatTemp.Text = resultat.ToString("F2") + " " + unites[cmbToTemp.SelectedIndex];
    }

    // ── Masse
    private void btnConvertirMasse_Click(object sender, EventArgs e)
    {
      if (!decimal.TryParse(txtMasse.Text, out decimal v))
      {
        MessageBox.Show("Veuillez entrer une valeur valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      decimal[] versKg = { 1m, 0.001m, 0.000001m, 0.453592m, 0.0283495m, 1000m };
      decimal[] depuisKg = { 1m, 1000m, 1000000m, 1 / 0.453592m, 1 / 0.0283495m, 0.001m };
      string[] unites = { "kg", "g", "mg", "lb", "oz", "t" };

      decimal res = v * versKg[cmbFromMasse.SelectedIndex] * depuisKg[cmbToMasse.SelectedIndex];
      lblResultatMasse.Text = res.ToString("F4") + " " + unites[cmbToMasse.SelectedIndex];
    }

    // ── Distance 
    private void btnConvertirDistance_Click(object sender, EventArgs e)
    {
      if (!decimal.TryParse(txtDistance.Text, out decimal v))
      {
        MessageBox.Show("Veuillez entrer une valeur valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      decimal[] versM = { 1m, 1000m, 0.01m, 0.001m, 1609.344m, 0.3048m, 0.0254m };
      decimal[] depuisM = { 1m, 0.001m, 100m, 1000m, 1 / 1609.344m, 1 / 0.3048m, 1 / 0.0254m };
      string[] unites = { "m", "km", "cm", "mm", "mi", "ft", "in" };

      decimal res = v * versM[cmbFromDistance.SelectedIndex] * depuisM[cmbToDistance.SelectedIndex];
      lblResultatDistance.Text = res.ToString("F4") + " " + unites[cmbToDistance.SelectedIndex];
    }

    // ── Devise
    private readonly decimal[] tauxEur = { 1m, 0.92m, 1.17m, 0.0062m, 1.04m, 0.68m, 0.60m };

    private void btnConvertirDevise_Click(object sender, EventArgs e)
    {
      if (!decimal.TryParse(txtDevise.Text, out decimal v))
      {
        MessageBox.Show("Veuillez entrer un montant valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      string[] symboles = { "€", "$", "£", "¥", "CHF", "CA$", "AU$" };
      decimal res = v * tauxEur[cmbFromDevise.SelectedIndex] / tauxEur[cmbToDevise.SelectedIndex];
      lblResultatDevise.Text = res.ToString("F2") + " " + symboles[cmbToDevise.SelectedIndex];
      lblNoteDevise.Text = "* Taux indicatifs, non mis à jour en temps réel";
    }
  }
}
