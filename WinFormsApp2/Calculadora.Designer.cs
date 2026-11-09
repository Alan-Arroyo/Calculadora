namespace WinFormsApp2
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            panelPantalla = new Panel();
            label1 = new Label();
            txtPantalla = new TextBox();
            lstHistorial = new ListBox();
            panelTeclado = new Panel();
            btnHistorial = new Button();
            button14 = new Button();
            button16 = new Button();
            button15 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnLimpiarHistorial = new Button();
            panelPantalla.SuspendLayout();
            panelTeclado.SuspendLayout();
            SuspendLayout();
            // 
            // panelPantalla
            // 
            panelPantalla.Controls.Add(label1);
            panelPantalla.Controls.Add(txtPantalla);
            panelPantalla.Location = new Point(12, 15);
            panelPantalla.Name = "panelPantalla";
            panelPantalla.Size = new Size(240, 60);
            panelPantalla.TabIndex = 0;
            panelPantalla.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.TopRight;
            label1.Click += label1_Click;
            // 
            // txtPantalla
            // 
            txtPantalla.BackColor = Color.WhiteSmoke;
            txtPantalla.BorderStyle = BorderStyle.None;
            txtPantalla.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPantalla.Location = new Point(10, 32);
            txtPantalla.Multiline = true;
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(210, 40);
            txtPantalla.TabIndex = 0;
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            txtPantalla.TextChanged += textBox1_TextChanged;
            // 
            // lstHistorial
            // 
            lstHistorial.BorderStyle = BorderStyle.None;
            lstHistorial.FormattingEnabled = true;
            lstHistorial.Location = new Point(274, 12);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(210, 465);
            lstHistorial.TabIndex = 1;
            // 
            // panelTeclado
            // 
            panelTeclado.Controls.Add(btnHistorial);
            panelTeclado.Controls.Add(button14);
            panelTeclado.Controls.Add(button16);
            panelTeclado.Controls.Add(button15);
            panelTeclado.Controls.Add(button13);
            panelTeclado.Controls.Add(button12);
            panelTeclado.Controls.Add(button11);
            panelTeclado.Controls.Add(button10);
            panelTeclado.Controls.Add(button9);
            panelTeclado.Controls.Add(button8);
            panelTeclado.Controls.Add(button7);
            panelTeclado.Controls.Add(button6);
            panelTeclado.Controls.Add(button5);
            panelTeclado.Controls.Add(button4);
            panelTeclado.Controls.Add(button3);
            panelTeclado.Controls.Add(button2);
            panelTeclado.Controls.Add(button1);
            panelTeclado.Location = new Point(12, 75);
            panelTeclado.Name = "panelTeclado";
            panelTeclado.Size = new Size(240, 346);
            panelTeclado.TabIndex = 1;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(3, 33);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(45, 43);
            btnHistorial.TabIndex = 16;
            btnHistorial.Text = "🕛";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // button14
            // 
            button14.Location = new Point(182, 29);
            button14.Name = "button14";
            button14.Size = new Size(55, 50);
            button14.TabIndex = 13;
            button14.Text = "/";
            button14.UseVisualStyleBackColor = true;
            button14.Click += BotonOperador_Click;
            // 
            // button16
            // 
            button16.Location = new Point(121, 29);
            button16.Name = "button16";
            button16.Size = new Size(55, 50);
            button16.TabIndex = 15;
            button16.Text = "c";
            button16.UseVisualStyleBackColor = true;
            button16.Click += BotonLimpiar_Click;
            // 
            // button15
            // 
            button15.Location = new Point(182, 268);
            button15.Name = "button15";
            button15.Size = new Size(55, 50);
            button15.TabIndex = 14;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = true;
            button15.Click += BotonIgual_Click;
            // 
            // button13
            // 
            button13.Location = new Point(182, 87);
            button13.Name = "button13";
            button13.Size = new Size(55, 50);
            button13.TabIndex = 12;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = true;
            button13.Click += BotonOperador_Click;
            // 
            // button12
            // 
            button12.Location = new Point(182, 153);
            button12.Name = "button12";
            button12.Size = new Size(55, 50);
            button12.TabIndex = 11;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = true;
            button12.Click += BotonOperador_Click;
            // 
            // button11
            // 
            button11.Location = new Point(182, 212);
            button11.Name = "button11";
            button11.Size = new Size(55, 50);
            button11.TabIndex = 10;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = true;
            button11.Click += BotonOperador_Click;
            // 
            // button10
            // 
            button10.Location = new Point(121, 87);
            button10.Name = "button10";
            button10.Size = new Size(55, 50);
            button10.TabIndex = 9;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += BotonNumero_Click;
            // 
            // button9
            // 
            button9.Location = new Point(64, 87);
            button9.Name = "button9";
            button9.Size = new Size(55, 50);
            button9.TabIndex = 8;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += BotonNumero_Click;
            // 
            // button8
            // 
            button8.Location = new Point(3, 87);
            button8.Name = "button8";
            button8.Size = new Size(55, 50);
            button8.TabIndex = 7;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += BotonNumero_Click;
            // 
            // button7
            // 
            button7.Location = new Point(121, 153);
            button7.Name = "button7";
            button7.Size = new Size(55, 50);
            button7.TabIndex = 6;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += BotonNumero_Click;
            // 
            // button6
            // 
            button6.Location = new Point(64, 153);
            button6.Name = "button6";
            button6.Size = new Size(55, 50);
            button6.TabIndex = 5;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += BotonNumero_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 153);
            button5.Name = "button5";
            button5.Size = new Size(55, 50);
            button5.TabIndex = 4;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += BotonNumero_Click;
            // 
            // button4
            // 
            button4.Location = new Point(121, 212);
            button4.Name = "button4";
            button4.Size = new Size(55, 50);
            button4.TabIndex = 3;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += BotonNumero_Click;
            // 
            // button3
            // 
            button3.Location = new Point(64, 212);
            button3.Name = "button3";
            button3.Size = new Size(55, 50);
            button3.TabIndex = 2;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BotonNumero_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 212);
            button2.Name = "button2";
            button2.Size = new Size(55, 50);
            button2.TabIndex = 1;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BotonNumero_Click;
            // 
            // button1
            // 
            button1.Location = new Point(60, 268);
            button1.Name = "button1";
            button1.Size = new Size(55, 50);
            button1.TabIndex = 0;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BotonNumero_Click;
            // 
            // btnLimpiarHistorial
            // 
            btnLimpiarHistorial.Location = new Point(436, 395);
            btnLimpiarHistorial.Name = "btnLimpiarHistorial";
            btnLimpiarHistorial.Size = new Size(42, 43);
            btnLimpiarHistorial.TabIndex = 17;
            btnLimpiarHistorial.Text = "🗑";
            btnLimpiarHistorial.UseVisualStyleBackColor = true;
            btnLimpiarHistorial.Click += btnLimpiarHistorial_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 431);
            Controls.Add(btnLimpiarHistorial);
            Controls.Add(lstHistorial);
            Controls.Add(panelTeclado);
            Controls.Add(panelPantalla);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculadora";
            Text = "Calculadora";
            Load += this.Calculadora_Load;
            panelPantalla.ResumeLayout(false);
            panelPantalla.PerformLayout();
            panelTeclado.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPantalla;
        private TextBox txtPantalla;
        private Panel panelTeclado;
        private Button button1;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button16;
        private Button button15;
        private Button button14;
        private Label label1;
        private ListBox lstHistorial;
        private Button btnHistorial;
        private Button btnLimpiarHistorial;
    }
}
