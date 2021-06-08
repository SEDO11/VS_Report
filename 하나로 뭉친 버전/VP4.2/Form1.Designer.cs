
namespace VP4._2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelct = new System.Windows.Forms.Button();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laber3 = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMemo = new System.Windows.Forms.ListBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPeople = new System.Windows.Forms.TextBox();
            this.btnMemo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFmale = new System.Windows.Forms.CheckBox();
            this.rdoMale = new System.Windows.Forms.CheckBox();
            this.gbCon = new System.Windows.Forms.GroupBox();
            this.rdoDisabled = new System.Windows.Forms.CheckBox();
            this.rdoTeenager = new System.Windows.Forms.CheckBox();
            this.rdoAdult = new System.Windows.Forms.CheckBox();
            this.tbSeat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelct
            // 
            this.btnSelct.Location = new System.Drawing.Point(315, 295);
            this.btnSelct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelct.Name = "btnSelct";
            this.btnSelct.Size = new System.Drawing.Size(108, 40);
            this.btnSelct.TabIndex = 19;
            this.btnSelct.Text = "영화 선택";
            this.btnSelct.UseVisualStyleBackColor = true;
            this.btnSelct.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDir
            // 
            this.lblDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDir.Location = new System.Drawing.Point(639, 36);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(334, 24);
            this.lblDir.TabIndex = 18;
            // 
            // lblActor
            // 
            this.lblActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblActor.Location = new System.Drawing.Point(597, 108);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(376, 24);
            this.lblActor.TabIndex = 17;
            // 
            // lblExp
            // 
            this.lblExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblExp.Location = new System.Drawing.Point(597, 175);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(376, 253);
            this.lblExp.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "영화 내용:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "주연 배우:";
            // 
            // laber3
            // 
            this.laber3.AutoSize = true;
            this.laber3.Location = new System.Drawing.Point(597, 43);
            this.laber3.Name = "laber3";
            this.laber3.Size = new System.Drawing.Size(33, 12);
            this.laber3.TabIndex = 13;
            this.laber3.Text = "감독:";
            // 
            // lblMovieName
            // 
            this.lblMovieName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMovieName.Location = new System.Drawing.Point(315, 366);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(227, 62);
            this.lblMovieName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "제목:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbMemo
            // 
            this.lbMemo.AccessibleName = "";
            this.lbMemo.FormattingEnabled = true;
            this.lbMemo.ItemHeight = 12;
            this.lbMemo.Location = new System.Drawing.Point(1037, 226);
            this.lbMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(293, 196);
            this.lbMemo.TabIndex = 21;
            this.lbMemo.SelectedIndexChanged += new System.EventHandler(this.lbMemo_SelectedIndexChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(429, 295);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 40);
            this.btnCheck.TabIndex = 22;
            this.btnCheck.Text = "확인";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20F);
            this.label2.Location = new System.Drawing.Point(1032, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "예매";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1034, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "보는 인원:";
            // 
            // tbPeople
            // 
            this.tbPeople.Location = new System.Drawing.Point(1131, 127);
            this.tbPeople.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPeople.Name = "tbPeople";
            this.tbPeople.Size = new System.Drawing.Size(198, 21);
            this.tbPeople.TabIndex = 27;
            // 
            // btnMemo
            // 
            this.btnMemo.Location = new System.Drawing.Point(1236, 175);
            this.btnMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMemo.Name = "btnMemo";
            this.btnMemo.Size = new System.Drawing.Size(93, 33);
            this.btnMemo.TabIndex = 28;
            this.btnMemo.Text = "예매하기";
            this.btnMemo.UseVisualStyleBackColor = true;
            this.btnMemo.Click += new System.EventHandler(this.btnMemo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rdoFmale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Location = new System.Drawing.Point(65, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(171, 112);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성별";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoFmale
            // 
            this.rdoFmale.AutoSize = true;
            this.rdoFmale.Location = new System.Drawing.Point(17, 66);
            this.rdoFmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoFmale.Name = "rdoFmale";
            this.rdoFmale.Size = new System.Drawing.Size(48, 16);
            this.rdoFmale.TabIndex = 1;
            this.rdoFmale.Text = "여성";
            this.rdoFmale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(17, 33);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 16);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.Text = "남성";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // gbCon
            // 
            this.gbCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbCon.Controls.Add(this.rdoDisabled);
            this.gbCon.Controls.Add(this.rdoTeenager);
            this.gbCon.Controls.Add(this.rdoAdult);
            this.gbCon.Location = new System.Drawing.Point(65, 240);
            this.gbCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCon.Name = "gbCon";
            this.gbCon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCon.Size = new System.Drawing.Size(171, 112);
            this.gbCon.TabIndex = 33;
            this.gbCon.TabStop = false;
            this.gbCon.Text = "연령 선택";
            this.gbCon.Enter += new System.EventHandler(this.gbCon_Enter);
            // 
            // rdoDisabled
            // 
            this.rdoDisabled.AutoSize = true;
            this.rdoDisabled.Location = new System.Drawing.Point(17, 70);
            this.rdoDisabled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoDisabled.Name = "rdoDisabled";
            this.rdoDisabled.Size = new System.Drawing.Size(94, 16);
            this.rdoDisabled.TabIndex = 3;
            this.rdoDisabled.Text = "장애인(우대)";
            this.rdoDisabled.UseVisualStyleBackColor = true;
            // 
            // rdoTeenager
            // 
            this.rdoTeenager.AutoSize = true;
            this.rdoTeenager.Location = new System.Drawing.Point(17, 50);
            this.rdoTeenager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoTeenager.Name = "rdoTeenager";
            this.rdoTeenager.Size = new System.Drawing.Size(60, 16);
            this.rdoTeenager.TabIndex = 2;
            this.rdoTeenager.Text = "청소년";
            this.rdoTeenager.UseVisualStyleBackColor = true;
            // 
            // rdoAdult
            // 
            this.rdoAdult.AutoSize = true;
            this.rdoAdult.Location = new System.Drawing.Point(17, 30);
            this.rdoAdult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoAdult.Name = "rdoAdult";
            this.rdoAdult.Size = new System.Drawing.Size(48, 16);
            this.rdoAdult.TabIndex = 1;
            this.rdoAdult.Text = "성인";
            this.rdoAdult.UseVisualStyleBackColor = true;
            // 
            // tbSeat
            // 
            this.tbSeat.Location = new System.Drawing.Point(1131, 83);
            this.tbSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSeat.Name = "tbSeat";
            this.tbSeat.Size = new System.Drawing.Size(198, 21);
            this.tbSeat.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1034, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 12);
            this.label7.TabIndex = 34;
            this.label7.Text = "자리:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 20F);
            this.label5.Location = new System.Drawing.Point(10, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 27);
            this.label5.TabIndex = 36;
            this.label5.Text = "이용자 및 영화 선택";
            // 
            // pbPoster
            // 
            this.pbPoster.Image = global::VP4._2.Properties.Resources._6;
            this.pbPoster.Location = new System.Drawing.Point(315, 36);
            this.pbPoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(226, 243);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoster.TabIndex = 20;
            this.pbPoster.TabStop = false;
            this.pbPoster.Click += new System.EventHandler(this.pbPoster_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 15F);
            this.label8.Location = new System.Drawing.Point(1037, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "예매 내역";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 459);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSeat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbCon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMemo);
            this.Controls.Add(this.tbPeople);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbMemo);
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.btnSelct);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblActor);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.laber3);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "CGV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCon.ResumeLayout(false);
            this.gbCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Button btnSelct;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laber3;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMemo;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPeople;
        private System.Windows.Forms.Button btnMemo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rdoFmale;
        private System.Windows.Forms.CheckBox rdoMale;
        private System.Windows.Forms.GroupBox gbCon;
        private System.Windows.Forms.CheckBox rdoDisabled;
        private System.Windows.Forms.CheckBox rdoTeenager;
        private System.Windows.Forms.CheckBox rdoAdult;
        private System.Windows.Forms.TextBox tbSeat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}

