namespace Kimathi_Construction
{
    partial class StatsUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsUI));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.owner = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.dTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(976, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // owner
            // 
            this.owner.AutoSize = true;
            this.owner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.owner.Font = new System.Drawing.Font("Nasalization Rg", 5.749999F, System.Drawing.FontStyle.Bold);
            this.owner.ForeColor = System.Drawing.Color.Black;
            this.owner.Location = new System.Drawing.Point(897, 477);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(73, 9);
            this.owner.TabIndex = 11;
            this.owner.Text = "@Job_Getabu";
            this.owner.Click += new System.EventHandler(this.owner_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave1);
            this.panel1.Controls.Add(this.dTimePickerIn);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 38);
            this.panel1.TabIndex = 13;
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(114)))));
            this.btnSave1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(195)))), ((int)(((byte)(171)))));
            this.btnSave1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(195)))), ((int)(((byte)(171)))));
            this.btnSave1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(195)))), ((int)(((byte)(171)))));
            this.btnSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave1.Font = new System.Drawing.Font("Nasalization Rg", 9.999999F, System.Drawing.FontStyle.Bold);
            this.btnSave1.ForeColor = System.Drawing.Color.White;
            this.btnSave1.Location = new System.Drawing.Point(808, 6);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(90, 27);
            this.btnSave1.TabIndex = 19;
            this.btnSave1.Text = "Refresh";
            this.btnSave1.UseVisualStyleBackColor = false;
            // 
            // dTimePickerIn
            // 
            this.dTimePickerIn.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(114)))));
            this.dTimePickerIn.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(114)))));
            this.dTimePickerIn.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(195)))), ((int)(((byte)(171)))));
            this.dTimePickerIn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTimePickerIn.Location = new System.Drawing.Point(234, 9);
            this.dTimePickerIn.Name = "dTimePickerIn";
            this.dTimePickerIn.Size = new System.Drawing.Size(231, 21);
            this.dTimePickerIn.TabIndex = 16;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Nasalization Rg", 12.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(59, 20);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Stats";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 113);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(976, 379);
            this.cartesianChart1.TabIndex = 14;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // StatsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.owner);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StatsUI";
            this.Size = new System.Drawing.Size(976, 492);
            this.Load += new System.EventHandler(this.StatsUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel owner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.DateTimePicker dTimePickerIn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}
