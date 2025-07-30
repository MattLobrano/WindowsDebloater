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
                RunPowerShellScript(@"scripts\RemoveCortana.ps1");

            if (chkXbox.Checked)
                RunPowerShellScript(@"scripts\RemoveXbox.ps1");

            MessageBox.Show("Selected actions completed.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RunPowerShellScript(string relativeScriptPath)
        {
            try
            {
                string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeScriptPath);

                if (!File.Exists(scriptPath))
                {
                    MessageBox.Show($"Script not found:\n{scriptPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var psi = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{scriptPath}\"",
                    UseShellExecute = true,
                    Verb = "runas" // Run as administrator
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running script:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
