namespace courseProjectTSP
{
    partial class Visualizer
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
            this.next = new System.Windows.Forms.Button();
            this.resultInt = new System.Windows.Forms.Label();
            this.writeResult = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.ListBox();
            this.titleAlledges = new System.Windows.Forms.Label();
            this.optimalRoute = new System.Windows.Forms.ListBox();
            this.titleOptimalRoute = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.speech = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speech)).BeginInit();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.White;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.next.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.next.Location = new System.Drawing.Point(1409, 445);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(133, 46);
            this.next.TabIndex = 0;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // resultInt
            // 
            this.resultInt.AutoSize = true;
            this.resultInt.BackColor = System.Drawing.Color.Transparent;
            this.resultInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.resultInt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultInt.Location = new System.Drawing.Point(370, 788);
            this.resultInt.Name = "resultInt";
            this.resultInt.Size = new System.Drawing.Size(85, 25);
            this.resultInt.TabIndex = 1;
            this.resultInt.Text = "Result: ";
            // 
            // writeResult
            // 
            this.writeResult.AutoSize = true;
            this.writeResult.BackColor = System.Drawing.Color.Transparent;
            this.writeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.writeResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.writeResult.Location = new System.Drawing.Point(461, 788);
            this.writeResult.Name = "writeResult";
            this.writeResult.Size = new System.Drawing.Size(18, 25);
            this.writeResult.TabIndex = 2;
            this.writeResult.Text = ".";
            this.writeResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cost
            // 
            this.cost.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cost.FormattingEnabled = true;
            this.cost.ItemHeight = 16;
            this.cost.Location = new System.Drawing.Point(49, 628);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(166, 196);
            this.cost.TabIndex = 3;
            // 
            // titleAlledges
            // 
            this.titleAlledges.AutoSize = true;
            this.titleAlledges.BackColor = System.Drawing.Color.Transparent;
            this.titleAlledges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.titleAlledges.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleAlledges.Location = new System.Drawing.Point(1, 589);
            this.titleAlledges.Name = "titleAlledges";
            this.titleAlledges.Size = new System.Drawing.Size(275, 25);
            this.titleAlledges.TabIndex = 4;
            this.titleAlledges.Text = "Travelling cost of all edges:";
            // 
            // optimalRoute
            // 
            this.optimalRoute.FormattingEnabled = true;
            this.optimalRoute.ItemHeight = 16;
            this.optimalRoute.Location = new System.Drawing.Point(363, 628);
            this.optimalRoute.Name = "optimalRoute";
            this.optimalRoute.Size = new System.Drawing.Size(149, 132);
            this.optimalRoute.TabIndex = 5;
            // 
            // titleOptimalRoute
            // 
            this.titleOptimalRoute.AutoSize = true;
            this.titleOptimalRoute.BackColor = System.Drawing.Color.Transparent;
            this.titleOptimalRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.titleOptimalRoute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleOptimalRoute.Location = new System.Drawing.Point(358, 589);
            this.titleOptimalRoute.Name = "titleOptimalRoute";
            this.titleOptimalRoute.Size = new System.Drawing.Size(154, 25);
            this.titleOptimalRoute.TabIndex = 6;
            this.titleOptimalRoute.Text = "Optimal Route:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::courseProjectTSP.Properties.Resources.teachingLaptop;
            this.pictureBox1.Location = new System.Drawing.Point(1413, 561);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // speech
            // 
            this.speech.BackColor = System.Drawing.Color.Transparent;
            this.speech.Image = global::courseProjectTSP.Properties.Resources.z_flip;
            this.speech.Location = new System.Drawing.Point(1170, 497);
            this.speech.Name = "speech";
            this.speech.Size = new System.Drawing.Size(295, 143);
            this.speech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.speech.TabIndex = 9;
            this.speech.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1174, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Click the button Next and it will\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1174, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "show you the most optimal\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1174, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "route for our travelling salsman\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1174, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "to follow!";
            // 
            // Visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::courseProjectTSP.Properties.Resources._1092570;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1542, 854);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speech);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleOptimalRoute);
            this.Controls.Add(this.optimalRoute);
            this.Controls.Add(this.titleAlledges);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.writeResult);
            this.Controls.Add(this.resultInt);
            this.Controls.Add(this.next);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Visualizer";
            this.Text = "Visualizer";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speech)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label resultInt;
        private System.Windows.Forms.Label writeResult;
        private System.Windows.Forms.ListBox cost;
        private System.Windows.Forms.Label titleAlledges;
        private System.Windows.Forms.ListBox optimalRoute;
        private System.Windows.Forms.Label titleOptimalRoute;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox speech;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

