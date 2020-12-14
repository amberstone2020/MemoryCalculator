namespace MemoryCalculator
{
    partial class frmCalculator
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
            this.txtCurrentValue = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnReciproc = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPosMin = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.pnlMemory = new System.Windows.Forms.Panel();
            this.lblMemory = new System.Windows.Forms.Label();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.pnlMemory.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurrentValue
            // 
            this.txtCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentValue.Location = new System.Drawing.Point(26, 22);
            this.txtCurrentValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrentValue.Multiline = true;
            this.txtCurrentValue.Name = "txtCurrentValue";
            this.txtCurrentValue.ReadOnly = true;
            this.txtCurrentValue.Size = new System.Drawing.Size(367, 42);
            this.txtCurrentValue.TabIndex = 0;
            this.txtCurrentValue.TabStop = false;
            this.txtCurrentValue.Text = "0";
            this.txtCurrentValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(89, 81);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 45);
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(214, 81);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 45);
            this.btnClear.TabIndex = 2;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn7.Location = new System.Drawing.Point(88, 145);
            this.btn7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(54, 40);
            this.btn7.TabIndex = 3;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn8.Location = new System.Drawing.Point(152, 145);
            this.btn8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(54, 40);
            this.btn8.TabIndex = 4;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn9.Location = new System.Drawing.Point(214, 145);
            this.btn9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(54, 40);
            this.btn9.TabIndex = 5;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(278, 145);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(54, 40);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn4.Location = new System.Drawing.Point(88, 194);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(54, 40);
            this.btn4.TabIndex = 7;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn5.Location = new System.Drawing.Point(152, 194);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(54, 40);
            this.btn5.TabIndex = 8;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn6.Location = new System.Drawing.Point(214, 194);
            this.btn6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(54, 40);
            this.btn6.TabIndex = 9;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMultiply.ForeColor = System.Drawing.Color.Red;
            this.btnMultiply.Location = new System.Drawing.Point(278, 194);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(54, 40);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn1.Location = new System.Drawing.Point(88, 243);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(54, 40);
            this.btn1.TabIndex = 11;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn2.Location = new System.Drawing.Point(152, 243);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(54, 40);
            this.btn2.TabIndex = 12;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn3.Location = new System.Drawing.Point(214, 243);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(54, 40);
            this.btn3.TabIndex = 13;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMinus.ForeColor = System.Drawing.Color.Red;
            this.btnMinus.Location = new System.Drawing.Point(278, 243);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(54, 40);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.TabStop = false;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn0.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn0.Location = new System.Drawing.Point(88, 292);
            this.btn0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(54, 40);
            this.btn0.TabIndex = 15;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPlus.ForeColor = System.Drawing.Color.Red;
            this.btnPlus.Location = new System.Drawing.Point(278, 292);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(54, 40);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.TabStop = false;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSqrt.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSqrt.Location = new System.Drawing.Point(340, 145);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(54, 40);
            this.btnSqrt.TabIndex = 17;
            this.btnSqrt.TabStop = false;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // btnReciproc
            // 
            this.btnReciproc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReciproc.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReciproc.Location = new System.Drawing.Point(340, 194);
            this.btnReciproc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReciproc.Name = "btnReciproc";
            this.btnReciproc.Size = new System.Drawing.Size(54, 40);
            this.btnReciproc.TabIndex = 18;
            this.btnReciproc.TabStop = false;
            this.btnReciproc.Text = "1/X";
            this.btnReciproc.UseVisualStyleBackColor = true;
            this.btnReciproc.Click += new System.EventHandler(this.BtnReciproc_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEqual.ForeColor = System.Drawing.Color.Red;
            this.btnEqual.Location = new System.Drawing.Point(340, 243);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(54, 89);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.TabStop = false;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // btnPosMin
            // 
            this.btnPosMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPosMin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPosMin.Location = new System.Drawing.Point(152, 292);
            this.btnPosMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPosMin.Name = "btnPosMin";
            this.btnPosMin.Size = new System.Drawing.Size(54, 40);
            this.btnPosMin.TabIndex = 20;
            this.btnPosMin.TabStop = false;
            this.btnPosMin.Text = "+/-";
            this.btnPosMin.UseVisualStyleBackColor = true;
            this.btnPosMin.Click += new System.EventHandler(this.BtnPosMin_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPeriod.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPeriod.Location = new System.Drawing.Point(214, 292);
            this.btnPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(54, 40);
            this.btnPeriod.TabIndex = 21;
            this.btnPeriod.TabStop = false;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.BtnPeriod_Click);
            // 
            // pnlMemory
            // 
            this.pnlMemory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMemory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMemory.Controls.Add(this.lblMemory);
            this.pnlMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pnlMemory.Location = new System.Drawing.Point(26, 82);
            this.pnlMemory.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMemory.Name = "pnlMemory";
            this.pnlMemory.Size = new System.Drawing.Size(54, 44);
            this.pnlMemory.TabIndex = 22;
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(12, 5);
            this.lblMemory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(0, 25);
            this.lblMemory.TabIndex = 27;
            // 
            // btnMC
            // 
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMC.ForeColor = System.Drawing.Color.Red;
            this.btnMC.Location = new System.Drawing.Point(26, 145);
            this.btnMC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(54, 40);
            this.btnMC.TabIndex = 23;
            this.btnMC.TabStop = false;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.BtnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMR.ForeColor = System.Drawing.Color.Red;
            this.btnMR.Location = new System.Drawing.Point(26, 194);
            this.btnMR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(54, 40);
            this.btnMR.TabIndex = 24;
            this.btnMR.TabStop = false;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.BtnMR_Click);
            // 
            // btnMS
            // 
            this.btnMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMS.ForeColor = System.Drawing.Color.Red;
            this.btnMS.Location = new System.Drawing.Point(26, 243);
            this.btnMS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(54, 40);
            this.btnMS.TabIndex = 25;
            this.btnMS.TabStop = false;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.BtnMS_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMPlus.ForeColor = System.Drawing.Color.Red;
            this.btnMPlus.Location = new System.Drawing.Point(26, 292);
            this.btnMPlus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(54, 40);
            this.btnMPlus.TabIndex = 26;
            this.btnMPlus.TabStop = false;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.BtnMPlus_Click);
            // 
            // frmCalculator
            // 
            this.AcceptButton = this.btnEqual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(413, 360);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.pnlMemory);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.btnPosMin);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnReciproc);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCurrentValue);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.pnlMemory.ResumeLayout(false);
            this.pnlMemory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentValue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnReciproc;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPosMin;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Panel pnlMemory;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Label lblMemory;
    }
}
