namespace BalancedForm
{
    partial class ucRemoveButton
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RemoveRareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveRareButton
            // 
            this.RemoveRareButton.Location = new System.Drawing.Point(5, 5);
            this.RemoveRareButton.Name = "RemoveRareButton";
            this.RemoveRareButton.Size = new System.Drawing.Size(25, 25);
            this.RemoveRareButton.TabIndex = 0;
            this.RemoveRareButton.Text = "X";
            this.RemoveRareButton.UseVisualStyleBackColor = true;
            this.RemoveRareButton.Click += new System.EventHandler(this.RemoveRareButton_Click);
            // 
            // ucRemoveButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveRareButton);
            this.Name = "ucRemoveButton";
            this.Size = new System.Drawing.Size(34, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveRareButton;
    }
}
