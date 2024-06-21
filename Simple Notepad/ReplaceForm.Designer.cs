
namespace Simple_Notepad
{
    partial class ReplaceForm
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
            this.Nextbtn = new System.Windows.Forms.Button();
            this.ReplaceBtn = new System.Windows.Forms.Button();
            this.ReplaceallBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.FindLabel = new System.Windows.Forms.Label();
            this.ReplaceLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.casesensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(296, 9);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(75, 23);
            this.Nextbtn.TabIndex = 0;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            // 
            // ReplaceBtn
            // 
            this.ReplaceBtn.Location = new System.Drawing.Point(296, 53);
            this.ReplaceBtn.Name = "ReplaceBtn";
            this.ReplaceBtn.Size = new System.Drawing.Size(75, 23);
            this.ReplaceBtn.TabIndex = 1;
            this.ReplaceBtn.Text = "Replace";
            this.ReplaceBtn.UseVisualStyleBackColor = true;
            // 
            // ReplaceallBtn
            // 
            this.ReplaceallBtn.Location = new System.Drawing.Point(296, 91);
            this.ReplaceallBtn.Name = "ReplaceallBtn";
            this.ReplaceallBtn.Size = new System.Drawing.Size(75, 23);
            this.ReplaceallBtn.TabIndex = 2;
            this.ReplaceallBtn.Text = "Replace All";
            this.ReplaceallBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(296, 135);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(12, 19);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(33, 13);
            this.FindLabel.TabIndex = 4;
            this.FindLabel.Text = "Find :";
            // 
            // ReplaceLabel
            // 
            this.ReplaceLabel.AutoSize = true;
            this.ReplaceLabel.Location = new System.Drawing.Point(3, 63);
            this.ReplaceLabel.Name = "ReplaceLabel";
            this.ReplaceLabel.Size = new System.Drawing.Size(75, 13);
            this.ReplaceLabel.TabIndex = 5;
            this.ReplaceLabel.Text = "Replace with :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 7;
            // 
            // casesensitiveCheckBox
            // 
            this.casesensitiveCheckBox.AutoSize = true;
            this.casesensitiveCheckBox.Location = new System.Drawing.Point(15, 118);
            this.casesensitiveCheckBox.Name = "casesensitiveCheckBox";
            this.casesensitiveCheckBox.Size = new System.Drawing.Size(94, 17);
            this.casesensitiveCheckBox.TabIndex = 8;
            this.casesensitiveCheckBox.Text = "Case-sensitive";
            this.casesensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 185);
            this.Controls.Add(this.casesensitiveCheckBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ReplaceLabel);
            this.Controls.Add(this.FindLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ReplaceallBtn);
            this.Controls.Add(this.ReplaceBtn);
            this.Controls.Add(this.Nextbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceForm";
            this.ShowInTaskbar = false;
            this.Text = "Replace";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.Button ReplaceBtn;
        private System.Windows.Forms.Button ReplaceallBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Label ReplaceLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox casesensitiveCheckBox;
    }
}