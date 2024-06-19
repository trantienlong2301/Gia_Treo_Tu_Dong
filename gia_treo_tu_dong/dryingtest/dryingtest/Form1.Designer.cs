namespace dryingtest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.nut0 = new System.Windows.Forms.Button();
            this.nut45 = new System.Windows.Forms.Button();
            this.nut90 = new System.Windows.Forms.Button();
            this.nut135 = new System.Windows.Forms.Button();
            this.nut180 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trangthai = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tudong = new System.Windows.Forms.Button();
            this.thucong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drying Rack System";
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.connect.Location = new System.Drawing.Point(674, 357);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(108, 47);
            this.connect.TabIndex = 1;
            this.connect.Text = "Connect Port";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(674, 421);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(108, 43);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // nut0
            // 
            this.nut0.BackColor = System.Drawing.Color.Salmon;
            this.nut0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nut0.Location = new System.Drawing.Point(416, 122);
            this.nut0.Name = "nut0";
            this.nut0.Size = new System.Drawing.Size(117, 78);
            this.nut0.TabIndex = 3;
            this.nut0.Text = "Thu quần áo";
            this.nut0.UseVisualStyleBackColor = false;
            this.nut0.Click += new System.EventHandler(this.nut0_Click);
            // 
            // nut45
            // 
            this.nut45.Location = new System.Drawing.Point(686, 262);
            this.nut45.Name = "nut45";
            this.nut45.Size = new System.Drawing.Size(87, 58);
            this.nut45.TabIndex = 4;
            this.nut45.Text = "45";
            this.nut45.UseVisualStyleBackColor = true;
            this.nut45.Click += new System.EventHandler(this.nut45_Click);
            // 
            // nut90
            // 
            this.nut90.Location = new System.Drawing.Point(593, 202);
            this.nut90.Name = "nut90";
            this.nut90.Size = new System.Drawing.Size(87, 58);
            this.nut90.TabIndex = 5;
            this.nut90.Text = "90";
            this.nut90.UseVisualStyleBackColor = true;
            this.nut90.Click += new System.EventHandler(this.nut90_Click);
            // 
            // nut135
            // 
            this.nut135.Location = new System.Drawing.Point(779, 202);
            this.nut135.Name = "nut135";
            this.nut135.Size = new System.Drawing.Size(87, 58);
            this.nut135.TabIndex = 6;
            this.nut135.Text = "135";
            this.nut135.UseVisualStyleBackColor = true;
            this.nut135.Click += new System.EventHandler(this.nut135_Click);
            // 
            // nut180
            // 
            this.nut180.Location = new System.Drawing.Point(686, 142);
            this.nut180.Name = "nut180";
            this.nut180.Size = new System.Drawing.Size(87, 58);
            this.nut180.TabIndex = 7;
            this.nut180.Text = "180";
            this.nut180.UseVisualStyleBackColor = true;
            this.nut180.Click += new System.EventHandler(this.nut180_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(688, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vị trí";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // trangthai
            // 
            this.trangthai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangthai.ForeColor = System.Drawing.Color.Black;
            this.trangthai.Location = new System.Drawing.Point(416, 234);
            this.trangthai.Name = "trangthai";
            this.trangthai.Size = new System.Drawing.Size(117, 56);
            this.trangthai.TabIndex = 10;
            this.trangthai.Text = "Đã thu";
            this.trangthai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trangthai.Click += new System.EventHandler(this.trangthai_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(807, 392);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 100);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nguyễn Quang Huy 20210438\r\nTrần Tiến Long 20216176\r\nNguyễn Tuấn Anh 20216041\r\n\r\n";
            // 
            // tudong
            // 
            this.tudong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tudong.Location = new System.Drawing.Point(87, 200);
            this.tudong.Name = "tudong";
            this.tudong.Size = new System.Drawing.Size(120, 56);
            this.tudong.TabIndex = 18;
            this.tudong.Text = "Tự động";
            this.tudong.UseVisualStyleBackColor = true;
            this.tudong.Click += new System.EventHandler(this.tudong_Click);
            // 
            // thucong
            // 
            this.thucong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thucong.Location = new System.Drawing.Point(213, 200);
            this.thucong.Name = "thucong";
            this.thucong.Size = new System.Drawing.Size(124, 56);
            this.thucong.TabIndex = 19;
            this.thucong.Text = "Thủ công";
            this.thucong.UseVisualStyleBackColor = true;
            this.thucong.Click += new System.EventHandler(this.thucong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 38);
            this.label5.TabIndex = 20;
            this.label5.Text = "Chế độ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 487);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.thucong);
            this.Controls.Add(this.tudong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trangthai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nut180);
            this.Controls.Add(this.nut135);
            this.Controls.Add(this.nut90);
            this.Controls.Add(this.nut45);
            this.Controls.Add(this.nut0);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button exit;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button nut0;
        private System.Windows.Forms.Button nut45;
        private System.Windows.Forms.Button nut90;
        private System.Windows.Forms.Button nut135;
        private System.Windows.Forms.Button nut180;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label trangthai;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tudong;
        private System.Windows.Forms.Button thucong;
        private System.Windows.Forms.Label label5;
    }
}

