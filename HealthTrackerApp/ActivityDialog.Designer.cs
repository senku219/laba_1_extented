// ActivityDialog.Designer.cs
namespace HealthTrackerApp
{
    partial class ActivityDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.NumericUpDown nudMinutes;
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
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(12, 15);
            this.lblType.Text = "Тип активности:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(120, 12);
            this.txtType.Width = 150;
            // 
            // lblMinutes
            // 
            this.lblMinutes.Location = new System.Drawing.Point(12, 50);
            this.lblMinutes.Text = "Минуты:";
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(120, 48);
            this.nudMinutes.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
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
            // ActivityDialog
            // 
            this.ClientSize = new System.Drawing.Size(290, 130);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить активность";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}