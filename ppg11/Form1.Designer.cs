namespace ppg11
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
            this.checkTrainButton = new System.Windows.Forms.Button();
            this.carriageCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.carriageTypesTextBox = new System.Windows.Forms.TextBox();
            this.maxCarriageCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.allowedCarriageTypesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.carriageCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCarriageCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // checkTrainButton
            // 
            this.checkTrainButton.Location = new System.Drawing.Point(238, 118);
            this.checkTrainButton.Name = "checkTrainButton";
            this.checkTrainButton.Size = new System.Drawing.Size(75, 23);
            this.checkTrainButton.TabIndex = 0;
            this.checkTrainButton.Text = "button1";
            this.checkTrainButton.UseVisualStyleBackColor = true;
            this.checkTrainButton.Click += new System.EventHandler(this.checkTrainButton_Click);
            // 
            // carriageCountNumericUpDown
            // 
            this.carriageCountNumericUpDown.Location = new System.Drawing.Point(113, 100);
            this.carriageCountNumericUpDown.Name = "carriageCountNumericUpDown";
            this.carriageCountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.carriageCountNumericUpDown.TabIndex = 1;
            // 
            // carriageTypesTextBox
            // 
            this.carriageTypesTextBox.Location = new System.Drawing.Point(199, 186);
            this.carriageTypesTextBox.Name = "carriageTypesTextBox";
            this.carriageTypesTextBox.Size = new System.Drawing.Size(100, 20);
            this.carriageTypesTextBox.TabIndex = 2;
            // 
            // maxCarriageCountNumericUpDown
            // 
            this.maxCarriageCountNumericUpDown.Location = new System.Drawing.Point(497, 185);
            this.maxCarriageCountNumericUpDown.Name = "maxCarriageCountNumericUpDown";
            this.maxCarriageCountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.maxCarriageCountNumericUpDown.TabIndex = 3;
            // 
            // allowedCarriageTypesTextBox
            // 
            this.allowedCarriageTypesTextBox.Location = new System.Drawing.Point(146, 262);
            this.allowedCarriageTypesTextBox.Name = "allowedCarriageTypesTextBox";
            this.allowedCarriageTypesTextBox.Size = new System.Drawing.Size(100, 20);
            this.allowedCarriageTypesTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allowedCarriageTypesTextBox);
            this.Controls.Add(this.maxCarriageCountNumericUpDown);
            this.Controls.Add(this.carriageTypesTextBox);
            this.Controls.Add(this.carriageCountNumericUpDown);
            this.Controls.Add(this.checkTrainButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.carriageCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCarriageCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkTrainButton;
        private System.Windows.Forms.NumericUpDown carriageCountNumericUpDown;
        private System.Windows.Forms.TextBox carriageTypesTextBox;
        private System.Windows.Forms.NumericUpDown maxCarriageCountNumericUpDown;
        private System.Windows.Forms.TextBox allowedCarriageTypesTextBox;
    }
}

