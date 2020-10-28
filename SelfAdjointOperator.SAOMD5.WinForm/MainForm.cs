using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfAdjointOperator.SAOMD5.WinForm
{
    public partial class MainForm : Form
    {
        private string filename;
        private Dictionary<string,string> hashesDictionary = new Dictionary<string,string>();

        public MainForm(string[] args)
        {
            InitializeComponent();
            if (args != null && args.Length > 0)
            {
                filename = args[0];
            }
            else
            {
                OpenFileDialog getFilenameDialog = new OpenFileDialog();
                getFilenameDialog.Title = "Select a file...";
                if (getFilenameDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = getFilenameDialog.FileName;
                }
                else
                {
                    MessageBox.Show(this,"No file selected!\nClick OK to close.","SAOMD5",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    Environment.Exit(1);
                }
            }
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            LabelFilenameValue.Text = filename;
            LabelFilenameValue.Click += (ls, le) => { Clipboard.SetText(LabelFilenameValue.Text); };

            hashesDictionary["MD5"] = await Task.Run(() => SAOHashers.GetHashHexMD5(filename));
            LabelMD5Hash.Text = hashesDictionary["MD5"];
            LabelMD5Hash.Click += (ls,le) => {Clipboard.SetText(hashesDictionary["MD5"]);};
        }

        private async void LabelSHA256Hash_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Text = "Getting Hash...";
            label.Click -= LabelSHA256Hash_Click;
            hashesDictionary["SHA256"] = await Task.Run(() => SAOHashers.GetHashHexSHA256(filename));
            LabelSHA256Hash.Text = hashesDictionary["SHA256"];
            LabelSHA256Hash.Click += (ls, le) => { Clipboard.SetText(hashesDictionary["SHA256"]); };
        }

        private async void LabelSHA512Hash_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Text = "Getting Hash...";
            label.Click -= LabelSHA512Hash_Click;
            hashesDictionary["SHA512"] = await Task.Run(() => SAOHashers.GetHashHexSHA512(filename));
            LabelSHA512Hash.Text = hashesDictionary["SHA512"];
            LabelSHA512Hash.Click += (ls, le) => { Clipboard.SetText(hashesDictionary["SHA512"]); };
        }
    }
}
