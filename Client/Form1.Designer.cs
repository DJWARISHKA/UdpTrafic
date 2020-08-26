namespace Client
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
            this.tAverageValue = new System.Windows.Forms.TextBox();
            this.tStandardDeviation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lip = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tLost = new System.Windows.Forms.TextBox();
            this.lDelay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tAverageValue
            // 
            this.tAverageValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tAverageValue.Location = new System.Drawing.Point(173, 40);
            this.tAverageValue.Name = "tAverageValue";
            this.tAverageValue.ReadOnly = true;
            this.tAverageValue.Size = new System.Drawing.Size(109, 20);
            this.tAverageValue.TabIndex = 0;
            this.tAverageValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // tStandardDeviation
            // 
            this.tStandardDeviation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tStandardDeviation.Location = new System.Drawing.Point(173, 71);
            this.tStandardDeviation.Name = "tStandardDeviation";
            this.tStandardDeviation.ReadOnly = true;
            this.tStandardDeviation.Size = new System.Drawing.Size(109, 20);
            this.tStandardDeviation.TabIndex = 1;
            this.tStandardDeviation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Среднее отклонение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стандартное отклонение";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(312, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lip
            // 
            this.lip.AutoSize = true;
            this.lip.Location = new System.Drawing.Point(11, 9);
            this.lip.Name = "lip";
            this.lip.Size = new System.Drawing.Size(23, 13);
            this.lip.TabIndex = 5;
            this.lip.Text = "IP  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Потеряные пакеты";
            // 
            // tLost
            // 
            this.tLost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLost.Location = new System.Drawing.Point(173, 100);
            this.tLost.Name = "tLost";
            this.tLost.ReadOnly = true;
            this.tLost.Size = new System.Drawing.Size(109, 20);
            this.tLost.TabIndex = 6;
            this.tLost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // lDelay
            // 
            this.lDelay.AutoSize = true;
            this.lDelay.Location = new System.Drawing.Point(170, 9);
            this.lDelay.Name = "lDelay";
            this.lDelay.Size = new System.Drawing.Size(40, 13);
            this.lDelay.TabIndex = 10;
            this.lDelay.Text = "Delay  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 136);
            this.Controls.Add(this.lDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tLost);
            this.Controls.Add(this.lip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tStandardDeviation);
            this.Controls.Add(this.tAverageValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tAverageValue;
        private System.Windows.Forms.TextBox tStandardDeviation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tLost;
        private System.Windows.Forms.Label lDelay;
    }
}

