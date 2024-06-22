using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Notepad
{
    public partial class MainForm : Form
    {
        private ReplaceForm ReplaceForm;
        private FindForm FindForm;
        private bool IsTextChanged = false; // Flag to track if text has been changed
        public MainForm()
        {
            InitializeComponent();
            richTextBox1.TextChanged += RichTextBox1_TextChanged; // Hook text changed event
        }
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            IsTextChanged = true; // Set flag when text changes
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
                PromptSaveChangesOrContinue(() =>
                {
                    openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog1.FileName = "";
                    openFileDialog1.FilterIndex = 1;

                    DialogResult dialogResult = openFileDialog1.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        LoadTextFromFile(openFileDialog1.FileName);
                    }
                });       

        }
        private void LoadTextFromFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                    IsTextChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
            
        }
        private void SaveFile()
        {
            // Check if the file has been saved previously (i.e., has a file path)
            if (string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                // File hasn't been saved yet or Save As was used previously
                SaveAs();
            }
            else
            {
                // File has a path, indicating it has been saved before
                SaveToFile(saveFileDialog1.FileName);
            }
        }

        private void SaveAs()
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            DialogResult saveDialog = saveFileDialog1.ShowDialog();

            if (saveDialog == DialogResult.OK)
            {
                SaveToFile(saveFileDialog1.FileName);
            }
        }
        private void SaveToFile(string filePath)
        {
            try
            {
                StreamWriter writer = new StreamWriter(filePath);
                writer.WriteLine(richTextBox1.Text);
                writer.Close();
                IsTextChanged = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void wordWraptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromptSaveChangesOrContinue(() =>
            {
                richTextBox1.Clear(); // Clear text box if user chooses to continue
                IsTextChanged = false; // Reset flag after clearing
            });

            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromptSaveChangesOrContinue(() =>
            {
                Application.Exit(); // Exit application if user chooses to continue
            });

        }
        private void PromptSaveChangesOrContinue(Action continueAction)
        {
            if (IsTextChanged)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        saveToolStripMenuItem_Click(null, null); // Save changes
                        if (!string.IsNullOrEmpty(saveFileDialog1.FileName)) // Check if save was successful
                            continueAction.Invoke(); // Continue with the requested action
                        break;
                    case DialogResult.No:
                        continueAction.Invoke(); // Continue without saving changes
                        break;
                    case DialogResult.Cancel:
                        // Cancel the operation, do nothing
                        break;
                }
            }
            else
            {
                continueAction.Invoke(); // No changes, continue with the requested action
            }
        }



        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult printdialog = printDialog1.ShowDialog();
            if (printdialog == DialogResult.OK)
            {
                // print logic missing here (TODO)
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo == true)
            {
                richTextBox1.Redo();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                richTextBox1.Copy();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                richTextBox1.Cut();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richTextBox1.Paste();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                richTextBox1.SelectedText = "";
            }
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt =  DateTime.Now;
            richTextBox1.Text += dt.ToString();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fontdialog = fontDialog1.ShowDialog();
            if (fontdialog == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;

            }
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = true;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = false;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult backdialog = colorDialog1.ShowDialog();
            if (backdialog == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;

            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult textdialog = colorDialog2.ShowDialog();
            if (textdialog == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog2.Color;

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "This is just a simple notepad that I made to learn C#\n\n";
            message += "Visit my GitHub repository for more projects:\n";
            message += "              https://github.com/DZ-T/";


            // Show the MessageBox 
            MessageBox.Show(message, "About Notepad+", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void myGithubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/DZ-T/";
            Process.Start(url); // Open the URL when clicked
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ReplaceForm == null || ReplaceForm.IsDisposed)
            {
                ReplaceForm = new ReplaceForm(); // Re-initialize if form is disposed
            }

            ReplaceForm.Show(); // Show the ReplaceForm
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FindForm == null || FindForm.IsDisposed)
            {
                FindForm = new FindForm(); // Re-initialize if form is disposed
            }

            FindForm.Show(); // Show the FindForm
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int line = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1;
            int column = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine() + 1;
            // Update the label to show current line and column
            LineandColumnLabel.Text = $"Ln: {line}  Col: {column}";
            // Update status bar with total number of lines
            int Lengths = richTextBox1.TextLength; ;
            NumberofLinesLabel.Text = $"Lines: {richTextBox1.Lines.Length}  Length: {Lengths}";
        }

        private void LineandColumnLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}

