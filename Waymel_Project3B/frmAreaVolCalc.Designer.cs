namespace AreaVolCalc_3A
{
    partial class frmAreaVolCalc
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
            this.lblAreaVolCalc = new System.Windows.Forms.Label();
            this.rdArea = new System.Windows.Forms.RadioButton();
            this.rdVolume = new System.Windows.Forms.RadioButton();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearInputs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAreaOfCircle = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDivBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDivTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAreaVolCalc
            // 
            this.lblAreaVolCalc.AutoSize = true;
            this.lblAreaVolCalc.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaVolCalc.Location = new System.Drawing.Point(12, 51);
            this.lblAreaVolCalc.Name = "lblAreaVolCalc";
            this.lblAreaVolCalc.Size = new System.Drawing.Size(466, 40);
            this.lblAreaVolCalc.TabIndex = 0;
            this.lblAreaVolCalc.Text = "Area and Volume Calculations";
            // 
            // rdArea
            // 
            this.rdArea.AutoSize = true;
            this.rdArea.Checked = true;
            this.rdArea.Location = new System.Drawing.Point(11, 19);
            this.rdArea.Name = "rdArea";
            this.rdArea.Size = new System.Drawing.Size(47, 17);
            this.rdArea.TabIndex = 1;
            this.rdArea.TabStop = true;
            this.rdArea.Text = "Area";
            this.rdArea.UseVisualStyleBackColor = true;
            this.rdArea.CheckedChanged += new System.EventHandler(this.rdArea_CheckedChanged);
            // 
            // rdVolume
            // 
            this.rdVolume.AutoSize = true;
            this.rdVolume.Location = new System.Drawing.Point(11, 47);
            this.rdVolume.Name = "rdVolume";
            this.rdVolume.Size = new System.Drawing.Size(60, 17);
            this.rdVolume.TabIndex = 2;
            this.rdVolume.Text = "Volume";
            this.rdVolume.UseVisualStyleBackColor = true;
            this.rdVolume.CheckedChanged += new System.EventHandler(this.rdVolume_CheckedChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(140, 181);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 3;
            this.txtLength.Text = "0";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(74, 184);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(61, 13);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length ( ft):";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(74, 210);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(56, 13);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Width ( ft):";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(74, 236);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(62, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height ( ft): ";
            this.lblHeight.Visible = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(140, 207);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.Text = "0";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(140, 233);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 5;
            this.txtHeight.Text = "0";
            this.txtHeight.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(321, 181);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(88, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TabStop = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(262, 184);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(34, 13);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(77, 263);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(163, 35);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearInputs
            // 
            this.btnClearInputs.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClearInputs.ForeColor = System.Drawing.Color.White;
            this.btnClearInputs.Location = new System.Drawing.Point(246, 263);
            this.btnClearInputs.Name = "btnClearInputs";
            this.btnClearInputs.Size = new System.Drawing.Size(163, 35);
            this.btnClearInputs.TabIndex = 8;
            this.btnClearInputs.Text = "C&lear";
            this.btnClearInputs.UseVisualStyleBackColor = false;
            this.btnClearInputs.Click += new System.EventHandler(this.btnClearInputs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdAreaOfCircle);
            this.groupBox1.Controls.Add(this.txtDivBy);
            this.groupBox1.Controls.Add(this.rdVolume);
            this.groupBox1.Controls.Add(this.rdArea);
            this.groupBox1.Location = new System.Drawing.Point(77, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 70);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Calculation Type";
            // 
            // rdAreaOfCircle
            // 
            this.rdAreaOfCircle.AutoSize = true;
            this.rdAreaOfCircle.Location = new System.Drawing.Point(169, 20);
            this.rdAreaOfCircle.Name = "rdAreaOfCircle";
            this.rdAreaOfCircle.Size = new System.Drawing.Size(97, 17);
            this.rdAreaOfCircle.TabIndex = 3;
            this.rdAreaOfCircle.TabStop = true;
            this.rdAreaOfCircle.Text = "Area of a Circle";
            this.rdAreaOfCircle.UseVisualStyleBackColor = true;
            this.rdAreaOfCircle.CheckedChanged += new System.EventHandler(this.rdAreaOfCircle_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(162, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDivBy
            // 
            this.txtDivBy.Location = new System.Drawing.Point(255, 46);
            this.txtDivBy.Name = "txtDivBy";
            this.txtDivBy.Size = new System.Drawing.Size(46, 20);
            this.txtDivBy.TabIndex = 6;
            this.txtDivBy.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Div Len. by:";
            // 
            // txtDivTotal
            // 
            this.txtDivTotal.Location = new System.Drawing.Point(321, 207);
            this.txtDivTotal.Name = "txtDivTotal";
            this.txtDivTotal.ReadOnly = true;
            this.txtDivTotal.Size = new System.Drawing.Size(88, 20);
            this.txtDivTotal.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Div. Total:";
            // 
            // frmAreaVolCalc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(486, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDivTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearInputs);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblAreaVolCalc);
            this.Name = "frmAreaVolCalc";
            this.Text = "Area & Volume Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAreaVolCalc;
        private System.Windows.Forms.RadioButton rdArea;
        private System.Windows.Forms.RadioButton rdVolume;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearInputs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAreaOfCircle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDivBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDivTotal;
        private System.Windows.Forms.Label label2;
    }
}