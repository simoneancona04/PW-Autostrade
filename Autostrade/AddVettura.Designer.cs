namespace Autostrade
{
    partial class AddVettura
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
            this.rjButton1 = new Autostrade.BTNCONTROLLER.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.immBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new Autostrade.BTNCONTROLLER.RJButton();
            this.targaBox = new System.Windows.Forms.TextBox();
            this.modBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.MidnightBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.Blue;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(593, 10);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(10);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(110, 40);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "CHIUDI";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.targaBox);
            this.panel1.Controls.Add(this.modBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 75, 0, 0);
            this.panel1.Size = new System.Drawing.Size(722, 403);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.immBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 270);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Targa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anno di\r\nImmatricolazione";
            // 
            // immBox
            // 
            this.immBox.Location = new System.Drawing.Point(211, 3);
            this.immBox.Name = "immBox";
            this.immBox.Size = new System.Drawing.Size(199, 23);
            this.immBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modello";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 345);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(722, 58);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.addButton.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.addButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addButton.BorderRadius = 15;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(569, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 40);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "AGGIUNGI";
            this.addButton.TextColor = System.Drawing.Color.White;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // targaBox
            // 
            this.targaBox.Location = new System.Drawing.Point(353, 146);
            this.targaBox.Name = "targaBox";
            this.targaBox.Size = new System.Drawing.Size(199, 23);
            this.targaBox.TabIndex = 5;
            // 
            // modBox
            // 
            this.modBox.Location = new System.Drawing.Point(353, 110);
            this.modBox.Name = "modBox";
            this.modBox.Size = new System.Drawing.Size(199, 23);
            this.modBox.TabIndex = 4;
            // 
            // AddVettura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(722, 403);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddVettura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddVettura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BTNCONTROLLER.RJButton rjButton1;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private TextBox immBox;
        private TextBox targaBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox modBox;
        private TableLayoutPanel tableLayoutPanel1;
        private BTNCONTROLLER.RJButton addButton;
    }
}