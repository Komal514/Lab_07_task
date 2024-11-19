namespace task06_lab07
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
            this.QuizStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer1_Tick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuizStart
            // 
            this.QuizStart.Location = new System.Drawing.Point(539, 45);
            this.QuizStart.Name = "QuizStart";
            this.QuizStart.Size = new System.Drawing.Size(118, 48);
            this.QuizStart.TabIndex = 0;
            this.QuizStart.Text = "Quiz Start";
            this.QuizStart.UseVisualStyleBackColor = true;
            this.QuizStart.Click += new System.EventHandler(this.QuizStart_Click);
            // 
            // timer1_Tick
            // 
            this.timer1_Tick.Location = new System.Drawing.Point(163, 45);
            this.timer1_Tick.Name = "timer1_Tick";
            this.timer1_Tick.Size = new System.Drawing.Size(100, 26);
            this.timer1_Tick.TabIndex = 1;
            this.timer1_Tick.TextChanged += new System.EventHandler(this.timer1_Tick_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Left :         0 seconds";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timer1_Tick);
            this.Controls.Add(this.QuizStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuizStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox timer1_Tick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

