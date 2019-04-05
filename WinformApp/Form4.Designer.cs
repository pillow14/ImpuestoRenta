namespace WinformApp
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnCargaMasiva = new MetroSet_UI.Controls.MetroSetButton();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.fileExcel = new System.Windows.Forms.OpenFileDialog();
            this.txtLabel = new MetroSet_UI.Controls.MetroSetLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(16, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCargaMasiva
            // 
            this.btnCargaMasiva.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCargaMasiva.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCargaMasiva.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCargaMasiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCargaMasiva.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCargaMasiva.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCargaMasiva.HoverTextColor = System.Drawing.Color.White;
            this.btnCargaMasiva.Location = new System.Drawing.Point(372, 232);
            this.btnCargaMasiva.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargaMasiva.Name = "btnCargaMasiva";
            this.btnCargaMasiva.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCargaMasiva.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCargaMasiva.NormalTextColor = System.Drawing.Color.White;
            this.btnCargaMasiva.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCargaMasiva.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCargaMasiva.PressTextColor = System.Drawing.Color.White;
            this.btnCargaMasiva.Size = new System.Drawing.Size(92, 26);
            this.btnCargaMasiva.Style = MetroSet_UI.Design.Style.Light;
            this.btnCargaMasiva.StyleManager = null;
            this.btnCargaMasiva.TabIndex = 3;
            this.btnCargaMasiva.Text = "Carga Masiva";
            this.btnCargaMasiva.ThemeAuthor = "Narwin";
            this.btnCargaMasiva.ThemeName = "MetroLite";
            this.btnCargaMasiva.Click += new System.EventHandler(this.btnCargaMasiva_Click);
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.AllowUserToResizeColumns = false;
            this.dgUsuarios.AllowUserToResizeRows = false;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(16, 73);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.Size = new System.Drawing.Size(602, 154);
            this.dgUsuarios.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(580, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtLabel
            // 
            this.txtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLabel.Location = new System.Drawing.Point(521, 243);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(97, 15);
            this.txtLabel.Style = MetroSet_UI.Design.Style.Light;
            this.txtLabel.StyleManager = null;
            this.txtLabel.TabIndex = 6;
            this.txtLabel.ThemeAuthor = "Narwin";
            this.txtLabel.ThemeName = "MetroLite";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 272);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.btnCargaMasiva);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Mantenedor de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private MetroSet_UI.Controls.MetroSetButton btnCargaMasiva;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog fileExcel;
        private MetroSet_UI.Controls.MetroSetLabel txtLabel;
    }
}