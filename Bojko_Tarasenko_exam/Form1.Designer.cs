
namespace Bojko_Tarasenko_exam
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectPnl = new System.Windows.Forms.Panel();
            this.locationPnl = new System.Windows.Forms.Panel();
            this.timePnl = new System.Windows.Forms.Panel();
            this.characteristicsPnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // selectPnl
            // 
            this.selectPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectPnl.Location = new System.Drawing.Point(0, 525);
            this.selectPnl.Name = "selectPnl";
            this.selectPnl.Size = new System.Drawing.Size(1004, 133);
            this.selectPnl.TabIndex = 0;
            // 
            // locationPnl
            // 
            this.locationPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.locationPnl.Location = new System.Drawing.Point(0, 0);
            this.locationPnl.Name = "locationPnl";
            this.locationPnl.Size = new System.Drawing.Size(815, 525);
            this.locationPnl.TabIndex = 1;
            // 
            // timePnl
            // 
            this.timePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timePnl.Location = new System.Drawing.Point(815, 0);
            this.timePnl.Name = "timePnl";
            this.timePnl.Size = new System.Drawing.Size(189, 525);
            this.timePnl.TabIndex = 2;
            // 
            // characteristicsPnl
            // 
            this.characteristicsPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.characteristicsPnl.Location = new System.Drawing.Point(815, 76);
            this.characteristicsPnl.Name = "characteristicsPnl";
            this.characteristicsPnl.Size = new System.Drawing.Size(189, 449);
            this.characteristicsPnl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 658);
            this.Controls.Add(this.characteristicsPnl);
            this.Controls.Add(this.timePnl);
            this.Controls.Add(this.locationPnl);
            this.Controls.Add(this.selectPnl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectPnl;
        private System.Windows.Forms.Panel locationPnl;
        private System.Windows.Forms.Panel timePnl;
        private System.Windows.Forms.Panel characteristicsPnl;
    }
}

