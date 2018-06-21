namespace BalancedForm
{
    partial class MainBalancedWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucBalance1 = new BalancedForm.ucBalance();
            this.SuspendLayout();
            // 
            // ucBalance1
            // 
            this.ucBalance1.Location = new System.Drawing.Point(12, 12);
            this.ucBalance1.Name = "ucBalance1";
            this.ucBalance1.Size = new System.Drawing.Size(660, 320);
            this.ucBalance1.TabIndex = 0;
            // 
            // MainBalancedWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 389);
            this.Controls.Add(this.ucBalance1);
            this.Name = "MainBalancedWindow";
            this.Text = "MainBalancedWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private ucBalance ucBalance1;
    }
}