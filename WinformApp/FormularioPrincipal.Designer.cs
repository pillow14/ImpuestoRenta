namespace WinformApp
{
    public partial class FormularioPrincipal 
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
            this.metroSetTile1 = new MetroSet_UI.Controls.MetroSetTile();
            this.metroSetTile2 = new MetroSet_UI.Controls.MetroSetTile();
            this.metroSetTile3 = new MetroSet_UI.Controls.MetroSetTile();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.label2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnProcesar = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // metroSetTile1
            // 
            this.metroSetTile1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile1.Location = new System.Drawing.Point(25, 87);
            this.metroSetTile1.Name = "metroSetTile1";
            this.metroSetTile1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile1.Size = new System.Drawing.Size(130, 23);
            this.metroSetTile1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTile1.StyleManager = null;
            this.metroSetTile1.TabIndex = 0;
            this.metroSetTile1.Text = "Usuarios";
            this.metroSetTile1.ThemeAuthor = "Narwin";
            this.metroSetTile1.ThemeName = "MetroLite";
            this.metroSetTile1.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.metroSetTile1.Click += new System.EventHandler(this.metroSetTile1_Click);
            // 
            // metroSetTile2
            // 
            this.metroSetTile2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile2.Location = new System.Drawing.Point(179, 87);
            this.metroSetTile2.Name = "metroSetTile2";
            this.metroSetTile2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile2.Size = new System.Drawing.Size(121, 23);
            this.metroSetTile2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTile2.StyleManager = null;
            this.metroSetTile2.TabIndex = 1;
            this.metroSetTile2.Text = "Log Actividades";
            this.metroSetTile2.ThemeAuthor = "Narwin";
            this.metroSetTile2.ThemeName = "MetroLite";
            this.metroSetTile2.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.metroSetTile2.Click += new System.EventHandler(this.metroSetTile2_Click);
            // 
            // metroSetTile3
            // 
            this.metroSetTile3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile3.Location = new System.Drawing.Point(325, 87);
            this.metroSetTile3.Name = "metroSetTile3";
            this.metroSetTile3.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile3.Size = new System.Drawing.Size(130, 23);
            this.metroSetTile3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTile3.StyleManager = null;
            this.metroSetTile3.TabIndex = 2;
            this.metroSetTile3.Text = "Tipo Declaraciones";
            this.metroSetTile3.ThemeAuthor = "Narwin";
            this.metroSetTile3.ThemeName = "MetroLite";
            this.metroSetTile3.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.metroSetTile3.Click += new System.EventHandler(this.metroSetTile3_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(25, 141);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(208, 92);
            this.checkedListBox1.TabIndex = 3;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(377, 141);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(228, 92);
            this.checkedListBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(25, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.Style = MetroSet_UI.Design.Style.Light;
            this.label1.StyleManager = null;
            this.label1.TabIndex = 5;
            this.label1.ThemeAuthor = "Narwin";
            this.label1.ThemeName = "MetroLite";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(377, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 23);
            this.label2.Style = MetroSet_UI.Design.Style.Light;
            this.label2.StyleManager = null;
            this.label2.TabIndex = 6;
            this.label2.ThemeAuthor = "Narwin";
            this.label2.ThemeName = "MetroLite";
            // 
            // btnProcesar
            // 
            this.btnProcesar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnProcesar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnProcesar.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProcesar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnProcesar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnProcesar.HoverTextColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(25, 330);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnProcesar.NormalColor = System.Drawing.Color.Gray;
            this.btnProcesar.NormalTextColor = System.Drawing.Color.White;
            this.btnProcesar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnProcesar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnProcesar.PressTextColor = System.Drawing.Color.White;
            this.btnProcesar.Size = new System.Drawing.Size(146, 23);
            this.btnProcesar.Style = MetroSet_UI.Design.Style.Light;
            this.btnProcesar.StyleManager = null;
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.ThemeAuthor = "Narwin";
            this.btnProcesar.ThemeName = "MetroLite";
            this.btnProcesar.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // metroSetButton2
            // 
            this.metroSetButton2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverTextColor = System.Drawing.Color.Black;
            this.metroSetButton2.Location = new System.Drawing.Point(737, 2);
            this.metroSetButton2.Name = "metroSetButton2";
            this.metroSetButton2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.NormalColor = System.Drawing.Color.Red;
            this.metroSetButton2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Size = new System.Drawing.Size(63, 41);
            this.metroSetButton2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetButton2.StyleManager = null;
            this.metroSetButton2.TabIndex = 8;
            this.metroSetButton2.Text = "Salir";
            this.metroSetButton2.ThemeAuthor = "Narwin";
            this.metroSetButton2.ThemeName = "MetroLite";
            this.metroSetButton2.Click += new System.EventHandler(this.metroSetButton2_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroSetButton2);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.metroSetTile3);
            this.Controls.Add(this.metroSetTile2);
            this.Controls.Add(this.metroSetTile1);
            this.Name = "FormularioPrincipal";
            this.Text = "Declaraciones Juradas";
            this.TextColor = System.Drawing.Color.Black;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTile metroSetTile1;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile2;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private MetroSet_UI.Controls.MetroSetLabel label1;
        private MetroSet_UI.Controls.MetroSetLabel label2;
        private MetroSet_UI.Controls.MetroSetButton btnProcesar;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton2;
    }
}