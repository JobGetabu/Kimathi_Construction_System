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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bGradientPanelHome = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.containerUIs = new System.Windows.Forms.Panel();
            this.panelSwitch = new System.Windows.Forms.Panel();
            this.tab4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tab3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.tab2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tab1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bGradientPanelHome.SuspendLayout();
            this.panelSwitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelSwitch;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bGradientPanelHome
            // 
            this.bGradientPanelHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bGradientPanelHome.BackgroundImage")));
            this.bGradientPanelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bGradientPanelHome.Controls.Add(this.containerUIs);
            this.bGradientPanelHome.Controls.Add(this.panelSwitch);
            this.bGradientPanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bGradientPanelHome.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(114)))));
            this.bGradientPanelHome.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(114)))));
            this.bGradientPanelHome.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(114)))));
            this.bGradientPanelHome.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(114)))));
            this.bGradientPanelHome.Location = new System.Drawing.Point(0, 0);
            this.bGradientPanelHome.Name = "bGradientPanelHome";
            this.bGradientPanelHome.Quality = 10;
            this.bGradientPanelHome.Size = new System.Drawing.Size(976, 528);
            this.bGradientPanelHome.TabIndex = 0;
            // 
            // containerUIs
            // 
            this.containerUIs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerUIs.Location = new System.Drawing.Point(0, 36);
            this.containerUIs.Name = "containerUIs";
            this.containerUIs.Size = new System.Drawing.Size(976, 492);
            this.containerUIs.TabIndex = 3;
            // 
            // panelSwitch
            // 
            this.panelSwitch.BackColor = System.Drawing.Color.Transparent;
            this.panelSwitch.Controls.Add(this.tab4);
            this.panelSwitch.Controls.Add(this.tab3);
            this.panelSwitch.Controls.Add(this.btnExit);
            this.panelSwitch.Controls.Add(this.tab2);
            this.panelSwitch.Controls.Add(this.tab1);
            this.panelSwitch.Controls.Add(this.bunifuSeparator1);
            this.panelSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSwitch.Location = new System.Drawing.Point(0, 0);
            this.panelSwitch.Name = "panelSwitch";
            this.panelSwitch.Size = new System.Drawing.Size(976, 36);
            this.panelSwitch.TabIndex = 2;
            // 
            // tab4
            // 
            this.tab4.AutoSize = true;
            this.tab4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab4.Font = new System.Drawing.Font("Nasalization Rg", 9.749999F, System.Drawing.FontStyle.Bold);
            this.tab4.ForeColor = System.Drawing.Color.White;
            this.tab4.Location = new System.Drawing.Point(312, 10);
            this.tab4.Name = "tab4";
            this.tab4.Size = new System.Drawing.Size(48, 15);
            this.tab4.TabIndex = 68;
            this.tab4.Text = "Stats";
            this.tab4.Click += new System.EventHandler(this.tab4_Click);
            // 
            // tab3
            // 
            this.tab3.AutoSize = true;
            this.tab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab3.Font = new System.Drawing.Font("Nasalization Rg", 9.749999F, System.Drawing.FontStyle.Bold);
            this.tab3.ForeColor = System.Drawing.Color.White;
            this.tab3.Location = new System.Drawing.Point(217, 10);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(60, 15);
            this.tab3.TabIndex = 67;
            this.tab3.Text = "Payroll";
            this.tab3.Click += new System.EventHandler(this.tab3_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageActive")));
            this.btnExit.Location = new System.Drawing.Point(874, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 66;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tab2
            // 
            this.tab2.AutoSize = true;
            this.tab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab2.Font = new System.Drawing.Font("Nasalization Rg", 9.749999F, System.Drawing.FontStyle.Bold);
            this.tab2.ForeColor = System.Drawing.Color.White;
            this.tab2.Location = new System.Drawing.Point(142, 10);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(51, 15);
            this.tab2.TabIndex = 3;
            this.tab2.Text = "Stock";
            this.tab2.Click += new System.EventHandler(this.tab2_Click);
            // 
            // tab1
            // 
            this.tab1.AutoSize = true;
            this.tab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab1.Font = new System.Drawing.Font("Nasalization Rg", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.ForeColor = System.Drawing.Color.White;
            this.tab1.Location = new System.Drawing.Point(33, 10);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(82, 15);
            this.tab1.TabIndex = 1;
            this.tab1.Text = "Employee";
            this.tab1.Click += new System.EventHandler(this.tab1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 10;
            this.bunifuSeparator1.Location = new System.Drawing.Point(33, 30);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(82, 13);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(976, 528);
            this.Controls.Add(this.bGradientPanelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.bGradientPanelHome.ResumeLayout(false);
            this.panelSwitch.ResumeLayout(false);
            this.panelSwitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bGradientPanelHome;
        private System.Windows.Forms.Panel panelSwitch;
        private Bunifu.Framework.UI.BunifuCustomLabel tab2;
        private Bunifu.Framework.UI.BunifuCustomLabel tab1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel containerUIs;
        private Bunifu.Framework.UI.BunifuCustomLabel tab4;
        private Bunifu.Framework.UI.BunifuCustomLabel tab3;
    }
}

