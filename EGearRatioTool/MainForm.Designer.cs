
namespace EGearRatioToor
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PUUTxtbox = new System.Windows.Forms.TextBox();
            this.ReductionRatioTxtbox1 = new System.Windows.Forms.TextBox();
            this.ScrewPitchTxtbox = new System.Windows.Forms.TextBox();
            this.EncoderPLSTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxRPMTxtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NumTxtbox = new System.Windows.Forms.TextBox();
            this.DenTxtbox = new System.Windows.Forms.TextBox();
            this.OneSecondMovementTxtbox = new System.Windows.Forms.TextBox();
            this.GoBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ReductionRatioTxtbox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.distPerRevTxtbox = new System.Windows.Forms.TextBox();
            this.puuPerRevTxtbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "每 mm 有多少使用者單位 (Units/mm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "減速比 (Reduction Ratio)\r\n(負載側 Load / 馬達側 Motor)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "螺桿導程 (Screw Picth) in millimeter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 24);
            this.label4.TabIndex = 99;
            this.label4.Text = "Servo最高轉速 (Max Servo speed) RPM";
            // 
            // PUUTxtbox
            // 
            this.PUUTxtbox.Location = new System.Drawing.Point(341, 12);
            this.PUUTxtbox.Name = "PUUTxtbox";
            this.PUUTxtbox.Size = new System.Drawing.Size(132, 31);
            this.PUUTxtbox.TabIndex = 4;
            // 
            // ReductionRatioTxtbox1
            // 
            this.ReductionRatioTxtbox1.Location = new System.Drawing.Point(341, 63);
            this.ReductionRatioTxtbox1.Name = "ReductionRatioTxtbox1";
            this.ReductionRatioTxtbox1.Size = new System.Drawing.Size(48, 31);
            this.ReductionRatioTxtbox1.TabIndex = 5;
            // 
            // ScrewPitchTxtbox
            // 
            this.ScrewPitchTxtbox.Location = new System.Drawing.Point(341, 109);
            this.ScrewPitchTxtbox.Name = "ScrewPitchTxtbox";
            this.ScrewPitchTxtbox.Size = new System.Drawing.Size(132, 31);
            this.ScrewPitchTxtbox.TabIndex = 7;
            // 
            // EncoderPLSTxtbox
            // 
            this.EncoderPLSTxtbox.Location = new System.Drawing.Point(341, 149);
            this.EncoderPLSTxtbox.Name = "EncoderPLSTxtbox";
            this.EncoderPLSTxtbox.Size = new System.Drawing.Size(132, 31);
            this.EncoderPLSTxtbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 24);
            this.label5.TabIndex = 99;
            this.label5.Text = "電子齒輪比 - 分子 (NUM)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 99;
            this.label6.Text = "電子齒輪比 - 分母 (DEN)";
            // 
            // MaxRPMTxtbox
            // 
            this.MaxRPMTxtbox.Location = new System.Drawing.Point(341, 187);
            this.MaxRPMTxtbox.Name = "MaxRPMTxtbox";
            this.MaxRPMTxtbox.Size = new System.Drawing.Size(132, 31);
            this.MaxRPMTxtbox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 24);
            this.label8.TabIndex = 99;
            this.label8.Text = "編碼器每圈的脈衝數 (Encoder PLS/rev)";
            // 
            // NumTxtbox
            // 
            this.NumTxtbox.BackColor = System.Drawing.Color.Gold;
            this.NumTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumTxtbox.Location = new System.Drawing.Point(329, 39);
            this.NumTxtbox.Name = "NumTxtbox";
            this.NumTxtbox.Size = new System.Drawing.Size(132, 24);
            this.NumTxtbox.TabIndex = 13;
            this.NumTxtbox.TabStop = false;
            // 
            // DenTxtbox
            // 
            this.DenTxtbox.BackColor = System.Drawing.Color.Gold;
            this.DenTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DenTxtbox.Location = new System.Drawing.Point(329, 79);
            this.DenTxtbox.Name = "DenTxtbox";
            this.DenTxtbox.Size = new System.Drawing.Size(132, 24);
            this.DenTxtbox.TabIndex = 14;
            this.DenTxtbox.TabStop = false;
            // 
            // OneSecondMovementTxtbox
            // 
            this.OneSecondMovementTxtbox.BackColor = System.Drawing.Color.Gold;
            this.OneSecondMovementTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OneSecondMovementTxtbox.Location = new System.Drawing.Point(329, 130);
            this.OneSecondMovementTxtbox.Name = "OneSecondMovementTxtbox";
            this.OneSecondMovementTxtbox.Size = new System.Drawing.Size(132, 24);
            this.OneSecondMovementTxtbox.TabIndex = 15;
            this.OneSecondMovementTxtbox.TabStop = false;
            // 
            // GoBtn
            // 
            this.GoBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.GoBtn.Location = new System.Drawing.Point(12, 483);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(475, 46);
            this.GoBtn.TabIndex = 10;
            this.GoBtn.Text = "G O";
            this.GoBtn.UseVisualStyleBackColor = false;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 24);
            this.label9.TabIndex = 17;
            // 
            // ReductionRatioTxtbox2
            // 
            this.ReductionRatioTxtbox2.Location = new System.Drawing.Point(426, 63);
            this.ReductionRatioTxtbox2.Name = "ReductionRatioTxtbox2";
            this.ReductionRatioTxtbox2.Size = new System.Drawing.Size(47, 31);
            this.ReductionRatioTxtbox2.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "/";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(27, 469);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 24);
            this.errorLabel.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 24);
            this.label11.TabIndex = 100;
            this.label11.Text = "馬達每圈移動量 (Distance/rev)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // distPerRevTxtbox
            // 
            this.distPerRevTxtbox.BackColor = System.Drawing.Color.Gold;
            this.distPerRevTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.distPerRevTxtbox.Location = new System.Drawing.Point(329, 175);
            this.distPerRevTxtbox.Name = "distPerRevTxtbox";
            this.distPerRevTxtbox.Size = new System.Drawing.Size(132, 24);
            this.distPerRevTxtbox.TabIndex = 101;
            this.distPerRevTxtbox.TabStop = false;
            // 
            // puuPerRevTxtbox
            // 
            this.puuPerRevTxtbox.BackColor = System.Drawing.Color.Gold;
            this.puuPerRevTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.puuPerRevTxtbox.Location = new System.Drawing.Point(329, 215);
            this.puuPerRevTxtbox.Name = "puuPerRevTxtbox";
            this.puuPerRevTxtbox.Size = new System.Drawing.Size(132, 24);
            this.puuPerRevTxtbox.TabIndex = 103;
            this.puuPerRevTxtbox.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 24);
            this.label12.TabIndex = 102;
            this.label12.Text = "馬達每圈的移動單位 (Unit/rev)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.puuPerRevTxtbox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.distPerRevTxtbox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.OneSecondMovementTxtbox);
            this.groupBox1.Controls.Add(this.DenTxtbox);
            this.groupBox1.Controls.Add(this.NumTxtbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 247);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "計算輸出 (Output)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 48);
            this.label7.TabIndex = 104;
            this.label7.Text = "最快1秒移動量，加減速均採0.2秒計算 \r\n(Max movement in 1s., 0.2s acc / decel.)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(504, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ReductionRatioTxtbox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MaxRPMTxtbox);
            this.Controls.Add(this.EncoderPLSTxtbox);
            this.Controls.Add(this.ScrewPitchTxtbox);
            this.Controls.Add(this.ReductionRatioTxtbox1);
            this.Controls.Add(this.PUUTxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 580);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 580);
            this.Name = "MainForm";
            this.Text = "eGearRatioTool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PUUTxtbox;
        private System.Windows.Forms.TextBox ReductionRatioTxtbox1;
        private System.Windows.Forms.TextBox ScrewPitchTxtbox;
        private System.Windows.Forms.TextBox EncoderPLSTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaxRPMTxtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NumTxtbox;
        private System.Windows.Forms.TextBox DenTxtbox;
        private System.Windows.Forms.TextBox OneSecondMovementTxtbox;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ReductionRatioTxtbox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox distPerRevTxtbox;
        private System.Windows.Forms.TextBox puuPerRevTxtbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
    }
}

