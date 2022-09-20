namespace protim
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            MetroFramework.Controls.MetroTile metroTile1;
            MetroFramework.Controls.MetroTile metroTile2;
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            metroTile1 = new MetroFramework.Controls.MetroTile();
            metroTile2 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            metroTile1.ActiveControl = null;
            metroTile1.Location = new System.Drawing.Point(23, 116);
            metroTile1.Name = "metroTile1";
            metroTile1.Size = new System.Drawing.Size(486, 185);
            metroTile1.TabIndex = 0;
            metroTile1.Text = "FAALİYETLER";
            metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            metroTile1.UseSelectable = true;
            metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            metroTile2.ActiveControl = null;
            metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            metroTile2.Location = new System.Drawing.Point(23, 307);
            metroTile2.Name = "metroTile2";
            metroTile2.Size = new System.Drawing.Size(486, 185);
            metroTile2.TabIndex = 1;
            metroTile2.Text = "HASTALAR";
            metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            metroTile2.UseSelectable = true;
            metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(515, 116);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(262, 185);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "AYARLAR";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(515, 307);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(262, 185);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "HAKKINDA";
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 529);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(metroTile2);
            this.Controls.Add(metroTile1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "PROTİM FAALİYET TAKİP SİSTEMİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}

