namespace Rock_Paper_Scissors
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.piccpu = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.Label();
            this.txtCountDown = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccpu)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRockClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Paper";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnpaperclick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Scissors";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnscissorsclick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(452, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Restart";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Restartbutton);
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::Rock_Paper_Scissors.Properties.Resources.qq;
            this.picPlayer.Location = new System.Drawing.Point(93, 40);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(190, 192);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 4;
            this.picPlayer.TabStop = false;
            this.picPlayer.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // piccpu
            // 
            this.piccpu.Image = global::Rock_Paper_Scissors.Properties.Resources.qq;
            this.piccpu.Location = new System.Drawing.Point(337, 40);
            this.piccpu.Name = "piccpu";
            this.piccpu.Size = new System.Drawing.Size(190, 192);
            this.piccpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccpu.TabIndex = 5;
            this.piccpu.TabStop = false;
            this.piccpu.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(159, 12);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(124, 25);
            this.txtScore.TabIndex = 6;
            this.txtScore.Text = "Player:0 AI:0";
            this.txtScore.Click += new System.EventHandler(this.asd);
            // 
            // txtRound
            // 
            this.txtRound.AutoSize = true;
            this.txtRound.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRound.Location = new System.Drawing.Point(332, 12);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(88, 25);
            this.txtRound.TabIndex = 7;
            this.txtRound.Text = "Round:3";
            // 
            // txtCountDown
            // 
            this.txtCountDown.AutoSize = true;
            this.txtCountDown.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountDown.Location = new System.Drawing.Point(504, 9);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.Size = new System.Drawing.Size(23, 25);
            this.txtCountDown.TabIndex = 8;
            this.txtCountDown.Text = "5";
            this.txtCountDown.Click += new System.EventHandler(this.txtCountDown_Click);
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.CountDownTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 293);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.piccpu);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox piccpu;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtRound;
        private System.Windows.Forms.Label txtCountDown;
        private System.Windows.Forms.Timer countDownTimer;
    }
}

