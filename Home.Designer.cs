namespace Kimathi_Construction
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bGradientPanelHome = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bGradientPanelHome
            // 
            this.bGradientPanelHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bGradientPanelHome.BackgroundImage")));
            this.bGradientPanelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bGradientPanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bGradientPanelHome.GradientBottomLeft = System.Drawing.Color.Lime;
            this.bGradientPanelHome.GradientBottomRight = System.Drawing.Color.Green;
            this.bGradientPanelHome.GradientTopLeft = System.Drawing.Color.DarkCyan;
            this.bGradientPanelHome.GradientTopRight = System.Drawing.Color.Blue;
            this.bGradientPanelHome.Location = new System.Drawing.Point(0, 0);
            this.bGradientPanelHome.Name = "bGradientPanelHome";
            this.bGradientPanelHome.Quality = 10;
            this.bGradientPanelHome.Size = new System.Drawing.Size(881, 511);
            this.bGradientPanelHome.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(881, 511);
            this.Controls.Add(this.bGradientPanelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bGradientPanelHome;
    }
}

