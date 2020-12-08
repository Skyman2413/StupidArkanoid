using System.ComponentModel;

namespace Kursach
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("v_Mouth Breather BB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score : ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("v_Mouth Breather BB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(856, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainGame_KeyUp);
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;

        #endregion
    }
}