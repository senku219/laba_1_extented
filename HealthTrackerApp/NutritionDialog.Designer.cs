// NutritionDialog.Designer.cs
namespace HealthTrackerApp
{
    partial class NutritionDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.NumericUpDown nudCalories;
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
            this.lblFood = new System.Windows.Forms.Label();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this.nudCalories = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalories)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFood
            // 
            this.lblFood.Location = new System.Drawing.Point(12, 15);
            this.lblFood.Text = "Продукт:";
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(120, 12);
            this.txtFood.Width = 150;
            // 
            // lblCalories
            // 
            this.lblCalories.Location = new System.Drawing.Point(12, 50);
            this.lblCalories.Text = "Калории:";
            // 
            // nudCalories
            // 
            this.nudCalories.Location = new System.Drawing.Point(120, 48);
            this.nudCalories.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
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
            // NutritionDialog
            // 
            this.ClientSize = new System.Drawing.Size(290, 130);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.nudCalories);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить питание";
            ((System.ComponentModel.ISupportInitialize)(this.nudCalories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}