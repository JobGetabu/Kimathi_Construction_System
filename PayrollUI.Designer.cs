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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.owner = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbRate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dTimePickerGrid = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColumnAdminNo = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.del = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.owner.Size = new System.Drawing.Size(50, 9);
            this.owner.TabIndex = 11;
            this.owner.Text = "@Group3";
            this.owner.Click += new System.EventHandler(this.owner_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.tbRate);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.dTimePickerGrid);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 38);
            this.panel1.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(114)))));
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(195)))), ((int)(((byte)(171)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(195)))), ((int)(((byte)(171)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(195)))), ((int)(((byte)(171)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Nasalization Rg", 9.999999F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(808, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 27);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbRate
            // 
            this.tbRate.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(195)))), ((int)(((byte)(171)))));
            this.tbRate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(129)))), ((int)(((byte)(218)))));
            this.tbRate.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(195)))), ((int)(((byte)(171)))));
            this.tbRate.BorderThickness = 1;
            this.tbRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbRate.ForeColor = System.Drawing.Color.Black;
            this.tbRate.isPassword = false;
            this.tbRate.Location = new System.Drawing.Point(704, 7);
            this.tbRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(97, 23);
            this.tbRate.TabIndex = 18;
            this.tbRate.Text = "100";
            this.tbRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // dTimePickerGrid
            // 
            this.dTimePickerGrid.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(114)))));
            this.dTimePickerGrid.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(114)))));
            this.dTimePickerGrid.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(195)))), ((int)(((byte)(171)))));
            this.dTimePickerGrid.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTimePickerGrid.Location = new System.Drawing.Point(234, 9);
            this.dTimePickerGrid.Name = "dTimePickerGrid";
            this.dTimePickerGrid.Size = new System.Drawing.Size(231, 21);
            this.dTimePickerGrid.TabIndex = 16;
            this.dTimePickerGrid.ValueChanged += new System.EventHandler(this.dTimePickerGrid_ValueChanged);
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
            // gData
            // 
            this.gData.AllowUserToAddRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.gData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAdminNo,
            this.ColumnName,
            this.ColumnClient,
            this.Form,
            this.ColumnBal,
            this.Pay,
            this.ColumnDel,
            this.del});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gData.DefaultCellStyle = dataGridViewCellStyle23;
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
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gData.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.gData.RowHeadersVisible = false;
            this.gData.RowHeadersWidth = 42;
            this.gData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gData.RowTemplate.Height = 40;
            this.gData.RowTemplate.ReadOnly = true;
            this.gData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gData.Size = new System.Drawing.Size(944, 343);
            this.gData.TabIndex = 13;
            this.gData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gData_CellContentClick);
            this.gData.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gData_RowsAdded);
            // 
            // ColumnAdminNo
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle19.NullValue")));
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ColumnAdminNo.DefaultCellStyle = dataGridViewCellStyle19;
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
            // Pay
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Pay.DefaultCellStyle = dataGridViewCellStyle20;
            this.Pay.HeaderText = "Pay (ksh)";
            this.Pay.Name = "Pay";
            this.Pay.ReadOnly = true;
            // 
            // ColumnDel
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle21.NullValue")));
            this.ColumnDel.DefaultCellStyle = dataGridViewCellStyle21;
            this.ColumnDel.HeaderText = "Status";
            this.ColumnDel.Name = "ColumnDel";
            this.ColumnDel.ReadOnly = true;
            this.ColumnDel.ToolTipText = "Delete Record";
            // 
            // del
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle22.NullValue")));
            this.del.DefaultCellStyle = dataGridViewCellStyle22;
            this.del.HeaderText = "";
            this.del.Name = "del";
            this.del.ReadOnly = true;
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
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DateTimePicker dTimePickerGrid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbRate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn ColumnAdminNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Form;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDel;
        private System.Windows.Forms.DataGridViewImageColumn del;
    }
}
