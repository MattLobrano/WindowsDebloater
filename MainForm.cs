using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WindowsDebloater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDebloat_Click(object sender, EventArgs e)
        {
            if (chkCortana.Checked)
                RunPowerShellScript("scripts\\RemoveCortana.ps1");

            if (chkXbox.Checked)
                RunPowerShellScript("scripts\\RemoveXbox.ps1");

            MessageBox.Show("Selected debloat actions completed.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RunPowerShellScript(string scriptPath)
        {
            if (!File.Exists(scriptPath))
            {
                MessageBox.Show($"Script not found: {scriptPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var process = new Process();
                process.StartInfo.FileName = "powershell.exe";
                process.StartInfo.Arguments = $"-ExecutionPolicy Bypass -File \"{scriptPath}\"";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to run script:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
