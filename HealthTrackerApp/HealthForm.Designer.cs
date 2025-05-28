// HealthForm.Designer.cs
namespace HealthTrackerApp
{
    partial class HealthForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnTrackActivity;
        private System.Windows.Forms.Button btnTrackNutrition;
        private System.Windows.Forms.Button btnTrackSleep;
        private System.Windows.Forms.Button btnShowReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnTrackActivity = new System.Windows.Forms.Button();
            this.btnTrackNutrition = new System.Windows.Forms.Button();
            this.btnTrackSleep = new System.Windows.Forms.Button();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrackActivity
            // 
            this.btnTrackActivity.Location = new System.Drawing.Point(20, 20);
            this.btnTrackActivity.Name = "btnTrackActivity";
            this.btnTrackActivity.Size = new System.Drawing.Size(200, 40);
            this.btnTrackActivity.Text = "Добавить активность";
            this.btnTrackActivity.UseVisualStyleBackColor = true;
            this.btnTrackActivity.Click += new System.EventHandler(this.btnTrackActivity_Click);
            // 
            // btnTrackNutrition
            // 
            this.btnTrackNutrition.Location = new System.Drawing.Point(20, 70);
            this.btnTrackNutrition.Name = "btnTrackNutrition";
            this.btnTrackNutrition.Size = new System.Drawing.Size(200, 40);
            this.btnTrackNutrition.Text = "Добавить питание";
            this.btnTrackNutrition.UseVisualStyleBackColor = true;
            this.btnTrackNutrition.Click += new System.EventHandler(this.btnTrackNutrition_Click);
            // 
            // btnTrackSleep
            // 
            this.btnTrackSleep.Location = new System.Drawing.Point(20, 120);
            this.btnTrackSleep.Name = "btnTrackSleep";
            this.btnTrackSleep.Size = new System.Drawing.Size(200, 40);
            this.btnTrackSleep.Text = "Добавить сон";
            this.btnTrackSleep.UseVisualStyleBackColor = true;
            this.btnTrackSleep.Click += new System.EventHandler(this.btnTrackSleep_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(20, 170);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(200, 40);
            this.btnShowReport.Text = "Показать отчёт";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // HealthForm
            // 
            this.ClientSize = new System.Drawing.Size(240, 230);
            this.Controls.Add(this.btnTrackActivity);
            this.Controls.Add(this.btnTrackNutrition);
            this.Controls.Add(this.btnTrackSleep);
            this.Controls.Add(this.btnShowReport);
            this.Name = "HealthForm";
            this.Text = "Health Tracker";
            this.ResumeLayout(false);
        }
    }
}
