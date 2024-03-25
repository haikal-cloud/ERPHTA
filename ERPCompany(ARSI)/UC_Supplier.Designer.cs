namespace ERPCompany_ARSI_
{
    partial class UC_Supplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Supplier));
            this.dataGridView_SupplierPchse = new System.Windows.Forms.DataGridView();
            this.ProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_New = new System.Windows.Forms.Label();
            this.picturePlus = new System.Windows.Forms.PictureBox();
            this.label_diSupplier = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.label_InpaymentM2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchSideTextBox_Supplier = new System.Windows.Forms.TextBox();
            this.label_InPaymentM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label_PaymentC = new System.Windows.Forms.Label();
            this.textBox2_Supplier = new System.Windows.Forms.TextBox();
            this.label_TransparentSupplier = new System.Windows.Forms.Label();
            this.textBox1_Supplier = new System.Windows.Forms.TextBox();
            this.label_PurchaseOI = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SupplierPchse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SupplierPchse
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_SupplierPchse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_SupplierPchse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SupplierPchse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductColumn,
            this.QualityColumn,
            this.ArrivalColumn});
            this.dataGridView_SupplierPchse.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView_SupplierPchse.Location = new System.Drawing.Point(29, 435);
            this.dataGridView_SupplierPchse.Name = "dataGridView_SupplierPchse";
            this.dataGridView_SupplierPchse.RowHeadersWidth = 62;
            this.dataGridView_SupplierPchse.RowTemplate.Height = 28;
            this.dataGridView_SupplierPchse.Size = new System.Drawing.Size(1323, 80);
            this.dataGridView_SupplierPchse.TabIndex = 90;
            this.dataGridView_SupplierPchse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SupplierPchse_CellContentClick);
            // 
            // ProductColumn
            // 
            this.ProductColumn.HeaderText = "Product";
            this.ProductColumn.MinimumWidth = 8;
            this.ProductColumn.Name = "ProductColumn";
            this.ProductColumn.Width = 370;
            // 
            // QualityColumn
            // 
            this.QualityColumn.HeaderText = "Quality rating";
            this.QualityColumn.MinimumWidth = 8;
            this.QualityColumn.Name = "QualityColumn";
            this.QualityColumn.Width = 222;
            // 
            // ArrivalColumn
            // 
            this.ArrivalColumn.HeaderText = "Arrival product quantity";
            this.ArrivalColumn.MinimumWidth = 8;
            this.ArrivalColumn.Name = "ArrivalColumn";
            this.ArrivalColumn.Width = 225;
            // 
            // label_New
            // 
            this.label_New.AutoSize = true;
            this.label_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_New.Location = new System.Drawing.Point(1303, 391);
            this.label_New.Name = "label_New";
            this.label_New.Size = new System.Drawing.Size(49, 22);
            this.label_New.TabIndex = 89;
            this.label_New.Text = "New";
            this.label_New.Click += new System.EventHandler(this.label_New_Click);
            // 
            // picturePlus
            // 
            this.picturePlus.Image = ((System.Drawing.Image)(resources.GetObject("picturePlus.Image")));
            this.picturePlus.Location = new System.Drawing.Point(1271, 391);
            this.picturePlus.Name = "picturePlus";
            this.picturePlus.Size = new System.Drawing.Size(26, 26);
            this.picturePlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlus.TabIndex = 88;
            this.picturePlus.TabStop = false;
            this.picturePlus.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label_diSupplier
            // 
            this.label_diSupplier.AutoSize = true;
            this.label_diSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diSupplier.Location = new System.Drawing.Point(25, 391);
            this.label_diSupplier.Name = "label_diSupplier";
            this.label_diSupplier.Size = new System.Drawing.Size(252, 22);
            this.label_diSupplier.TabIndex = 87;
            this.label_diSupplier.Text = "Purchase order information";
            this.label_diSupplier.Click += new System.EventHandler(this.label_diSupplier_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(626, 321);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 11);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(626, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 11);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Supplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Supplier.ForeColor = System.Drawing.Color.Silver;
            this.textBox_Supplier.Location = new System.Drawing.Point(355, 329);
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.Size = new System.Drawing.Size(289, 19);
            this.textBox_Supplier.TabIndex = 84;
            this.textBox_Supplier.TextChanged += new System.EventHandler(this.textBox_Supplier_TextChanged);
            // 
            // label_InpaymentM2
            // 
            this.label_InpaymentM2.AutoSize = true;
            this.label_InpaymentM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InpaymentM2.Location = new System.Drawing.Point(351, 292);
            this.label_InpaymentM2.Name = "label_InpaymentM2";
            this.label_InpaymentM2.Size = new System.Drawing.Size(163, 22);
            this.label_InpaymentM2.TabIndex = 83;
            this.label_InpaymentM2.Text = "In Payment Mode";
            this.label_InpaymentM2.Click += new System.EventHandler(this.label_InpaymentM2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(351, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 20);
            this.label6.TabIndex = 82;
            this.label6.Text = "                                                              ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(304, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 11);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // SearchSideTextBox_Supplier
            // 
            this.SearchSideTextBox_Supplier.BackColor = System.Drawing.SystemColors.Window;
            this.SearchSideTextBox_Supplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchSideTextBox_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSideTextBox_Supplier.ForeColor = System.Drawing.Color.Silver;
            this.SearchSideTextBox_Supplier.Location = new System.Drawing.Point(29, 328);
            this.SearchSideTextBox_Supplier.Name = "SearchSideTextBox_Supplier";
            this.SearchSideTextBox_Supplier.Size = new System.Drawing.Size(289, 19);
            this.SearchSideTextBox_Supplier.TabIndex = 80;
            this.SearchSideTextBox_Supplier.TextChanged += new System.EventHandler(this.SearchSideTextBox_Supplier_TextChanged);
            // 
            // label_InPaymentM
            // 
            this.label_InPaymentM.AutoSize = true;
            this.label_InPaymentM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InPaymentM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_InPaymentM.Location = new System.Drawing.Point(25, 292);
            this.label_InPaymentM.Name = "label_InPaymentM";
            this.label_InPaymentM.Size = new System.Drawing.Size(163, 22);
            this.label_InPaymentM.TabIndex = 79;
            this.label_InPaymentM.Text = "In Payment Mode";
            this.label_InPaymentM.Click += new System.EventHandler(this.label_InPaymentM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(25, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "                                                               ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1444, 87);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 77;
            this.pictureBox5.TabStop = false;
            // 
            // label_PaymentC
            // 
            this.label_PaymentC.AutoSize = true;
            this.label_PaymentC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PaymentC.Location = new System.Drawing.Point(699, 46);
            this.label_PaymentC.Name = "label_PaymentC";
            this.label_PaymentC.Size = new System.Drawing.Size(178, 22);
            this.label_PaymentC.TabIndex = 75;
            this.label_PaymentC.Text = "Payment Condition";
            this.label_PaymentC.Click += new System.EventHandler(this.label_PaymentC_Click);
            // 
            // textBox2_Supplier
            // 
            this.textBox2_Supplier.BackColor = System.Drawing.Color.White;
            this.textBox2_Supplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_Supplier.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2_Supplier.Location = new System.Drawing.Point(703, 71);
            this.textBox2_Supplier.Name = "textBox2_Supplier";
            this.textBox2_Supplier.Size = new System.Drawing.Size(748, 23);
            this.textBox2_Supplier.TabIndex = 74;
            this.textBox2_Supplier.TextChanged += new System.EventHandler(this.textBox2_Supplier_TextChanged);
            // 
            // label_TransparentSupplier
            // 
            this.label_TransparentSupplier.AutoSize = true;
            this.label_TransparentSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TransparentSupplier.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_TransparentSupplier.Location = new System.Drawing.Point(699, 86);
            this.label_TransparentSupplier.Name = "label_TransparentSupplier";
            this.label_TransparentSupplier.Size = new System.Drawing.Size(653, 20);
            this.label_TransparentSupplier.TabIndex = 76;
            this.label_TransparentSupplier.Text = "                                                                                 " +
    "                                                                                " +
    "";
            this.label_TransparentSupplier.Click += new System.EventHandler(this.label_TransparentSupplier_Click);
            // 
            // textBox1_Supplier
            // 
            this.textBox1_Supplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_Supplier.Location = new System.Drawing.Point(29, 73);
            this.textBox1_Supplier.Multiline = true;
            this.textBox1_Supplier.Name = "textBox1_Supplier";
            this.textBox1_Supplier.Size = new System.Drawing.Size(624, 206);
            this.textBox1_Supplier.TabIndex = 73;
            this.textBox1_Supplier.TextChanged += new System.EventHandler(this.textBox1_Supplier_TextChanged);
            // 
            // label_PurchaseOI
            // 
            this.label_PurchaseOI.AutoSize = true;
            this.label_PurchaseOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PurchaseOI.Location = new System.Drawing.Point(25, 37);
            this.label_PurchaseOI.Name = "label_PurchaseOI";
            this.label_PurchaseOI.Size = new System.Drawing.Size(252, 22);
            this.label_PurchaseOI.TabIndex = 72;
            this.label_PurchaseOI.Text = "Purchase order information";
            this.label_PurchaseOI.Click += new System.EventHandler(this.label_PurchaseOI_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Silver;
            this.textBox4.Location = new System.Drawing.Point(580, 328);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 19);
            this.textBox4.TabIndex = 91;
            this.textBox4.Text = "0.00";
            // 
            // UC_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView_SupplierPchse);
            this.Controls.Add(this.label_New);
            this.Controls.Add(this.picturePlus);
            this.Controls.Add(this.label_diSupplier);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_Supplier);
            this.Controls.Add(this.label_InpaymentM2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SearchSideTextBox_Supplier);
            this.Controls.Add(this.label_InPaymentM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label_PaymentC);
            this.Controls.Add(this.textBox2_Supplier);
            this.Controls.Add(this.label_TransparentSupplier);
            this.Controls.Add(this.textBox1_Supplier);
            this.Controls.Add(this.label_PurchaseOI);
            this.Name = "UC_Supplier";
            this.Size = new System.Drawing.Size(1920, 619);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SupplierPchse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SupplierPchse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalColumn;
        private System.Windows.Forms.Label label_New;
        private System.Windows.Forms.PictureBox picturePlus;
        private System.Windows.Forms.Label label_diSupplier;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.Label label_InpaymentM2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchSideTextBox_Supplier;
        private System.Windows.Forms.Label label_InPaymentM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label_PaymentC;
        private System.Windows.Forms.TextBox textBox2_Supplier;
        private System.Windows.Forms.Label label_TransparentSupplier;
        private System.Windows.Forms.TextBox textBox1_Supplier;
        private System.Windows.Forms.Label label_PurchaseOI;
        private System.Windows.Forms.TextBox textBox4;
    }
}
