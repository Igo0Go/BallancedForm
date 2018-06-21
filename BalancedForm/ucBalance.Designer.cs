namespace BalancedForm
{
    partial class ucBalance
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
            this.BalancedSplitContainer = new System.Windows.Forms.SplitContainer();
            this.GlobalButton = new System.Windows.Forms.Button();
            this.SceneButton = new System.Windows.Forms.Button();
            this.LiveButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BalancedSplitContainer)).BeginInit();
            this.BalancedSplitContainer.Panel1.SuspendLayout();
            this.BalancedSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BalancedSplitContainer
            // 
            this.BalancedSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BalancedSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.BalancedSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.BalancedSplitContainer.Name = "BalancedSplitContainer";
            this.BalancedSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // BalancedSplitContainer.Panel1
            // 
            this.BalancedSplitContainer.Panel1.Controls.Add(this.GlobalButton);
            this.BalancedSplitContainer.Panel1.Controls.Add(this.SceneButton);
            this.BalancedSplitContainer.Panel1.Controls.Add(this.LiveButton);
            this.BalancedSplitContainer.Panel1.Controls.Add(this.ProductsButton);
            this.BalancedSplitContainer.Size = new System.Drawing.Size(705, 320);
            this.BalancedSplitContainer.SplitterDistance = 80;
            this.BalancedSplitContainer.TabIndex = 0;
            // 
            // GlobalButton
            // 
            this.GlobalButton.Location = new System.Drawing.Point(530, 5);
            this.GlobalButton.Name = "GlobalButton";
            this.GlobalButton.Size = new System.Drawing.Size(170, 23);
            this.GlobalButton.TabIndex = 4;
            this.GlobalButton.Text = "Глобальное";
            this.GlobalButton.UseVisualStyleBackColor = true;
            this.GlobalButton.Click += new System.EventHandler(this.GlobalButton_Click);
            // 
            // SceneButton
            // 
            this.SceneButton.Location = new System.Drawing.Point(355, 5);
            this.SceneButton.Name = "SceneButton";
            this.SceneButton.Size = new System.Drawing.Size(170, 23);
            this.SceneButton.TabIndex = 3;
            this.SceneButton.Text = "Сцена";
            this.SceneButton.UseVisualStyleBackColor = true;
            this.SceneButton.Click += new System.EventHandler(this.SceneButton_Click);
            // 
            // LiveButton
            // 
            this.LiveButton.Location = new System.Drawing.Point(180, 5);
            this.LiveButton.Name = "LiveButton";
            this.LiveButton.Size = new System.Drawing.Size(170, 23);
            this.LiveButton.TabIndex = 2;
            this.LiveButton.Text = "Живое";
            this.LiveButton.UseVisualStyleBackColor = true;
            this.LiveButton.Click += new System.EventHandler(this.LiveButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProductsButton.Location = new System.Drawing.Point(5, 5);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(170, 23);
            this.ProductsButton.TabIndex = 1;
            this.ProductsButton.Text = "Производимое";
            this.ProductsButton.UseVisualStyleBackColor = false;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // ucBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BalancedSplitContainer);
            this.Name = "ucBalance";
            this.Size = new System.Drawing.Size(705, 320);
            this.BalancedSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BalancedSplitContainer)).EndInit();
            this.BalancedSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer BalancedSplitContainer;
        private System.Windows.Forms.Button GlobalButton;
        private System.Windows.Forms.Button SceneButton;
        private System.Windows.Forms.Button LiveButton;
        private System.Windows.Forms.Button ProductsButton;
    }
}
