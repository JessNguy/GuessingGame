namespace GuessingGame
{
    partial class ResultScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelResults = new System.Windows.Forms.Label();
            this.labelInformation1 = new System.Windows.Forms.Label();
            this.labelInformation2 = new System.Windows.Forms.Label();
            this.labelInformation3 = new System.Windows.Forms.Label();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.labelNumber3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.ForeColor = System.Drawing.Color.White;
            this.labelResults.Location = new System.Drawing.Point(18, 13);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(85, 26);
            this.labelResults.TabIndex = 0;
            this.labelResults.Text = "Results";
            // 
            // labelInformation1
            // 
            this.labelInformation1.AutoSize = true;
            this.labelInformation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelInformation1.Location = new System.Drawing.Point(19, 85);
            this.labelInformation1.Name = "labelInformation1";
            this.labelInformation1.Size = new System.Drawing.Size(46, 17);
            this.labelInformation1.TabIndex = 1;
            this.labelInformation1.Text = "label1";
            // 
            // labelInformation2
            // 
            this.labelInformation2.AutoSize = true;
            this.labelInformation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelInformation2.Location = new System.Drawing.Point(19, 149);
            this.labelInformation2.Name = "labelInformation2";
            this.labelInformation2.Size = new System.Drawing.Size(46, 17);
            this.labelInformation2.TabIndex = 2;
            this.labelInformation2.Text = "label1";
            // 
            // labelInformation3
            // 
            this.labelInformation3.AutoSize = true;
            this.labelInformation3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation3.ForeColor = System.Drawing.SystemColors.Control;
            this.labelInformation3.Location = new System.Drawing.Point(19, 210);
            this.labelInformation3.Name = "labelInformation3";
            this.labelInformation3.Size = new System.Drawing.Size(46, 17);
            this.labelInformation3.TabIndex = 3;
            this.labelInformation3.Text = "label1";
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNumber2.Location = new System.Drawing.Point(119, 149);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(46, 17);
            this.labelNumber2.TabIndex = 4;
            this.labelNumber2.Text = "label1";
            // 
            // labelNumber3
            // 
            this.labelNumber3.AutoSize = true;
            this.labelNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber3.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNumber3.Location = new System.Drawing.Point(119, 210);
            this.labelNumber3.Name = "labelNumber3";
            this.labelNumber3.Size = new System.Drawing.Size(46, 17);
            this.labelNumber3.TabIndex = 5;
            this.labelNumber3.Text = "label1";
            // 
            // ResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.labelNumber3);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.labelInformation3);
            this.Controls.Add(this.labelInformation2);
            this.Controls.Add(this.labelInformation1);
            this.Controls.Add(this.labelResults);
            this.Name = "ResultScreen";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelInformation1;
        private System.Windows.Forms.Label labelInformation2;
        private System.Windows.Forms.Label labelInformation3;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Label labelNumber3;
    }
}
