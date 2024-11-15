﻿namespace TextBetter
{
    partial class MainForm
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnImproveText = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(50, 30);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(300, 150); // Wider and shorter for better layout
            this.txtInput.TabIndex = 0;
            // 
            // btnImproveText
            // 
            this.btnImproveText.Location = new System.Drawing.Point(50, 200);
            this.btnImproveText.Name = "btnImproveText";
            this.btnImproveText.Size = new System.Drawing.Size(150, 30);
            this.btnImproveText.TabIndex = 1;
            this.btnImproveText.Text = "Improve Text";
            this.btnImproveText.UseVisualStyleBackColor = true;
            this.btnImproveText.Click += new System.EventHandler(this.btnImproveText_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(400, 30); // Align with input box for a side-by-side layout
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(300, 150); // Set a similar size to the input box
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Improved Text:";
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnImproveText);
            this.Controls.Add(this.txtInput);
            this.Name = "MainForm";
            this.Text = "TextBetter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnImproveText;
        private System.Windows.Forms.Label lblOutput;
    }
}

