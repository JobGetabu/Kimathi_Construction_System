namespace Kimathi_Construction
{
    partial class PayrollUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            this.owner = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColumnAdminNo = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.del = new System.Windows.Forms.DataGridViewImageColumn();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbcementreg = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.tbcementreg);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.dTimePickerIn);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 38);
            this.panel1.TabIndex = 12;
            // 
            // gData
            // 
            this.gData.AllowUserToAddRows = false;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.gData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAdminNo,
            this.ColumnName,
            this.ColumnClient,
            this.Form,
            this.ColumnBal,
            this.Class,
            this.ColumnDel,
            this.del});
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gData.DefaultCellStyle = dataGridViewCellStyle39;
            this.gData.DoubleBuffered = true;
            this.gData.EnableHeadersVisualStyles = false;
            this.gData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gData.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gData.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.gData.Location = new System.Drawing.Point(15, 119);
            this.gData.MultiSelect = false;
            this.gData.Name = "gData";
            this.gData.ReadOnly = true;
            this.gData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gData.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.gData.RowHeadersVisible = false;
            this.gData.RowHeadersWidth = 42;
            this.gData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gData.RowTemplate.Height = 40;
            this.gData.RowTemplate.ReadOnly = true;
            this.gData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gData.Size = new System.Drawing.Size(944, 343);
            this.gData.TabIndex = 13;
            // 
            // ColumnAdminNo
            // 
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle35.NullValue")));
            dataGridViewCellStyle35.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ColumnAdminNo.DefaultCellStyle = dataGridViewCellStyle35;
            this.ColumnAdminNo.HeaderText = "";
            this.ColumnAdminNo.Name = "ColumnAdminNo";
            this.ColumnAdminNo.ReadOnly = true;
            this.ColumnAdminNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAdminNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Emp Id";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnClient
            // 
            this.ColumnClient.HeaderText = "Name";
            this.ColumnClient.Name = "ColumnClient";
            this.ColumnClient.ReadOnly = true;
            // 
            // Form
            // 
            this.Form.HeaderText = "Time In";
            this.Form.Name = "Form";
            this.Form.ReadOnly = true;
            // 
            // ColumnBal
            // 
            this.ColumnBal.HeaderText = "Time Out";
            this.ColumnBal.Name = "ColumnBal";
            this.ColumnBal.ReadOnly = true;
            // 
            // Class
            // 
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Class.DefaultCellStyle = dataGridViewCellStyle36;
            this.Class.HeaderText = "Pay (ksh)";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // ColumnDel
            // 
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle37.NullValue")));
            this.ColumnDel.DefaultCellStyle = dataGridViewCellStyle37;
            this.ColumnDel.HeaderText = "Status";
            this.ColumnDel.Name = "ColumnDel";
            this.ColumnDel.ReadOnly = true;
            this.ColumnDel.ToolTipText = "Delete Record";
            // 
            // del
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle38.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle38.NullValue")));
            this.del.DefaultCellStyle = dataGridViewCellStyle38;
            this.del.HeaderText = "";
            this.del.Name = "del";
            this.del.ReadOnly = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Nasalization Rg", 12.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(129, 20);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Daily Payroll";
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
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Nasalization Rg", 10.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(615, 11);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(82, 18);
            this.bunifuCustomLabel2.TabIndex = 17;
            this.bunifuCustomLabel2.Text = "Rate /Hr";
            // 
            // tbcementreg
            // 
            this.tbcementreg.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(195)))), ((int)(((byte)(171)))));
            this.tbcementreg.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(129)))), ((int)(((byte)(218)))));
            this.tbcementreg.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(195)))), ((int)(((byte)(171)))));
            this.tbcementreg.BorderThickness = 1;
            this.tbcementreg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbcementreg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbcementreg.ForeColor = System.Drawing.Color.Black;
            this.tbcementreg.isPassword = false;
            this.tbcementreg.Location = new System.Drawing.Point(704, 7);
            this.tbcementreg.Margin = new System.Windows.Forms.Padding(4);
            this.tbcementreg.Name = "tbcementreg";
            this.tbcementreg.Size = new System.Drawing.Size(97, 23);
            this.tbcementreg.TabIndex = 18;
            this.tbcementreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnSave1.Text = "Update";
            this.btnSave1.UseVisualStyleBackColor = false;
            // 
            // PayrollUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.owner);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PayrollUI";
            this.Size = new System.Drawing.Size(976, 492);
            this.Load += new System.EventHandler(this.PayrollUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel owner;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gData;
        private System.Windows.Forms.DataGridViewImageColumn ColumnAdminNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Form;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDel;
        private System.Windows.Forms.DataGridViewImageColumn del;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DateTimePicker dTimePickerIn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbcementreg;
        private System.Windows.Forms.Button btnSave1;
    }
}
