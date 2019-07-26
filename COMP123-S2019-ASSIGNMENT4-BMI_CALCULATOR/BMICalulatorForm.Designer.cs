namespace COMP123_S2019_ASSIGNMENT4_BMI_CALCULATOR
{
    partial class BMICalculatorForm
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
            this.UnitGroupBox = new System.Windows.Forms.GroupBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMILabel = new System.Windows.Forms.Label();
            this.BMICategoryOutputBox = new System.Windows.Forms.TextBox();
            this.ImperialLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MyWeightTextBox = new System.Windows.Forms.TextBox();
            this.MyHeightTextBox = new System.Windows.Forms.TextBox();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.BMIOutputLabel = new System.Windows.Forms.Label();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.UnitGroupBox.SuspendLayout();
            this.ImperialLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnitGroupBox
            // 
            this.UnitGroupBox.Controls.Add(this.ImperialRadioButton);
            this.UnitGroupBox.Controls.Add(this.MetricRadioButton);
            this.UnitGroupBox.Location = new System.Drawing.Point(15, 2);
            this.UnitGroupBox.Name = "UnitGroupBox";
            this.UnitGroupBox.Size = new System.Drawing.Size(274, 80);
            this.UnitGroupBox.TabIndex = 1;
            this.UnitGroupBox.TabStop = false;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Checked = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(9, 28);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(154, 28);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 0;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(21, 241);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(136, 36);
            this.CalculateBMIButton.TabIndex = 2;
            this.CalculateBMIButton.TabStop = false;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(162, 241);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(124, 36);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.TabStop = false;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMILabel
            // 
            this.BMILabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BMILabel.AutoSize = true;
            this.BMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMILabel.Location = new System.Drawing.Point(19, 282);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(134, 31);
            this.BMILabel.TabIndex = 4;
            this.BMILabel.Text = "Your BMI:";
            this.BMILabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BMICategoryOutputBox
            // 
            this.BMICategoryOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICategoryOutputBox.BackColor = System.Drawing.Color.White;
            this.BMICategoryOutputBox.ForeColor = System.Drawing.Color.Black;
            this.BMICategoryOutputBox.Location = new System.Drawing.Point(12, 329);
            this.BMICategoryOutputBox.Multiline = true;
            this.BMICategoryOutputBox.Name = "BMICategoryOutputBox";
            this.BMICategoryOutputBox.ReadOnly = true;
            this.BMICategoryOutputBox.Size = new System.Drawing.Size(280, 100);
            this.BMICategoryOutputBox.TabIndex = 5;
            this.BMICategoryOutputBox.TabStop = false;
            this.BMICategoryOutputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ImperialLayoutPanel
            // 
            this.ImperialLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialLayoutPanel.ColumnCount = 2;
            this.ImperialLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.10949F));
            this.ImperialLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.89051F));
            this.ImperialLayoutPanel.Controls.Add(this.MyWeightTextBox, 1, 1);
            this.ImperialLayoutPanel.Controls.Add(this.MyHeightLabel, 0, 0);
            this.ImperialLayoutPanel.Controls.Add(this.MyWeightLabel, 0, 1);
            this.ImperialLayoutPanel.Controls.Add(this.MyHeightTextBox, 1, 0);
            this.ImperialLayoutPanel.Location = new System.Drawing.Point(12, 88);
            this.ImperialLayoutPanel.Name = "ImperialLayoutPanel";
            this.ImperialLayoutPanel.RowCount = 2;
            this.ImperialLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialLayoutPanel.Size = new System.Drawing.Size(280, 117);
            this.ImperialLayoutPanel.TabIndex = 7;
            // 
            // MyWeightTextBox
            // 
            this.MyWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeightTextBox.BackColor = System.Drawing.Color.White;
            this.MyWeightTextBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.MyWeightTextBox.Location = new System.Drawing.Point(157, 68);
            this.MyWeightTextBox.Name = "MyWeightTextBox";
            this.MyWeightTextBox.Size = new System.Drawing.Size(120, 38);
            this.MyWeightTextBox.TabIndex = 3;
            this.MyWeightTextBox.TabStop = false;
            this.MyWeightTextBox.Text = "pounds";
            this.MyWeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MyWeightTextBox.Click += new System.EventHandler(this.MyWeightTextBox_Click);
            this.MyWeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MyWeightTextBox_Validating);
            this.MyWeightTextBox.Validated += new System.EventHandler(this.MyWeightTextBox_Validated);
            // 
            // MyHeightTextBox
            // 
            this.MyHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeightTextBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.MyHeightTextBox.Location = new System.Drawing.Point(157, 10);
            this.MyHeightTextBox.Name = "MyHeightTextBox";
            this.MyHeightTextBox.Size = new System.Drawing.Size(120, 38);
            this.MyHeightTextBox.TabIndex = 2;
            this.MyHeightTextBox.TabStop = false;
            this.MyHeightTextBox.Text = "inches";
            this.MyHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MyHeightTextBox.Click += new System.EventHandler(this.MyHeightTextBox_Click);
            this.MyHeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MyHeightTextBox_Validating);
            this.MyHeightTextBox.Validated += new System.EventHandler(this.MyHeightTextBox_Validated);
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Location = new System.Drawing.Point(3, 0);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(148, 58);
            this.MyHeightLabel.TabIndex = 0;
            this.MyHeightLabel.Text = "My height";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 58);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(148, 59);
            this.MyWeightLabel.TabIndex = 1;
            this.MyWeightLabel.Text = "My weight";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMIOutputLabel
            // 
            this.BMIOutputLabel.BackColor = System.Drawing.Color.White;
            this.BMIOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIOutputLabel.Location = new System.Drawing.Point(162, 282);
            this.BMIOutputLabel.Name = "BMIOutputLabel";
            this.BMIOutputLabel.Size = new System.Drawing.Size(124, 41);
            this.BMIOutputLabel.TabIndex = 8;
            this.BMIOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(20, 202);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(272, 36);
            this.ErrorMessageLabel.TabIndex = 9;
            this.ErrorMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorMessageLabel.Visible = false;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.BMIOutputLabel);
            this.Controls.Add(this.ImperialLayoutPanel);
            this.Controls.Add(this.BMICategoryOutputBox);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.UnitGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.UnitGroupBox.ResumeLayout(false);
            this.UnitGroupBox.PerformLayout();
            this.ImperialLayoutPanel.ResumeLayout(false);
            this.ImperialLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox UnitGroupBox;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.TextBox BMICategoryOutputBox;
        private System.Windows.Forms.TableLayoutPanel ImperialLayoutPanel;
        private System.Windows.Forms.TextBox MyWeightTextBox;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox MyHeightTextBox;
        private System.Windows.Forms.Label BMIOutputLabel;
        private System.Windows.Forms.Label ErrorMessageLabel;
    }
}

