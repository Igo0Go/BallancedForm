namespace BalancedForm
{
    partial class ucCost
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
            this.CostGroupBox = new System.Windows.Forms.GroupBox();
            this.OreText = new System.Windows.Forms.TextBox();
            this.OreLable = new System.Windows.Forms.Label();
            this.SaltText = new System.Windows.Forms.TextBox();
            this.SaltLable = new System.Windows.Forms.Label();
            this.PlazmText = new System.Windows.Forms.TextBox();
            this.PlazmaLable = new System.Windows.Forms.Label();
            this.TimeText = new System.Windows.Forms.TextBox();
            this.TimeLable = new System.Windows.Forms.Label();
            this.RareLable = new System.Windows.Forms.Label();
            this.AddRareButton = new System.Windows.Forms.Button();
            this.RarePanel = new System.Windows.Forms.Panel();
            this.CostGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CostGroupBox
            // 
            this.CostGroupBox.Controls.Add(this.OreText);
            this.CostGroupBox.Controls.Add(this.OreLable);
            this.CostGroupBox.Controls.Add(this.SaltText);
            this.CostGroupBox.Controls.Add(this.SaltLable);
            this.CostGroupBox.Controls.Add(this.PlazmText);
            this.CostGroupBox.Controls.Add(this.PlazmaLable);
            this.CostGroupBox.Controls.Add(this.TimeText);
            this.CostGroupBox.Controls.Add(this.TimeLable);
            this.CostGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CostGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CostGroupBox.Name = "CostGroupBox";
            this.CostGroupBox.Size = new System.Drawing.Size(560, 60);
            this.CostGroupBox.TabIndex = 0;
            this.CostGroupBox.TabStop = false;
            this.CostGroupBox.Text = "Цена";
            // 
            // OreText
            // 
            this.OreText.Location = new System.Drawing.Point(470, 27);
            this.OreText.Name = "OreText";
            this.OreText.Size = new System.Drawing.Size(50, 22);
            this.OreText.TabIndex = 18;
            // 
            // OreLable
            // 
            this.OreLable.AutoSize = true;
            this.OreLable.Location = new System.Drawing.Point(406, 30);
            this.OreLable.Name = "OreLable";
            this.OreLable.Size = new System.Drawing.Size(40, 17);
            this.OreLable.TabIndex = 17;
            this.OreLable.Text = "Руда";
            // 
            // SaltText
            // 
            this.SaltText.Location = new System.Drawing.Point(333, 27);
            this.SaltText.Name = "SaltText";
            this.SaltText.Size = new System.Drawing.Size(50, 22);
            this.SaltText.TabIndex = 16;
            // 
            // SaltLable
            // 
            this.SaltLable.AutoSize = true;
            this.SaltLable.Location = new System.Drawing.Point(277, 30);
            this.SaltLable.Name = "SaltLable";
            this.SaltLable.Size = new System.Drawing.Size(40, 17);
            this.SaltLable.TabIndex = 15;
            this.SaltLable.Text = "Соль";
            // 
            // PlazmText
            // 
            this.PlazmText.Location = new System.Drawing.Point(199, 27);
            this.PlazmText.Name = "PlazmText";
            this.PlazmText.Size = new System.Drawing.Size(50, 22);
            this.PlazmText.TabIndex = 14;
            // 
            // PlazmaLable
            // 
            this.PlazmaLable.AutoSize = true;
            this.PlazmaLable.Location = new System.Drawing.Point(135, 30);
            this.PlazmaLable.Name = "PlazmaLable";
            this.PlazmaLable.Size = new System.Drawing.Size(58, 17);
            this.PlazmaLable.TabIndex = 13;
            this.PlazmaLable.Text = "Плазма";
            // 
            // TimeText
            // 
            this.TimeText.Location = new System.Drawing.Point(62, 27);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(50, 22);
            this.TimeText.TabIndex = 11;
            // 
            // TimeLable
            // 
            this.TimeLable.AutoSize = true;
            this.TimeLable.Location = new System.Drawing.Point(6, 30);
            this.TimeLable.Name = "TimeLable";
            this.TimeLable.Size = new System.Drawing.Size(50, 17);
            this.TimeLable.TabIndex = 10;
            this.TimeLable.Text = "Время";
            // 
            // RareLable
            // 
            this.RareLable.AutoSize = true;
            this.RareLable.Location = new System.Drawing.Point(35, 75);
            this.RareLable.Name = "RareLable";
            this.RareLable.Size = new System.Drawing.Size(60, 17);
            this.RareLable.TabIndex = 19;
            this.RareLable.Text = "Редкие:";
            // 
            // AddRareButton
            // 
            this.AddRareButton.Location = new System.Drawing.Point(101, 72);
            this.AddRareButton.Name = "AddRareButton";
            this.AddRareButton.Size = new System.Drawing.Size(25, 23);
            this.AddRareButton.TabIndex = 12;
            this.AddRareButton.Text = "+";
            this.AddRareButton.UseVisualStyleBackColor = true;
            this.AddRareButton.Click += new System.EventHandler(this.AddRareButton_Click);
            // 
            // RarePanel
            // 
            this.RarePanel.AutoScroll = true;
            this.RarePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RarePanel.Location = new System.Drawing.Point(159, 60);
            this.RarePanel.Name = "RarePanel";
            this.RarePanel.Size = new System.Drawing.Size(391, 65);
            this.RarePanel.TabIndex = 22;
            // 
            // ucCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.RareLable);
            this.Controls.Add(this.AddRareButton);
            this.Controls.Add(this.RarePanel);
            this.Controls.Add(this.CostGroupBox);
            this.MinimumSize = new System.Drawing.Size(560, 140);
            this.Name = "ucCost";
            this.Size = new System.Drawing.Size(560, 140);
            this.CostGroupBox.ResumeLayout(false);
            this.CostGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CostGroupBox;
        private System.Windows.Forms.Label RareLable;
        private System.Windows.Forms.TextBox OreText;
        private System.Windows.Forms.Label OreLable;
        private System.Windows.Forms.TextBox SaltText;
        private System.Windows.Forms.Label SaltLable;
        private System.Windows.Forms.TextBox PlazmText;
        private System.Windows.Forms.Label PlazmaLable;
        private System.Windows.Forms.TextBox TimeText;
        private System.Windows.Forms.Label TimeLable;
        private System.Windows.Forms.Button AddRareButton;
        private System.Windows.Forms.Panel RarePanel;
    }
}
