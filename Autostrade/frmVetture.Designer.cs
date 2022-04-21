namespace Autostrade
{
    partial class frmVetture
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
            this.rjButton1 = new Autostrade.BTNCONTROLLER.RJButton();
            this.rjButton2 = new Autostrade.BTNCONTROLLER.RJButton();
            this.rjButton3 = new Autostrade.BTNCONTROLLER.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TableMacchine = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rjButton1);
            this.flowLayoutPanel1.Controls.Add(this.rjButton2);
            this.flowLayoutPanel1.Controls.Add(this.rjButton3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(790, 62);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MidnightBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.Blue;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(10, 10);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(10);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(129, 52);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.Text = "AGGIUNGI VETTURA";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click_1);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MidnightBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.Blue;
            this.rjButton2.BorderRadius = 15;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(159, 10);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(10);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(121, 52);
            this.rjButton2.TabIndex = 4;
            this.rjButton2.Text = "Button";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.MidnightBlue;
            this.rjButton3.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.rjButton3.BorderColor = System.Drawing.Color.Blue;
            this.rjButton3.BorderRadius = 15;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(300, 10);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(10);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(122, 52);
            this.rjButton3.TabIndex = 5;
            this.rjButton3.Text = "Button";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 62);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TableMacchine);
            this.splitContainer1.Size = new System.Drawing.Size(790, 388);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 2;
            // 
            // TableMacchine
            // 
            this.TableMacchine.AutoScroll = true;
            this.TableMacchine.AutoSize = true;
            this.TableMacchine.BackColor = System.Drawing.Color.Transparent;
            this.TableMacchine.ColumnCount = 1;
            this.TableMacchine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMacchine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMacchine.Location = new System.Drawing.Point(0, 0);
            this.TableMacchine.Name = "TableMacchine";
            this.TableMacchine.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.TableMacchine.RowCount = 1;
            this.TableMacchine.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMacchine.Size = new System.Drawing.Size(263, 388);
            this.TableMacchine.TabIndex = 1;
            this.TableMacchine.Paint += new System.Windows.Forms.PaintEventHandler(this.TableMacchine_Paint);
            // 
            // frmVetture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmVetture";
            this.Text = "frmVetture";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Autostrade.BTNCONTROLLER.RJButton rjButton1;
        private Autostrade.BTNCONTROLLER.RJButton rjButton2;
        private Autostrade.BTNCONTROLLER.RJButton rjButton3;
        private Panel panel1;
        private TableLayoutPanel TableMacchine;
        private SplitContainer splitContainer1;
    }
}