namespace Interface_graphique
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
        components.Dispose();
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
      tabControl = new TabControl();
      tabTemp = new TabPage();
      tabMasse = new TabPage();
      tabDistance = new TabPage();
      tabDevise = new TabPage();

      // ── Température ──
      lblFromTemp = new Label();
      txtTemp = new TextBox();
      cmbFromTemp = new ComboBox();
      lblToTemp = new Label();
      cmbToTemp = new ComboBox();
      btnConvertirTemp = new Button();
      lblResultatTemp = new Label();

      // ── Masse ──
      lblFromMasse = new Label();
      txtMasse = new TextBox();
      cmbFromMasse = new ComboBox();
      lblToMasse = new Label();
      cmbToMasse = new ComboBox();
      btnConvertirMasse = new Button();
      lblResultatMasse = new Label();

      // ── Distance ──
      lblFromDistance = new Label();
      txtDistance = new TextBox();
      cmbFromDistance = new ComboBox();
      lblToDistance = new Label();
      cmbToDistance = new ComboBox();
      btnConvertirDistance = new Button();
      lblResultatDistance = new Label();

      // ── Devise ──
      lblFromDevise = new Label();
      txtDevise = new TextBox();
      cmbFromDevise = new ComboBox();
      lblToDevise = new Label();
      cmbToDevise = new ComboBox();
      btnConvertirDevise = new Button();
      lblResultatDevise = new Label();
      lblNoteDevise = new Label();

      SuspendLayout();

      // TabControl principal

      tabControl.Location = new Point(10, 10);
      tabControl.Size = new Size(760, 180);
      tabControl.Font = new Font("Segoe UI", 10F);
      tabControl.Controls.Add(tabTemp);
      tabControl.Controls.Add(tabMasse);
      tabControl.Controls.Add(tabDistance);
      tabControl.Controls.Add(tabDevise);

      // Onglet Température

      tabTemp.Text = "🌡  Température";
      tabTemp.Padding = new Padding(10);

      lblFromTemp.Text = "Valeur à convertir :";
      lblFromTemp.Location = new Point(20, 25);
      lblFromTemp.AutoSize = true;

      txtTemp.Location = new Point(20, 52);
      txtTemp.Size = new Size(130, 31);
      txtTemp.Text = "23";
      txtTemp.Font = new Font("Segoe UI", 11F);

      cmbFromTemp.Location = new Point(165, 52);
      cmbFromTemp.Size = new Size(190, 31);
      cmbFromTemp.DropDownStyle = ComboBoxStyle.DropDownList;

      lblToTemp.Text = "Convertir en :";
      lblToTemp.Location = new Point(375, 25);
      lblToTemp.AutoSize = true;

      cmbToTemp.Location = new Point(375, 52);
      cmbToTemp.Size = new Size(190, 31);
      cmbToTemp.DropDownStyle = ComboBoxStyle.DropDownList;

      btnConvertirTemp.Location = new Point(580, 50);
      btnConvertirTemp.Size = new Size(120, 34);
      btnConvertirTemp.Text = "Convertir";
      btnConvertirTemp.UseVisualStyleBackColor = true;
      btnConvertirTemp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      btnConvertirTemp.Click += btnConvertirTemp_Click;

      lblResultatTemp.Text = "—";
      lblResultatTemp.Location = new Point(20, 105);
      lblResultatTemp.AutoSize = true;
      lblResultatTemp.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
      lblResultatTemp.ForeColor = Color.FromArgb(0, 102, 204);

      tabTemp.Controls.AddRange(new Control[] { lblFromTemp, txtTemp, cmbFromTemp, lblToTemp, cmbToTemp, btnConvertirTemp, lblResultatTemp });

      // Onglet Masse

      tabMasse.Text = "⚖  Masse";
      tabMasse.Padding = new Padding(10);

      lblFromMasse.Text = "Valeur à convertir :";
      lblFromMasse.Location = new Point(20, 25);
      lblFromMasse.AutoSize = true;

      txtMasse.Location = new Point(20, 52);
      txtMasse.Size = new Size(130, 31);
      txtMasse.Text = "1";
      txtMasse.Font = new Font("Segoe UI", 11F);

      cmbFromMasse.Location = new Point(165, 52);
      cmbFromMasse.Size = new Size(190, 31);
      cmbFromMasse.DropDownStyle = ComboBoxStyle.DropDownList;

      lblToMasse.Text = "Convertir en :";
      lblToMasse.Location = new Point(375, 25);
      lblToMasse.AutoSize = true;

      cmbToMasse.Location = new Point(375, 52);
      cmbToMasse.Size = new Size(190, 31);
      cmbToMasse.DropDownStyle = ComboBoxStyle.DropDownList;

      btnConvertirMasse.Location = new Point(580, 50);
      btnConvertirMasse.Size = new Size(120, 34);
      btnConvertirMasse.Text = "Convertir";
      btnConvertirMasse.UseVisualStyleBackColor = true;
      btnConvertirMasse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      btnConvertirMasse.Click += btnConvertirMasse_Click;

      lblResultatMasse.Text = "—";
      lblResultatMasse.Location = new Point(20, 105);
      lblResultatMasse.AutoSize = true;
      lblResultatMasse.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
      lblResultatMasse.ForeColor = Color.FromArgb(0, 102, 204);

      tabMasse.Controls.AddRange(new Control[] { lblFromMasse, txtMasse, cmbFromMasse, lblToMasse, cmbToMasse, btnConvertirMasse, lblResultatMasse });

      // Onglet Distance

      tabDistance.Text = "📏  Distance";
      tabDistance.Padding = new Padding(10);

      lblFromDistance.Text = "Valeur à convertir :";
      lblFromDistance.Location = new Point(20, 25);
      lblFromDistance.AutoSize = true;

      txtDistance.Location = new Point(20, 52);
      txtDistance.Size = new Size(130, 31);
      txtDistance.Text = "1";
      txtDistance.Font = new Font("Segoe UI", 11F);

      cmbFromDistance.Location = new Point(165, 52);
      cmbFromDistance.Size = new Size(190, 31);
      cmbFromDistance.DropDownStyle = ComboBoxStyle.DropDownList;

      lblToDistance.Text = "Convertir en :";
      lblToDistance.Location = new Point(375, 25);
      lblToDistance.AutoSize = true;

      cmbToDistance.Location = new Point(375, 52);
      cmbToDistance.Size = new Size(190, 31);
      cmbToDistance.DropDownStyle = ComboBoxStyle.DropDownList;

      btnConvertirDistance.Location = new Point(580, 50);
      btnConvertirDistance.Size = new Size(120, 34);
      btnConvertirDistance.Text = "Convertir";
      btnConvertirDistance.UseVisualStyleBackColor = true;
      btnConvertirDistance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      btnConvertirDistance.Click += btnConvertirDistance_Click;

      lblResultatDistance.Text = "—";
      lblResultatDistance.Location = new Point(20, 105);
      lblResultatDistance.AutoSize = true;
      lblResultatDistance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
      lblResultatDistance.ForeColor = Color.FromArgb(0, 102, 204);

      tabDistance.Controls.AddRange(new Control[] { lblFromDistance, txtDistance, cmbFromDistance, lblToDistance, cmbToDistance, btnConvertirDistance, lblResultatDistance });

      // Onglet Devise

      tabDevise.Text = "💶  Devise";
      tabDevise.Padding = new Padding(10);

      lblFromDevise.Text = "Montant à convertir :";
      lblFromDevise.Location = new Point(20, 25);
      lblFromDevise.AutoSize = true;

      txtDevise.Location = new Point(20, 52);
      txtDevise.Size = new Size(130, 31);
      txtDevise.Text = "100";
      txtDevise.Font = new Font("Segoe UI", 11F);

      cmbFromDevise.Location = new Point(165, 52);
      cmbFromDevise.Size = new Size(190, 31);
      cmbFromDevise.DropDownStyle = ComboBoxStyle.DropDownList;

      lblToDevise.Text = "Convertir en :";
      lblToDevise.Location = new Point(375, 25);
      lblToDevise.AutoSize = true;

      cmbToDevise.Location = new Point(375, 52);
      cmbToDevise.Size = new Size(190, 31);
      cmbToDevise.DropDownStyle = ComboBoxStyle.DropDownList;

      btnConvertirDevise.Location = new Point(580, 50);
      btnConvertirDevise.Size = new Size(120, 34);
      btnConvertirDevise.Text = "Convertir";
      btnConvertirDevise.UseVisualStyleBackColor = true;
      btnConvertirDevise.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      btnConvertirDevise.Click += btnConvertirDevise_Click;

      lblResultatDevise.Text = "—";
      lblResultatDevise.Location = new Point(20, 100);
      lblResultatDevise.AutoSize = true;
      lblResultatDevise.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
      lblResultatDevise.ForeColor = Color.FromArgb(0, 102, 204);

      lblNoteDevise.Text = "";
      lblNoteDevise.Location = new Point(20, 128);
      lblNoteDevise.AutoSize = true;
      lblNoteDevise.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
      lblNoteDevise.ForeColor = Color.Gray;

      tabDevise.Controls.AddRange(new Control[] { lblFromDevise, txtDevise, cmbFromDevise, lblToDevise, cmbToDevise, btnConvertirDevise, lblResultatDevise, lblNoteDevise });

      // Form

      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(784, 210);
      Controls.Add(tabControl);
      Name = "Form1";
      Text = "Convertisseur";
      Load += Form1_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TabControl tabControl;
    private TabPage tabTemp, tabMasse, tabDistance, tabDevise;

    // Température
    private Label lblFromTemp, lblToTemp, lblResultatTemp;
    private TextBox txtTemp;
    private ComboBox cmbFromTemp, cmbToTemp;
    private Button btnConvertirTemp;

    // Masse
    private Label lblFromMasse, lblToMasse, lblResultatMasse;
    private TextBox txtMasse;
    private ComboBox cmbFromMasse, cmbToMasse;
    private Button btnConvertirMasse;

    // Distance
    private Label lblFromDistance, lblToDistance, lblResultatDistance;
    private TextBox txtDistance;
    private ComboBox cmbFromDistance, cmbToDistance;
    private Button btnConvertirDistance;

    // Devise
    private Label lblFromDevise, lblToDevise, lblResultatDevise, lblNoteDevise;
    private TextBox txtDevise;
    private ComboBox cmbFromDevise, cmbToDevise;
    private Button btnConvertirDevise;
  }
}
