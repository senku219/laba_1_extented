// SleepDialog.Designer.cs
namespace HealthTrackerApp
{
    partial class SleepDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDateOfSleep;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDateOfSleep = new System.Windows.Forms.DateTimePicker();
            this.lblHours = new System.Windows.Forms.Label();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(12, 15);
            this.lblDate.Text = "Дата сна:";
            // 
            // dtpDateOfSleep
            // 
            this.dtpDateOfSleep.Location = new System.Drawing.Point(120, 12);
            // 
            // lblHours
            // 
            this.lblHours.Location = new System.Drawing.Point(12, 50);
            this.lblHours.Text = "Часы:";
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(120, 48);
            this.nudHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(40, 90);
            this.btnOK.Text = "OK";
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 90);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // SleepDialog
            // 
            this.ClientSize = new System.Drawing.Size(290, 130);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDateOfSleep);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить сон";
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}