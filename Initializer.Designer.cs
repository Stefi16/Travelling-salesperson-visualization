namespace courseProjectTSP
{
    partial class Initializer
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
            this.matrix = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.generateRandom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matrix
            // 
            this.matrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.matrix.Location = new System.Drawing.Point(59, 108);
            this.matrix.Name = "matrix";
            this.matrix.Size = new System.Drawing.Size(248, 263);
            this.matrix.TabIndex = 0;
            this.matrix.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(1, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your adjacency matrix:";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.White;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.submit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.submit.Location = new System.Drawing.Point(118, 392);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(123, 46);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // generateRandom
            // 
            this.generateRandom.BackColor = System.Drawing.Color.White;
            this.generateRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.generateRandom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.generateRandom.Location = new System.Drawing.Point(340, 232);
            this.generateRandom.Name = "generateRandom";
            this.generateRandom.Size = new System.Drawing.Size(244, 46);
            this.generateRandom.TabIndex = 5;
            this.generateRandom.Text = "Generate Random";
            this.generateRandom.UseVisualStyleBackColor = false;
            this.generateRandom.Click += new System.EventHandler(this.generateRandom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.label2.Location = new System.Drawing.Point(369, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "Click to generate \r\na random matrix.";
            // 
            // Initializer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::courseProjectTSP.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateRandom);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrix);
            this.Name = "Initializer";
            this.Text = "Initializer";
            this.Load += new System.EventHandler(this.Initializer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox matrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button generateRandom;
        private System.Windows.Forms.Label label2;
    }
}