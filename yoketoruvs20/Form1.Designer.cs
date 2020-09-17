namespace yoketoruvs20
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Timelabel = new System.Windows.Forms.Label();
            this.Itemlabel = new System.Windows.Forms.Label();
            this.Hilabel = new System.Windows.Forms.Label();
            this.Gameoverlabel = new System.Windows.Forms.Label();
            this.Clearlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Titlebutton = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Titlelabel.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 70F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Green;
            this.Titlelabel.Location = new System.Drawing.Point(107, 113);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(618, 94);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "よけとる2020";
            this.Titlelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Startbutton.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Startbutton.ForeColor = System.Drawing.Color.Black;
            this.Startbutton.Location = new System.Drawing.Point(206, 292);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(395, 103);
            this.Startbutton.TabIndex = 3;
            this.Startbutton.Text = "スタート!!!";
            this.Startbutton.UseVisualStyleBackColor = false;
            this.Startbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("HGP創英角ｺﾞｼｯｸUB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Timelabel.Location = new System.Drawing.Point(12, 9);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(243, 53);
            this.Timelabel.TabIndex = 4;
            this.Timelabel.Text = "Time:100";
            this.Timelabel.Click += new System.EventHandler(this.Timelabel_Click);
            // 
            // Itemlabel
            // 
            this.Itemlabel.AutoSize = true;
            this.Itemlabel.Font = new System.Drawing.Font("HGP創英角ｺﾞｼｯｸUB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Itemlabel.Location = new System.Drawing.Point(656, 9);
            this.Itemlabel.Name = "Itemlabel";
            this.Itemlabel.Size = new System.Drawing.Size(154, 53);
            this.Itemlabel.TabIndex = 5;
            this.Itemlabel.Text = "★:10";
            this.Itemlabel.Click += new System.EventHandler(this.Itemlabel_Click);
            // 
            // Hilabel
            // 
            this.Hilabel.AutoSize = true;
            this.Hilabel.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Hilabel.Location = new System.Drawing.Point(269, 240);
            this.Hilabel.Name = "Hilabel";
            this.Hilabel.Size = new System.Drawing.Size(255, 40);
            this.Hilabel.TabIndex = 6;
            this.Hilabel.Text = "HighScore:100";
            // 
            // Gameoverlabel
            // 
            this.Gameoverlabel.AutoSize = true;
            this.Gameoverlabel.Font = new System.Drawing.Font("Showcard Gothic", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gameoverlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Gameoverlabel.Location = new System.Drawing.Point(156, 113);
            this.Gameoverlabel.Name = "Gameoverlabel";
            this.Gameoverlabel.Size = new System.Drawing.Size(538, 114);
            this.Gameoverlabel.TabIndex = 7;
            this.Gameoverlabel.Text = "Gameover";
            // 
            // Clearlabel
            // 
            this.Clearlabel.AutoSize = true;
            this.Clearlabel.Font = new System.Drawing.Font("Showcard Gothic", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Clearlabel.Location = new System.Drawing.Point(257, 113);
            this.Clearlabel.Name = "Clearlabel";
            this.Clearlabel.Size = new System.Drawing.Size(325, 114);
            this.Clearlabel.TabIndex = 8;
            this.Clearlabel.Text = "Clear";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Titlebutton
            // 
            this.Titlebutton.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titlebutton.Location = new System.Drawing.Point(206, 292);
            this.Titlebutton.Name = "Titlebutton";
            this.Titlebutton.Size = new System.Drawing.Size(395, 103);
            this.Titlebutton.TabIndex = 9;
            this.Titlebutton.Text = "タイトルへ";
            this.Titlebutton.UseVisualStyleBackColor = true;
            this.Titlebutton.Click += new System.EventHandler(this.Titlebutton_Click);
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Copyright.Location = new System.Drawing.Point(259, 426);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(302, 27);
            this.Copyright.TabIndex = 10;
            this.Copyright.Text = "Copyright©2020齊藤巧真";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 471);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.Titlebutton);
            this.Controls.Add(this.Clearlabel);
            this.Controls.Add(this.Gameoverlabel);
            this.Controls.Add(this.Hilabel);
            this.Controls.Add(this.Itemlabel);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.Titlelabel);
            this.Name = "Form1";
            this.Text = "よけとる2020";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Label Itemlabel;
        private System.Windows.Forms.Label Hilabel;
        private System.Windows.Forms.Label Gameoverlabel;
        private System.Windows.Forms.Label Clearlabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Titlebutton;
        private System.Windows.Forms.Label Copyright;
    }
}

