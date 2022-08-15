namespace InstallCalculatorRemake
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStandardDouble = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStandardSingle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSr3Double = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSr3Single = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSr4Double = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSr4Single = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPanel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkUnder = new System.Windows.Forms.RadioButton();
            this.chkOver = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Single";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStandardDouble);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStandardSingle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STANDARD / SR1 / SR2";
            // 
            // txtStandardDouble
            // 
            this.txtStandardDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStandardDouble.Location = new System.Drawing.Point(181, 45);
            this.txtStandardDouble.Name = "txtStandardDouble";
            this.txtStandardDouble.Size = new System.Drawing.Size(100, 22);
            this.txtStandardDouble.TabIndex = 1;
            this.txtStandardDouble.TextChanged += new System.EventHandler(this.txtStandardDouble_TextChanged);
            this.txtStandardDouble.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStandardDouble_KeyDown);
            this.txtStandardDouble.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStandardDouble_KeyPress);
            this.txtStandardDouble.Leave += new System.EventHandler(this.txtStandardDouble_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Double";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtStandardSingle
            // 
            this.txtStandardSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStandardSingle.Location = new System.Drawing.Point(50, 45);
            this.txtStandardSingle.Name = "txtStandardSingle";
            this.txtStandardSingle.Size = new System.Drawing.Size(100, 22);
            this.txtStandardSingle.TabIndex = 0;
            this.txtStandardSingle.TextChanged += new System.EventHandler(this.txtStandardSingle_TextChanged);
            this.txtStandardSingle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStandardSingle_KeyDown);
            this.txtStandardSingle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStandardSingle_KeyPress);
            this.txtStandardSingle.Leave += new System.EventHandler(this.txtStandardSingle_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSr3Double);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSr3Single);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SR3 / FLOOD";
            // 
            // txtSr3Double
            // 
            this.txtSr3Double.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSr3Double.Location = new System.Drawing.Point(181, 45);
            this.txtSr3Double.Name = "txtSr3Double";
            this.txtSr3Double.Size = new System.Drawing.Size(100, 22);
            this.txtSr3Double.TabIndex = 3;
            this.txtSr3Double.TextChanged += new System.EventHandler(this.txtSr3Double_TextChanged);
            this.txtSr3Double.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSr3Double_KeyDown);
            this.txtSr3Double.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSr3Double_KeyPress);
            this.txtSr3Double.Leave += new System.EventHandler(this.txtSr3Double_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Double";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtSr3Single
            // 
            this.txtSr3Single.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSr3Single.Location = new System.Drawing.Point(50, 45);
            this.txtSr3Single.Name = "txtSr3Single";
            this.txtSr3Single.Size = new System.Drawing.Size(100, 22);
            this.txtSr3Single.TabIndex = 2;
            this.txtSr3Single.TextChanged += new System.EventHandler(this.txtSr3Single_TextChanged);
            this.txtSr3Single.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSr3Single_KeyDown);
            this.txtSr3Single.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSr3Single_KeyPress);
            this.txtSr3Single.Leave += new System.EventHandler(this.txtSr3Single_Leave);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Single";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSr4Double);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSr4Single);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 82);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SR4 ";
            // 
            // txtSr4Double
            // 
            this.txtSr4Double.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSr4Double.Location = new System.Drawing.Point(181, 45);
            this.txtSr4Double.Name = "txtSr4Double";
            this.txtSr4Double.Size = new System.Drawing.Size(100, 22);
            this.txtSr4Double.TabIndex = 5;
            this.txtSr4Double.TextChanged += new System.EventHandler(this.txtSr4Double_TextChanged);
            this.txtSr4Double.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSr4Double_KeyDown);
            this.txtSr4Double.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSr4Double_KeyPress);
            this.txtSr4Double.Leave += new System.EventHandler(this.txtSr4Double_Leave);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Double";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtSr4Single
            // 
            this.txtSr4Single.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSr4Single.Location = new System.Drawing.Point(50, 45);
            this.txtSr4Single.Name = "txtSr4Single";
            this.txtSr4Single.Size = new System.Drawing.Size(100, 22);
            this.txtSr4Single.TabIndex = 4;
            this.txtSr4Single.TextChanged += new System.EventHandler(this.txtSr4Single_TextChanged);
            this.txtSr4Single.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSr4Single_KeyDown);
            this.txtSr4Single.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSr4Single_KeyPress);
            this.txtSr4Single.Leave += new System.EventHandler(this.txtSr4Single_Leave);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Single";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPanel);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 343);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 82);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PANEL";
            // 
            // txtPanel
            // 
            this.txtPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanel.Location = new System.Drawing.Point(124, 45);
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.Size = new System.Drawing.Size(100, 22);
            this.txtPanel.TabIndex = 6;
            this.txtPanel.TextChanged += new System.EventHandler(this.txtPanel_TextChanged);
            this.txtPanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPanel_KeyDown);
            this.txtPanel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPanel_KeyPress);
            this.txtPanel.Leave += new System.EventHandler(this.txtPanel_Leave);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Single";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkOver);
            this.groupBox5.Controls.Add(this.chkUnder);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(330, 61);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TRAVEL";
            // 
            // chkUnder
            // 
            this.chkUnder.AutoSize = true;
            this.chkUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnder.Location = new System.Drawing.Point(15, 27);
            this.chkUnder.Name = "chkUnder";
            this.chkUnder.Size = new System.Drawing.Size(137, 20);
            this.chkUnder.TabIndex = 20;
            this.chkUnder.TabStop = true;
            this.chkUnder.Text = "Up to 2 hours drive";
            this.chkUnder.UseVisualStyleBackColor = true;
            this.chkUnder.CheckedChanged += new System.EventHandler(this.chkUnder_CheckedChanged);
            // 
            // chkOver
            // 
            this.chkOver.AutoSize = true;
            this.chkOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOver.Location = new System.Drawing.Point(175, 27);
            this.chkOver.Name = "chkOver";
            this.chkOver.Size = new System.Drawing.Size(134, 20);
            this.chkOver.TabIndex = 21;
            this.chkOver.TabStop = true;
            this.chkOver.Text = "Over 2 hours drive";
            this.chkOver.UseVisualStyleBackColor = true;
            this.chkOver.CheckedChanged += new System.EventHandler(this.chkOver_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(129, 460);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(246, 459);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 498);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installation Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStandardDouble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStandardSingle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSr3Double;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSr3Single;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSr4Double;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSr4Single;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton chkOver;
        private System.Windows.Forms.RadioButton chkUnder;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
    }
}

