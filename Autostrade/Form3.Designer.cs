namespace Autostrade
{
    partial class Form3
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addAuto = new Autostrade.BTNCONTROLLER.RJButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.closePage = new Autostrade.BTNCONTROLLER.RJButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.consumiBox = new System.Windows.Forms.TextBox();
            this.targaBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modBox = new System.Windows.Forms.TextBox();
            this.marcaBox = new System.Windows.Forms.TextBox();
            this.dataScadBolli = new System.Windows.Forms.DateTimePicker();
            this.dataCambiopne = new System.Windows.Forms.DateTimePicker();
            this.rjButton1 = new Autostrade.BTNCONTROLLER.RJButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rjButton2 = new Autostrade.BTNCONTROLLER.RJButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addAuto);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 402);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 48);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // addAuto
            // 
            this.addAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(113)))), ((int)(((byte)(1)))));
            this.addAuto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(113)))), ((int)(((byte)(1)))));
            this.addAuto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addAuto.BorderRadius = 15;
            this.addAuto.BorderSize = 0;
            this.addAuto.FlatAppearance.BorderSize = 0;
            this.addAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAuto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addAuto.ForeColor = System.Drawing.Color.White;
            this.addAuto.Location = new System.Drawing.Point(647, 3);
            this.addAuto.Name = "addAuto";
            this.addAuto.Size = new System.Drawing.Size(150, 40);
            this.addAuto.TabIndex = 0;
            this.addAuto.Text = "AGGIUNGI";
            this.addAuto.TextColor = System.Drawing.Color.White;
            this.addAuto.UseVisualStyleBackColor = false;
            this.addAuto.Click += new System.EventHandler(this.addAuto_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.closePage);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(800, 39);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // closePage
            // 
            this.closePage.BackColor = System.Drawing.Color.Red;
            this.closePage.BackgroundColor = System.Drawing.Color.Red;
            this.closePage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.closePage.BorderRadius = 15;
            this.closePage.BorderSize = 0;
            this.closePage.FlatAppearance.BorderSize = 0;
            this.closePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closePage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closePage.ForeColor = System.Drawing.Color.White;
            this.closePage.Location = new System.Drawing.Point(697, 3);
            this.closePage.Name = "closePage";
            this.closePage.Size = new System.Drawing.Size(100, 30);
            this.closePage.TabIndex = 0;
            this.closePage.Text = "CHIUDI";
            this.closePage.TextColor = System.Drawing.Color.White;
            this.closePage.UseVisualStyleBackColor = false;
            this.closePage.Click += new System.EventHandler(this.closePage_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.5F));
            this.tableLayoutPanel1.Controls.Add(this.rjButton2, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.consumiBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.targaBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.modBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.marcaBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataScadBolli, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dataCambiopne, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.rjButton1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091074F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091074F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091074F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091074F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091074F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091074F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091074F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091074F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091074F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090166F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090166F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 351);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(180)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(207, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(590, 25);
            this.textBox2.TabIndex = 24;
            // 
            // consumiBox
            // 
            this.consumiBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(180)))));
            this.consumiBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consumiBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consumiBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consumiBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.consumiBox.Location = new System.Drawing.Point(207, 158);
            this.consumiBox.Name = "consumiBox";
            this.consumiBox.Size = new System.Drawing.Size(590, 25);
            this.consumiBox.TabIndex = 16;
            // 
            // targaBox
            // 
            this.targaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(180)))));
            this.targaBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.targaBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targaBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.targaBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.targaBox.Location = new System.Drawing.Point(207, 65);
            this.targaBox.Name = "targaBox";
            this.targaBox.Size = new System.Drawing.Size(590, 25);
            this.targaBox.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Eventuali sinistri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Assicurazione RCA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cambio pneumatici";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modello";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Targa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Libretto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Anno di Immatricolazione";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Consumi giornalieri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Scadenze bolli";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tagliandi";
            // 
            // modBox
            // 
            this.modBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(180)))));
            this.modBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.modBox.Location = new System.Drawing.Point(207, 34);
            this.modBox.Name = "modBox";
            this.modBox.Size = new System.Drawing.Size(590, 25);
            this.modBox.TabIndex = 11;
            // 
            // marcaBox
            // 
            this.marcaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(180)))));
            this.marcaBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.marcaBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marcaBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marcaBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.marcaBox.Location = new System.Drawing.Point(207, 3);
            this.marcaBox.Name = "marcaBox";
            this.marcaBox.Size = new System.Drawing.Size(590, 25);
            this.marcaBox.TabIndex = 12;
            // 
            // dataScadBolli
            // 
            this.dataScadBolli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataScadBolli.Location = new System.Drawing.Point(207, 189);
            this.dataScadBolli.Name = "dataScadBolli";
            this.dataScadBolli.Size = new System.Drawing.Size(200, 23);
            this.dataScadBolli.TabIndex = 20;
            // 
            // dataCambiopne
            // 
            this.dataCambiopne.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataCambiopne.Location = new System.Drawing.Point(207, 251);
            this.dataCambiopne.Name = "dataCambiopne";
            this.dataCambiopne.Size = new System.Drawing.Size(200, 23);
            this.dataCambiopne.TabIndex = 22;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.White;
            this.rjButton1.BackgroundColor = System.Drawing.Color.White;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 5;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rjButton1.Location = new System.Drawing.Point(207, 96);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 25);
            this.rjButton1.TabIndex = 25;
            this.rjButton1.Text = "AGGIUNGI FILE";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click_2);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.White;
            this.rjButton2.BackgroundColor = System.Drawing.Color.White;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 5;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rjButton2.Location = new System.Drawing.Point(207, 282);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 25);
            this.rjButton2.TabIndex = 27;
            this.rjButton2.Text = "AGGIUNGI FILE";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private BTNCONTROLLER.RJButton addAuto;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private BTNCONTROLLER.RJButton closePage;
        private TextBox modBox;
        private TextBox consumiBox;
        private TextBox targaBox;
        private TextBox marcaBox;
        private TextBox textBox2;
        private DateTimePicker dataScadBolli;
        private DateTimePicker dataCambiopne;
        private OpenFileDialog openFileDialog1;
        private BTNCONTROLLER.RJButton rjButton1;
        private DateTimePicker dateTimePicker1;
        private BTNCONTROLLER.RJButton rjButton2;
    }
}