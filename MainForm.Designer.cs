using System.Windows.Forms;
namespace WindowsDebloater
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private CheckBox chkCortana;
        private CheckBox chkXbox;
        private Button btnDebloat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.chkCortana = new System.Windows.Forms.CheckBox();
            this.chkXbox = new System.Windows.Forms.CheckBox();
            this.btnDebloat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // chkCortana
            this.chkCortana.AutoSize = true;
            this.chkCortana.Location = new System.Drawing.Point(30, 30);
            this.chkCortana.Name = "chkCortana";
            this.chkCortana.Size = new System.Drawing.Size(113, 19);
            this.chkCortana.TabIndex = 0;
            this.chkCortana.Text = "Remove Cortana";
            this.chkCortana.UseVisualStyleBackColor = true;

            // chkXbox
            this.chkXbox.AutoSize = true;
            this.chkXbox.Location = new System.Drawing.Point(30, 60);
            this.chkXbox.Name = "chkXbox";
            this.chkXbox.Size = new System.Drawing.Size(97, 19);
            this.chkXbox.TabIndex = 1;
            this.chkXbox.Text = "Remove Xbox";
            this.chkXbox.UseVisualStyleBackColor = true;

            // btnDebloat
            this.btnDebloat.Location = new System.Drawing.Point(30, 100);
            this.btnDebloat.Name = "btnDebloat";
            this.btnDebloat.Size = new System.Drawing.Size(100, 30);
            this.btnDebloat.TabIndex = 2;
            this.btnDebloat.Text = "Debloat";
            this.btnDebloat.UseVisualStyleBackColor = true;
            this.btnDebloat.Click += new System.EventHandler(this.btnDebloat_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 160);
            this.Controls.Add(this.btnDebloat);
            this.Controls.Add(this.chkXbox);
            this.Controls.Add(this.chkCortana);
            this.Name = "MainForm";
            this.Text = "Windows Debloater";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
