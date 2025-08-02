using Manufacturer.Desktop.Models;

namespace Manufacturer.Desktop.Forms
{
    partial class BlanketForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            txtModelName = new TextBox();
            txtMaterial = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            numCapacity = new NumericUpDown();
            numInStock = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(285, 72);
            label1.TabIndex = 0;
            label1.Text = "Model Name\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 72);
            label2.Name = "label2";
            label2.Size = new Size(285, 83);
            label2.TabIndex = 1;
            label2.Text = "Material";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 155);
            label3.Name = "label3";
            label3.Size = new Size(285, 69);
            label3.TabIndex = 2;
            label3.Text = "Production Capacity";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 224);
            label4.Name = "label4";
            label4.Size = new Size(285, 60);
            label4.TabIndex = 3;
            label4.Text = "In Stock";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(294, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(285, 26);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtModelName
            // 
            txtModelName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtModelName.Location = new Point(294, 3);
            txtModelName.Name = "txtModelName";
            txtModelName.Size = new Size(285, 27);
            txtModelName.TabIndex = 5;
            // 
            // txtMaterial
            // 
            txtMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaterial.Location = new Point(294, 75);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.Size = new Size(285, 27);
            txtMaterial.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtMaterial, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtModelName, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSave, 1, 4);
            tableLayoutPanel1.Controls.Add(numCapacity, 1, 2);
            tableLayoutPanel1.Controls.Add(numInStock, 1, 3);
            tableLayoutPanel1.Location = new Point(121, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.47059F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.52941F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.Size = new Size(582, 316);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // numCapacity
            // 
            numCapacity.Dock = DockStyle.Fill;
            numCapacity.Location = new Point(294, 158);
            numCapacity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(285, 27);
            numCapacity.TabIndex = 7;
            // 
            // numInStock
            // 
            numInStock.Dock = DockStyle.Fill;
            numInStock.Location = new Point(294, 227);
            numInStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numInStock.Name = "numInStock";
            numInStock.Size = new Size(285, 27);
            numInStock.TabIndex = 8;
            // 
            // BlanketForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "BlanketForm";
            Text = "BlanketForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private TextBox txtModelName;
        private TextBox txtMaterial;
        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown numCapacity;
        private NumericUpDown numInStock;
    }
}