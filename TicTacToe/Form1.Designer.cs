namespace TicTacToe
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWho = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scoreO = new System.Windows.Forms.Label();
            this.scoreX = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(32, 36);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 150);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(188, 36);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 150);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(344, 36);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 150);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(344, 192);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(150, 150);
            this.btn6.TabIndex = 3;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(188, 192);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(150, 150);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(32, 192);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(150, 150);
            this.btn4.TabIndex = 5;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(344, 348);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(150, 150);
            this.btn9.TabIndex = 6;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(188, 348);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(150, 150);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(32, 348);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(150, 150);
            this.btn7.TabIndex = 8;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(549, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 60);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ruch gracza:";
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWho.Location = new System.Drawing.Point(805, 36);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(58, 60);
            this.lblWho.TabIndex = 10;
            this.lblWho.Text = "O";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(681, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wynik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(545, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 60);
            this.label3.TabIndex = 12;
            this.label3.Text = "O:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(756, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 60);
            this.label4.TabIndex = 13;
            this.label4.Text = "X:";
            // 
            // scoreO
            // 
            this.scoreO.AutoSize = true;
            this.scoreO.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreO.Location = new System.Drawing.Point(607, 226);
            this.scoreO.Name = "scoreO";
            this.scoreO.Size = new System.Drawing.Size(49, 60);
            this.scoreO.TabIndex = 14;
            this.scoreO.Text = "0";
            // 
            // scoreX
            // 
            this.scoreX.AutoSize = true;
            this.scoreX.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreX.Location = new System.Drawing.Point(809, 226);
            this.scoreX.Name = "scoreX";
            this.scoreX.Size = new System.Drawing.Size(49, 60);
            this.scoreX.TabIndex = 15;
            this.scoreX.Text = "0";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(607, 434);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(220, 64);
            this.btnRestart.TabIndex = 16;
            this.btnRestart.Text = "Nowa gra";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 549);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.scoreX);
            this.Controls.Add(this.scoreO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Label label1;
        private Label lblWho;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label scoreO;
        private Label scoreX;
        private Button btnRestart;
    }
}