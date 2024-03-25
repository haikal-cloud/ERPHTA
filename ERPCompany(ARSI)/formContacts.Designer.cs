namespace ERPCompany_ARSI_
{
    partial class formContacts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formContacts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RefColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RightMove = new System.Windows.Forms.Button();
            this.PageIncrement = new System.Windows.Forms.TextBox();
            this.LeftMove = new System.Windows.Forms.Button();
            this.PanelTopWhite4 = new System.Windows.Forms.Panel();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SearchIconTop = new System.Windows.Forms.Button();
            this.SearchTopTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelTopWhite4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefColumn,
            this.SupplierColumn,
            this.StockColumn,
            this.StatusColumn});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(4, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1554, 315);
            this.dataGridView1.TabIndex = 12;
            // 
            // RefColumn
            // 
            this.RefColumn.HeaderText = "Ref.";
            this.RefColumn.MinimumWidth = 8;
            this.RefColumn.Name = "RefColumn";
            this.RefColumn.Width = 350;
            // 
            // SupplierColumn
            // 
            this.SupplierColumn.HeaderText = "Supplier";
            this.SupplierColumn.MinimumWidth = 8;
            this.SupplierColumn.Name = "SupplierColumn";
            this.SupplierColumn.Width = 250;
            // 
            // StockColumn
            // 
            this.StockColumn.HeaderText = "Stock Location";
            this.StockColumn.MinimumWidth = 8;
            this.StockColumn.Name = "StockColumn";
            this.StockColumn.Width = 250;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.MinimumWidth = 8;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Width = 121;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(464, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // RightMove
            // 
            this.RightMove.BackColor = System.Drawing.Color.Transparent;
            this.RightMove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightMove.BackgroundImage")));
            this.RightMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightMove.ForeColor = System.Drawing.Color.Transparent;
            this.RightMove.Location = new System.Drawing.Point(1501, 8);
            this.RightMove.Name = "RightMove";
            this.RightMove.Size = new System.Drawing.Size(34, 34);
            this.RightMove.TabIndex = 14;
            this.RightMove.UseVisualStyleBackColor = false;
            // 
            // PageIncrement
            // 
            this.PageIncrement.ForeColor = System.Drawing.Color.Gray;
            this.PageIncrement.Location = new System.Drawing.Point(1334, 14);
            this.PageIncrement.Name = "PageIncrement";
            this.PageIncrement.Size = new System.Drawing.Size(83, 26);
            this.PageIncrement.TabIndex = 9;
            this.PageIncrement.Text = "1 to 5 of 5";
            // 
            // LeftMove
            // 
            this.LeftMove.BackColor = System.Drawing.Color.Transparent;
            this.LeftMove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftMove.BackgroundImage")));
            this.LeftMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftMove.ForeColor = System.Drawing.Color.Transparent;
            this.LeftMove.Location = new System.Drawing.Point(1461, 8);
            this.LeftMove.Name = "LeftMove";
            this.LeftMove.Size = new System.Drawing.Size(34, 34);
            this.LeftMove.TabIndex = 13;
            this.LeftMove.UseVisualStyleBackColor = false;
            // 
            // PanelTopWhite4
            // 
            this.PanelTopWhite4.BackColor = System.Drawing.Color.White;
            this.PanelTopWhite4.Controls.Add(this.PlusBtn);
            this.PanelTopWhite4.Controls.Add(this.pictureBox3);
            this.PanelTopWhite4.Controls.Add(this.pictureBox2);
            this.PanelTopWhite4.Controls.Add(this.pictureBox1);
            this.PanelTopWhite4.Controls.Add(this.SearchIconTop);
            this.PanelTopWhite4.Controls.Add(this.SearchTopTextBox);
            this.PanelTopWhite4.Controls.Add(this.RightMove);
            this.PanelTopWhite4.Controls.Add(this.PageIncrement);
            this.PanelTopWhite4.Controls.Add(this.LeftMove);
            this.PanelTopWhite4.Location = new System.Drawing.Point(1, 62);
            this.PanelTopWhite4.Name = "PanelTopWhite4";
            this.PanelTopWhite4.Size = new System.Drawing.Size(1557, 55);
            this.PanelTopWhite4.TabIndex = 11;
            // 
            // PlusBtn
            // 
            this.PlusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlusBtn.FlatAppearance.BorderSize = 0;
            this.PlusBtn.Image = ((System.Drawing.Image)(resources.GetObject("PlusBtn.Image")));
            this.PlusBtn.Location = new System.Drawing.Point(369, 7);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(32, 33);
            this.PlusBtn.TabIndex = 26;
            this.PlusBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(417, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // SearchIconTop
            // 
            this.SearchIconTop.BackColor = System.Drawing.Color.Transparent;
            this.SearchIconTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchIconTop.BackgroundImage")));
            this.SearchIconTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchIconTop.ForeColor = System.Drawing.Color.Transparent;
            this.SearchIconTop.Location = new System.Drawing.Point(320, 6);
            this.SearchIconTop.Name = "SearchIconTop";
            this.SearchIconTop.Size = new System.Drawing.Size(34, 34);
            this.SearchIconTop.TabIndex = 16;
            this.SearchIconTop.UseVisualStyleBackColor = false;
            // 
            // SearchTopTextBox
            // 
            this.SearchTopTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTopTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.SearchTopTextBox.Location = new System.Drawing.Point(3, 3);
            this.SearchTopTextBox.Multiline = true;
            this.SearchTopTextBox.Name = "SearchTopTextBox";
            this.SearchTopTextBox.Size = new System.Drawing.Size(351, 39);
            this.SearchTopTextBox.TabIndex = 15;
            this.SearchTopTextBox.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(824, 754);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "No records found";
            // 
            // formContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PanelTopWhite4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formContacts";
            this.Text = "formInventory";
            this.Load += new System.EventHandler(this.formContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelTopWhite4.ResumeLayout(false);
            this.PanelTopWhite4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RightMove;
        private System.Windows.Forms.TextBox PageIncrement;
        private System.Windows.Forms.Button LeftMove;
        private System.Windows.Forms.Panel PanelTopWhite4;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button SearchIconTop;
        private System.Windows.Forms.TextBox SearchTopTextBox;
        private System.Windows.Forms.Label label1;
    }
}