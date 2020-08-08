namespace COMP123_Assignment4
{
    partial class BMICalculator
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.myWeightLabel = new System.Windows.Forms.Label();
            this.myHeightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.metricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.bMITextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.bMIScaleTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.myWeightLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.myHeightLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.heightTextBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.weightTextBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.metricRadioButton, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.ImperialRadioButton, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.bMITextBox, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.calculateButton, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.bMIScaleTextBox, 0, 4);
            this.tableLayoutPanel.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(320, 480);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // myWeightLabel
            // 
            this.myWeightLabel.AutoSize = true;
            this.myWeightLabel.Location = new System.Drawing.Point(10, 102);
            this.myWeightLabel.Margin = new System.Windows.Forms.Padding(10, 30, 3, 0);
            this.myWeightLabel.Name = "myWeightLabel";
            this.myWeightLabel.Size = new System.Drawing.Size(118, 42);
            this.myWeightLabel.TabIndex = 3;
            this.myWeightLabel.Text = "My Weight";
            // 
            // myHeightLabel
            // 
            this.myHeightLabel.AutoSize = true;
            this.myHeightLabel.Location = new System.Drawing.Point(10, 30);
            this.myHeightLabel.Margin = new System.Windows.Forms.Padding(10, 30, 3, 0);
            this.myHeightLabel.Name = "myHeightLabel";
            this.myHeightLabel.Size = new System.Drawing.Size(111, 42);
            this.myHeightLabel.TabIndex = 0;
            this.myHeightLabel.Text = "My Height";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(163, 30);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(127, 45);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(163, 102);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(127, 45);
            this.weightTextBox.TabIndex = 2;
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // metricRadioButton
            // 
            this.metricRadioButton.AutoSize = true;
            this.metricRadioButton.Location = new System.Drawing.Point(170, 154);
            this.metricRadioButton.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.metricRadioButton.Name = "metricRadioButton";
            this.metricRadioButton.Size = new System.Drawing.Size(127, 35);
            this.metricRadioButton.TabIndex = 5;
            this.metricRadioButton.Text = "Metric";
            this.metricRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Checked = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(10, 154);
            this.ImperialRadioButton.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(147, 35);
            this.ImperialRadioButton.TabIndex = 4;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // bMITextBox
            // 
            this.bMITextBox.Enabled = false;
            this.bMITextBox.Location = new System.Drawing.Point(10, 207);
            this.bMITextBox.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.bMITextBox.Name = "bMITextBox";
            this.bMITextBox.Size = new System.Drawing.Size(135, 45);
            this.bMITextBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(160, 195);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(140, 80);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate BMI";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // bMIScaleTextBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.bMIScaleTextBox, 2);
            this.bMIScaleTextBox.Location = new System.Drawing.Point(3, 291);
            this.bMIScaleTextBox.Multiline = true;
            this.bMIScaleTextBox.Name = "bMIScaleTextBox";
            this.bMIScaleTextBox.Size = new System.Drawing.Size(287, 128);
            this.bMIScaleTextBox.TabIndex = 8;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label myHeightLabel;
        private System.Windows.Forms.Label myWeightLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton metricRadioButton;
        private System.Windows.Forms.TextBox bMITextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox bMIScaleTextBox;
    }
}

