namespace Telecomando
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.power = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infrarossi = new System.Windows.Forms.RadioButton();
            this.bluetooth = new System.Windows.Forms.RadioButton();
            this.wifi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(10, 126);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(165, 126);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // power
            // 
            this.power.ForeColor = System.Drawing.Color.Red;
            this.power.Location = new System.Drawing.Point(12, 12);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(55, 23);
            this.power.TabIndex = 3;
            this.power.Text = "ON";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "canale";
            // 
            // infrarossi
            // 
            this.infrarossi.AutoSize = true;
            this.infrarossi.Location = new System.Drawing.Point(12, 50);
            this.infrarossi.Name = "infrarossi";
            this.infrarossi.Size = new System.Drawing.Size(67, 17);
            this.infrarossi.TabIndex = 6;
            this.infrarossi.TabStop = true;
            this.infrarossi.Text = "Infrarossi";
            this.infrarossi.UseVisualStyleBackColor = true;
            this.infrarossi.CheckedChanged += new System.EventHandler(this.infrarossi_CheckedChanged);
            // 
            // bluetooth
            // 
            this.bluetooth.AutoSize = true;
            this.bluetooth.Location = new System.Drawing.Point(85, 50);
            this.bluetooth.Name = "bluetooth";
            this.bluetooth.Size = new System.Drawing.Size(74, 17);
            this.bluetooth.TabIndex = 7;
            this.bluetooth.TabStop = true;
            this.bluetooth.Text = "BlueTooth";
            this.bluetooth.UseVisualStyleBackColor = true;
            this.bluetooth.CheckedChanged += new System.EventHandler(this.bluetooth_CheckedChanged);
            // 
            // wifi
            // 
            this.wifi.AutoSize = true;
            this.wifi.Location = new System.Drawing.Point(160, 50);
            this.wifi.Name = "wifi";
            this.wifi.Size = new System.Drawing.Size(46, 17);
            this.wifi.TabIndex = 8;
            this.wifi.TabStop = true;
            this.wifi.Text = "WiFi";
            this.wifi.UseVisualStyleBackColor = true;
            this.wifi.CheckedChanged += new System.EventHandler(this.wifi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 300);
            this.Controls.Add(this.wifi);
            this.Controls.Add(this.bluetooth);
            this.Controls.Add(this.infrarossi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.power);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numericUpDown2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton infrarossi;
        private System.Windows.Forms.RadioButton bluetooth;
        private System.Windows.Forms.RadioButton wifi;
    }
}

