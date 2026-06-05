namespace Interface_graphique
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
      lblF = new Label();
      label2 = new Label();
      txtTemperature = new TextBox();
      btnConvertir = new Button();
      label1 = new Label();
      SuspendLayout();
      // 
      // lblF
      // 
      lblF.AutoSize = true;
      lblF.Location = new Point(102, 91);
      lblF.Name = "lblF";
      lblF.Size = new Size(133, 25);
      lblF.TabIndex = 0;
      lblF.Text = "Température °C";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(345, 140);
      label2.Name = "label2";
      label2.Size = new Size(0, 25);
      label2.TabIndex = 1;
      // 
      // txtTemperature
      // 
      txtTemperature.Location = new Point(250, 85);
      txtTemperature.Name = "txtTemperature";
      txtTemperature.Size = new Size(150, 31);
      txtTemperature.TabIndex = 2;
      txtTemperature.Text = "23";
      // 
      // btnConvertir
      // 
      btnConvertir.Location = new Point(420, 82);
      btnConvertir.Name = "btnConvertir";
      btnConvertir.Size = new Size(120, 34);
      btnConvertir.TabIndex = 3;
      btnConvertir.Text = "Convertir";
      btnConvertir.UseVisualStyleBackColor = true;
      btnConvertir.Click += btnConvertir_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(561, 87);
      label1.Name = "label1";
      label1.Size = new Size(28, 25);
      label1.TabIndex = 4;
      label1.Text = "°F";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(label1);
      Controls.Add(txtTemperature);
      Controls.Add(btnConvertir);
      Controls.Add(label2);
      Controls.Add(lblF);
      Name = "Form1";
      Text = "Conversion °C → °F";
      Load += Form1_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblF;
    private Label label2;
    private TextBox txtTemperature; 
    private Button btnConvertir;
    private Label label1;
  }
}
