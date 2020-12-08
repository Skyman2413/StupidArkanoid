namespace Kursach
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
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("v_Mouth Breather BB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.start.Location = new System.Drawing.Point(300, 218);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(390, 74);
            this.start.TabIndex = 0;
            this.start.Text = "Start game";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("v_Mouth Breather BB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(259, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 95);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arkanoid";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // last
            // 
            this.last.Font = new System.Drawing.Font("v_Mouth Breather BB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.last.Location = new System.Drawing.Point(300, 315);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(390, 74);
            this.last.TabIndex = 5;
            this.last.Text = "Last games";
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("v_Mouth Breather BB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.help.Location = new System.Drawing.Point(300, 410);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(390, 74);
            this.help.TabIndex = 6;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("v_Mouth Breather BB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.exit.Location = new System.Drawing.Point(300, 510);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(390, 74);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.help);
            this.Controls.Add(this.last);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Arkanoid";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.Button start;

        #endregion
    }
}