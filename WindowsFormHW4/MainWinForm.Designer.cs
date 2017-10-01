namespace WindowsFormHW4
{
    partial class MainWinForm
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
            this.labelForText = new System.Windows.Forms.Label();
            this.firstDate = new System.Windows.Forms.RadioButton();
            this.secondDate = new System.Windows.Forms.RadioButton();
            this.readyButton = new System.Windows.Forms.Button();
            this.thirdDate = new System.Windows.Forms.RadioButton();
            this.firstDateBox = new System.Windows.Forms.TextBox();
            this.secondDateBox = new System.Windows.Forms.TextBox();
            this.thirdDateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelForText
            // 
            this.labelForText.AutoSize = true;
            this.labelForText.Location = new System.Drawing.Point(24, 25);
            this.labelForText.Name = "labelForText";
            this.labelForText.Size = new System.Drawing.Size(436, 13);
            this.labelForText.TabIndex = 0;
            this.labelForText.Text = "Введите дату  в формате ГГГГ.ММ.ДД , чтобы узнать сколько времени осталось до";
            // 
            // firstDate
            // 
            this.firstDate.AutoSize = true;
            this.firstDate.Location = new System.Drawing.Point(51, 71);
            this.firstDate.Name = "firstDate";
            this.firstDate.Size = new System.Drawing.Size(64, 17);
            this.firstDate.TabIndex = 1;
            this.firstDate.TabStop = true;
            this.firstDate.Text = "firstDate";
            this.firstDate.UseVisualStyleBackColor = true;
            // 
            // secondDate
            // 
            this.secondDate.AutoSize = true;
            this.secondDate.Location = new System.Drawing.Point(51, 94);
            this.secondDate.Name = "secondDate";
            this.secondDate.Size = new System.Drawing.Size(85, 17);
            this.secondDate.TabIndex = 2;
            this.secondDate.TabStop = true;
            this.secondDate.Text = "radioButton2";
            this.secondDate.UseVisualStyleBackColor = true;
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(51, 165);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(75, 23);
            this.readyButton.TabIndex = 3;
            this.readyButton.Text = "Готово";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // thirdDate
            // 
            this.thirdDate.AutoSize = true;
            this.thirdDate.Location = new System.Drawing.Point(51, 117);
            this.thirdDate.Name = "thirdDate";
            this.thirdDate.Size = new System.Drawing.Size(85, 17);
            this.thirdDate.TabIndex = 4;
            this.thirdDate.TabStop = true;
            this.thirdDate.Text = "radioButton3";
            this.thirdDate.UseVisualStyleBackColor = true;
            // 
            // firstDateBox
            // 
            this.firstDateBox.Location = new System.Drawing.Point(68, 68);
            this.firstDateBox.Name = "firstDateBox";
            this.firstDateBox.Size = new System.Drawing.Size(100, 20);
            this.firstDateBox.TabIndex = 5;
            // 
            // secondDateBox
            // 
            this.secondDateBox.Location = new System.Drawing.Point(68, 94);
            this.secondDateBox.Name = "secondDateBox";
            this.secondDateBox.Size = new System.Drawing.Size(100, 20);
            this.secondDateBox.TabIndex = 6;
            // 
            // thirdDateBox
            // 
            this.thirdDateBox.Location = new System.Drawing.Point(68, 120);
            this.thirdDateBox.Name = "thirdDateBox";
            this.thirdDateBox.Size = new System.Drawing.Size(100, 20);
            this.thirdDateBox.TabIndex = 7;
            // 
            // MainWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 369);
            this.Controls.Add(this.thirdDateBox);
            this.Controls.Add(this.secondDateBox);
            this.Controls.Add(this.firstDateBox);
            this.Controls.Add(this.thirdDate);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.secondDate);
            this.Controls.Add(this.firstDate);
            this.Controls.Add(this.labelForText);
            this.Name = "MainWinForm";
            this.Text = "MainWinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForText;
        private System.Windows.Forms.RadioButton firstDate;
        private System.Windows.Forms.RadioButton secondDate;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.RadioButton thirdDate;
        private System.Windows.Forms.TextBox firstDateBox;
        private System.Windows.Forms.TextBox secondDateBox;
        private System.Windows.Forms.TextBox thirdDateBox;
    }
}