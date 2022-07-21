
namespace yoketoru_vs22
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
            this.components = new System.ComponentModel.Container();
            this.start_button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.hilabel1 = new System.Windows.Forms.Label();
            this.copyroghtlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countlabel4 = new System.Windows.Forms.Label();
            this.gameover_label5 = new System.Windows.Forms.Label();
            this.clear_label6 = new System.Windows.Forms.Label();
            this.title_button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.templabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.start_button.Font = new System.Drawing.Font("Yu Gothic UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_button.Location = new System.Drawing.Point(218, 226);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(365, 122);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "スタート！";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Yu Gothic UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.title_label.Location = new System.Drawing.Point(132, 54);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(541, 125);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "よけとる2022";
            // 
            // hilabel1
            // 
            this.hilabel1.AutoSize = true;
            this.hilabel1.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hilabel1.Location = new System.Drawing.Point(259, 169);
            this.hilabel1.Name = "hilabel1";
            this.hilabel1.Size = new System.Drawing.Size(282, 54);
            this.hilabel1.TabIndex = 2;
            this.hilabel1.Text = "HighScore 100";
            // 
            // copyroghtlabel
            // 
            this.copyroghtlabel.AutoSize = true;
            this.copyroghtlabel.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyroghtlabel.Location = new System.Drawing.Point(240, 404);
            this.copyroghtlabel.Name = "copyroghtlabel";
            this.copyroghtlabel.Size = new System.Drawing.Size(321, 37);
            this.copyroghtlabel.TabIndex = 3;
            this.copyroghtlabel.Text = "Copyright ©2020 田中 雄";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time 100";
            // 
            // countlabel4
            // 
            this.countlabel4.AutoSize = true;
            this.countlabel4.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countlabel4.Location = new System.Drawing.Point(687, 9);
            this.countlabel4.Name = "countlabel4";
            this.countlabel4.Size = new System.Drawing.Size(101, 37);
            this.countlabel4.TabIndex = 5;
            this.countlabel4.Text = "★：10";
            this.countlabel4.Click += new System.EventHandler(this.countlabel4_Click);
            // 
            // gameover_label5
            // 
            this.gameover_label5.AutoSize = true;
            this.gameover_label5.Font = new System.Drawing.Font("Yu Gothic UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameover_label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gameover_label5.Location = new System.Drawing.Point(180, 149);
            this.gameover_label5.Name = "gameover_label5";
            this.gameover_label5.Size = new System.Drawing.Size(461, 106);
            this.gameover_label5.TabIndex = 6;
            this.gameover_label5.Text = "GAMEOVER";
            // 
            // clear_label6
            // 
            this.clear_label6.AutoSize = true;
            this.clear_label6.Font = new System.Drawing.Font("Yu Gothic UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear_label6.ForeColor = System.Drawing.Color.Red;
            this.clear_label6.Location = new System.Drawing.Point(195, 135);
            this.clear_label6.Name = "clear_label6";
            this.clear_label6.Size = new System.Drawing.Size(414, 125);
            this.clear_label6.TabIndex = 7;
            this.clear_label6.Text = "CLEAR！";
            // 
            // title_button1
            // 
            this.title_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.title_button1.Font = new System.Drawing.Font("Yu Gothic UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_button1.Location = new System.Drawing.Point(231, 288);
            this.title_button1.Name = "title_button1";
            this.title_button1.Size = new System.Drawing.Size(339, 93);
            this.title_button1.TabIndex = 8;
            this.title_button1.Text = "タイトルへ";
            this.title_button1.UseVisualStyleBackColor = false;
            this.title_button1.Click += new System.EventHandler(this.title_button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // templabel1
            // 
            this.templabel1.AutoSize = true;
            this.templabel1.BackColor = System.Drawing.Color.Transparent;
            this.templabel1.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.templabel1.Location = new System.Drawing.Point(4, 404);
            this.templabel1.Name = "templabel1";
            this.templabel1.Size = new System.Drawing.Size(44, 37);
            this.templabel1.TabIndex = 9;
            this.templabel1.Text = "★";
            this.templabel1.Visible = false;
            this.templabel1.Click += new System.EventHandler(this.templabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.templabel1);
            this.Controls.Add(this.title_button1);
            this.Controls.Add(this.clear_label6);
            this.Controls.Add(this.gameover_label5);
            this.Controls.Add(this.countlabel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copyroghtlabel);
            this.Controls.Add(this.hilabel1);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.start_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label hilabel1;
        private System.Windows.Forms.Label copyroghtlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label countlabel4;
        private System.Windows.Forms.Label gameover_label5;
        private System.Windows.Forms.Label clear_label6;
        private System.Windows.Forms.Button title_button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label templabel1;
    }
}

