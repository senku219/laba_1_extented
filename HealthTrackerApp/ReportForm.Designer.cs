// ReportForm.Designer.cs
namespace HealthTrackerApp
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox rtbReport;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rtbReport = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbReport
            // 
            this.rtbReport.Location = new System.Drawing.Point(12, 12);
            this.rtbReport.ReadOnly = true;
            this.rtbReport.Size = new System.Drawing.Size(360, 300);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(160, 320);
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.Text = "Закрыть";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ReportForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.rtbReport);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отчёт о здоровье";
            this.ResumeLayout(false);
        }
    }
}