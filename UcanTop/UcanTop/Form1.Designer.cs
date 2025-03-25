namespace UcanTop
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
            duvarSol = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            duvarUst = new Label();
            duvarSag = new Label();
            label7 = new Label();
            button1 = new Button();
            engel = new Button();
            top = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // duvarSol
            // 
            duvarSol.BackColor = Color.Black;
            duvarSol.Location = new Point(-8, 0);
            duvarSol.Name = "duvarSol";
            duvarSol.Size = new Size(28, 340);
            duvarSol.TabIndex = 0;
            duvarSol.Text = "asd";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(709, 21);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Süre(sn):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(709, 58);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Kalan Hak: 5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(709, 89);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 3;
            label4.Text = "Kurtarma Sayısı: 0";
            // 
            // duvarUst
            // 
            duvarUst.BackColor = Color.Black;
            duvarUst.Location = new Point(12, 0);
            duvarUst.Name = "duvarUst";
            duvarUst.Size = new Size(666, 19);
            duvarUst.TabIndex = 4;
            duvarUst.Text = "asd";
            // 
            // duvarSag
            // 
            duvarSag.BackColor = Color.Black;
            duvarSag.Location = new Point(674, 0);
            duvarSag.Name = "duvarSag";
            duvarSag.Size = new Size(17, 340);
            duvarSag.TabIndex = 5;
            duvarSag.Text = "asd";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(773, 21);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 6;
            label7.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(706, 131);
            button1.Name = "button1";
            button1.Size = new Size(145, 28);
            button1.TabIndex = 7;
            button1.Text = "Başla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // engel
            // 
            engel.BackColor = Color.Black;
            engel.FlatStyle = FlatStyle.Flat;
            engel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            engel.Location = new Point(289, 359);
            engel.Name = "engel";
            engel.Size = new Size(89, 17);
            engel.TabIndex = 8;
            engel.UseVisualStyleBackColor = false;
            engel.MouseMove += button2_MouseMove;
            // 
            // top
            // 
            top.BackColor = Color.DeepSkyBlue;
            top.FlatAppearance.BorderColor = Color.Black;
            top.FlatStyle = FlatStyle.Flat;
            top.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            top.Location = new Point(101, 61);
            top.Name = "top";
            top.Size = new Size(20, 17);
            top.TabIndex = 9;
            top.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(706, 168);
            button2.Name = "button2";
            button2.Size = new Size(68, 28);
            button2.TabIndex = 10;
            button2.Text = "Devam Et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.Location = new Point(780, 168);
            button3.Name = "button3";
            button3.Size = new Size(68, 28);
            button3.TabIndex = 11;
            button3.Text = "Durdur";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 405);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(top);
            Controls.Add(engel);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(duvarSag);
            Controls.Add(duvarUst);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(duvarSol);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label duvarSol;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label duvarUst;
        private Label duvarSag;
        private Label label7;
        private Button button1;
        private Button engel;
        private Button top;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button button2;
        private Button button3;
    }
}
