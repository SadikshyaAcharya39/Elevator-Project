namespace Project1_Elevator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            pictureBox6 = new PictureBox();
            Stop = new Button();
            floor_G = new Button();
            floor_1 = new Button();
            groupBox2 = new GroupBox();
            Stop_1 = new Button();
            close = new Button();
            open = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            timer6 = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            button5 = new Button();
            timer7 = new System.Windows.Forms.Timer(components);
            timer8 = new System.Windows.Forms.Timer(components);
            timer10 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(Stop);
            groupBox1.Controls.Add(floor_G);
            groupBox1.Controls.Add(floor_1);
            groupBox1.Location = new Point(566, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(145, 244);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Floors";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.ruga;
            pictureBox6.Location = new Point(31, 162);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(83, 62);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // Stop
            // 
            Stop.Location = new Point(18, 107);
            Stop.Name = "Stop";
            Stop.Size = new Size(94, 29);
            Stop.TabIndex = 2;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // floor_G
            // 
            floor_G.Location = new Point(18, 72);
            floor_G.Name = "floor_G";
            floor_G.Size = new Size(94, 29);
            floor_G.TabIndex = 1;
            floor_G.Text = "G";
            floor_G.UseVisualStyleBackColor = true;
            floor_G.Click += floor_G_Click;
            // 
            // floor_1
            // 
            floor_1.Location = new Point(18, 37);
            floor_1.Name = "floor_1";
            floor_1.Size = new Size(94, 29);
            floor_1.TabIndex = 0;
            floor_1.Text = "1 ";
            floor_1.UseVisualStyleBackColor = true;
            floor_1.Click += floor_1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Stop_1);
            groupBox2.Controls.Add(close);
            groupBox2.Controls.Add(open);
            groupBox2.Location = new Point(566, 537);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(145, 152);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Events";
            // 
            // Stop_1
            // 
            Stop_1.Location = new Point(18, 109);
            Stop_1.Name = "Stop_1";
            Stop_1.Size = new Size(94, 29);
            Stop_1.TabIndex = 2;
            Stop_1.Text = "Stop";
            Stop_1.UseVisualStyleBackColor = true;
            Stop_1.Click += Stop_1_Click;
            // 
            // close
            // 
            close.Location = new Point(18, 74);
            close.Name = "close";
            close.Size = new Size(94, 29);
            close.TabIndex = 1;
            close.Text = "Close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // open
            // 
            open.Location = new Point(18, 39);
            open.Name = "open";
            open.Size = new Size(94, 29);
            open.TabIndex = 0;
            open.Text = "Open";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gray_image;
            pictureBox1.Location = new Point(94, 537);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.gray_image;
            pictureBox2.Location = new Point(239, 537);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 288);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick_1;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick_1;
            // 
            // button2
            // 
            button2.Location = new Point(896, 856);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 6;
            button2.Text = "Display Events";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1247, 856);
            button3.Name = "button3";
            button3.Size = new Size(122, 29);
            button3.TabIndex = 7;
            button3.Text = "Clear Events";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(806, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1025, 782);
            dataGridView1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Image = Properties.Resources.lift_transparent;
            pictureBox3.Location = new Point(94, 537);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(284, 288);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.gray_image;
            pictureBox4.Location = new Point(94, 108);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(139, 288);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.gray_image;
            pictureBox5.Location = new Point(239, 108);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(139, 288);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // timer5
            // 
            timer5.Tick += timer5_Tick;
            // 
            // timer6
            // 
            timer6.Tick += timer6_Tick;
            // 
            // button4
            // 
            button4.Location = new Point(1576, 856);
            button4.Name = "button4";
            button4.Size = new Size(137, 29);
            button4.TabIndex = 10;
            button4.Text = "Delete Events";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(410, 259);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Up Call";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(410, 699);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 12;
            button5.Text = "Down Call";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // timer7
            // 
            timer7.Tick += timer7_Tick;
            // 
            // timer8
            // 
            timer8.Tick += timer8_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1872, 1022);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button floor_G;
        private Button floor_1;
        private GroupBox groupBox2;
        private Button open;
        private Button close;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Button Stop;
        private Button Stop_1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button5;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.Timer timer10;
        private PictureBox pictureBox6;
    }
}