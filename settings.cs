using System;
using System.Drawing;
using System.Windows.Forms;

namespace lpr29
{
    public partial class settings : Form
    {
        public Font SelectedFont { get; private set; }
        public string Host => hostTextBox.Text;
        public int Port => (int)portNumericUpDown.Value;

        public settings(string currentHost, int currentPort, Font currentFont)
        {
            InitializeComponent();
            hostTextBox.Text = currentHost;
            portNumericUpDown.Value = currentPort;
            SelectedFont = currentFont;
            UpdateFontTextBox();
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = SelectedFont;
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedFont = fontDialog.Font;
                    UpdateFontTextBox();
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void UpdateFontTextBox()
        {
            fontTextBox.Text = $"{SelectedFont.Name}, {SelectedFont.SizeInPoints}pt";
            fontTextBox.Font = SelectedFont;
        }
    }
}
