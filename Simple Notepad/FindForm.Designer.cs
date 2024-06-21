
namespace Simple_Notepad
{
    partial class FindForm
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
            this.Findlabel2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NextFindBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CaseSensFindcheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Findlabel2
            // 
            this.Findlabel2.AutoSize = true;
            this.Findlabel2.Location = new System.Drawing.Point(13, 39);
            this.Findlabel2.Name = "Findlabel2";
            this.Findlabel2.Size = new System.Drawing.Size(33, 13);
            this.Findlabel2.TabIndex = 0;
            this.Findlabel2.Text = "Find :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 1;
            // 
            // NextFindBtn
            // 
            this.NextFindBtn.Location = new System.Drawing.Point(297, 33);
            this.NextFindBtn.Name = "NextFindBtn";
            this.NextFindBtn.Size = new System.Drawing.Size(75, 23);
            this.NextFindBtn.TabIndex = 2;
            this.NextFindBtn.Text = "Next";
            this.NextFindBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CaseSensFindcheckBox
            // 
            this.CaseSensFindcheckBox.AutoSize = true;
            this.CaseSensFindcheckBox.Location = new System.Drawing.Point(16, 115);
            this.CaseSensFindcheckBox.Name = "CaseSensFindcheckBox";
            this.CaseSensFindcheckBox.Size = new System.Drawing.Size(94, 17);
            this.CaseSensFindcheckBox.TabIndex = 4;
            this.CaseSensFindcheckBox.Text = "Case-sensitive";
            this.CaseSensFindcheckBox.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 154);
            this.Controls.Add(this.CaseSensFindcheckBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NextFindBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Findlabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.ShowInTaskbar = false;
            this.Text = "Find ";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Findlabel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NextFindBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox CaseSensFindcheckBox;
    }
}