namespace RGB555_Color_Picker
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
            this.rgb555Box = new System.Windows.Forms.TextBox();
            this.hexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rgb555Box
            // 
            this.rgb555Box.Location = new System.Drawing.Point(69, 6);
            this.rgb555Box.MaxLength = 4;
            this.rgb555Box.Name = "rgb555Box";
            this.rgb555Box.Size = new System.Drawing.Size(55, 20);
            this.rgb555Box.TabIndex = 0;
            this.rgb555Box.Text = "0000";
            // 
            // hexBox
            // 
            this.hexBox.Location = new System.Drawing.Point(69, 32);
            this.hexBox.MaxLength = 6;
            this.hexBox.Name = "hexBox";
            this.hexBox.Size = new System.Drawing.Size(55, 20);
            this.hexBox.TabIndex = 1;
            this.hexBox.Text = "000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RGB555:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hex:";
            // 
            // previewPanel
            // 
            this.previewPanel.BackColor = System.Drawing.Color.Black;
            this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPanel.Location = new System.Drawing.Point(130, 6);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(46, 46);
            this.previewPanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 66);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hexBox);
            this.Controls.Add(this.rgb555Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RGB555 Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rgb555Box;
        private System.Windows.Forms.TextBox hexBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel previewPanel;
    }
}

