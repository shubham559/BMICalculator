namespace BMI_Calculator
{
    partial class BMI_Calculator_Form
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
            this.BMICalculatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Done_Button = new System.Windows.Forms.Button();
            this.Zero_Button = new System.Windows.Forms.Button();
            this.Three_Button = new System.Windows.Forms.Button();
            this.Two_Button = new System.Windows.Forms.Button();
            this.One_Button = new System.Windows.Forms.Button();
            this.SIX_Button = new System.Windows.Forms.Button();
            this.Five_Button = new System.Windows.Forms.Button();
            this.Four_Button = new System.Windows.Forms.Button();
            this.Nine_Button = new System.Windows.Forms.Button();
            this.Eight_Button = new System.Windows.Forms.Button();
            this.Seven_Button = new System.Windows.Forms.Button();
            this.Resut_Label = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Decimal_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Output_Label = new System.Windows.Forms.Label();
            this.BMICalculatorTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculatorTableLayoutPanel
            // 
            this.BMICalculatorTableLayoutPanel.ColumnCount = 4;
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Three_Button, 2, 3);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Two_Button, 1, 3);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.One_Button, 0, 3);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.SIX_Button, 2, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Five_Button, 1, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Four_Button, 0, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Nine_Button, 2, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Eight_Button, 1, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Seven_Button, 0, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Back_Button, 3, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Decimal_Button, 2, 4);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Clear_Button, 3, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Done_Button, 3, 3);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Zero_Button, 0, 4);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Resut_Label, 0, 0);
            this.BMICalculatorTableLayoutPanel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMICalculatorTableLayoutPanel.Location = new System.Drawing.Point(188, 161);
            this.BMICalculatorTableLayoutPanel.Name = "BMICalculatorTableLayoutPanel";
            this.BMICalculatorTableLayoutPanel.RowCount = 5;
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMICalculatorTableLayoutPanel.Size = new System.Drawing.Size(400, 323);
            this.BMICalculatorTableLayoutPanel.TabIndex = 0;
            // 
            // Done_Button
            // 
            this.Done_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Done_Button.BackColor = System.Drawing.Color.DarkOrange;
            this.Done_Button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Done_Button.Location = new System.Drawing.Point(303, 195);
            this.Done_Button.Name = "Done_Button";
            this.BMICalculatorTableLayoutPanel.SetRowSpan(this.Done_Button, 2);
            this.Done_Button.Size = new System.Drawing.Size(94, 125);
            this.Done_Button.TabIndex = 11;
            this.Done_Button.Tag = "Done";
            this.Done_Button.Text = "Done";
            this.Done_Button.UseVisualStyleBackColor = false;
            this.Done_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Zero_Button
            // 
            this.Zero_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Zero_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.Zero_Button, 2);
            this.Zero_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Zero_Button.Location = new System.Drawing.Point(3, 259);
            this.Zero_Button.Name = "Zero_Button";
            this.Zero_Button.Size = new System.Drawing.Size(194, 61);
            this.Zero_Button.TabIndex = 10;
            this.Zero_Button.Tag = "Zero";
            this.Zero_Button.Text = "0";
            this.Zero_Button.UseVisualStyleBackColor = false;
            this.Zero_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Three_Button
            // 
            this.Three_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Three_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Three_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Three_Button.Location = new System.Drawing.Point(203, 195);
            this.Three_Button.Name = "Three_Button";
            this.Three_Button.Size = new System.Drawing.Size(94, 58);
            this.Three_Button.TabIndex = 8;
            this.Three_Button.Tag = "3";
            this.Three_Button.Text = "3";
            this.Three_Button.UseVisualStyleBackColor = false;
            this.Three_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Two_Button
            // 
            this.Two_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Two_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Two_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Two_Button.Location = new System.Drawing.Point(103, 195);
            this.Two_Button.Name = "Two_Button";
            this.Two_Button.Size = new System.Drawing.Size(94, 58);
            this.Two_Button.TabIndex = 7;
            this.Two_Button.Tag = "2";
            this.Two_Button.Text = "2";
            this.Two_Button.UseVisualStyleBackColor = false;
            this.Two_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // One_Button
            // 
            this.One_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.One_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.One_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.One_Button.Location = new System.Drawing.Point(3, 195);
            this.One_Button.Name = "One_Button";
            this.One_Button.Size = new System.Drawing.Size(94, 58);
            this.One_Button.TabIndex = 6;
            this.One_Button.Tag = "1";
            this.One_Button.Text = "1";
            this.One_Button.UseVisualStyleBackColor = false;
            this.One_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // SIX_Button
            // 
            this.SIX_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SIX_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SIX_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SIX_Button.Location = new System.Drawing.Point(203, 131);
            this.SIX_Button.Name = "SIX_Button";
            this.SIX_Button.Size = new System.Drawing.Size(94, 58);
            this.SIX_Button.TabIndex = 5;
            this.SIX_Button.Tag = "6";
            this.SIX_Button.Text = "6";
            this.SIX_Button.UseVisualStyleBackColor = false;
            this.SIX_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Five_Button
            // 
            this.Five_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Five_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Five_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Five_Button.Location = new System.Drawing.Point(103, 131);
            this.Five_Button.Name = "Five_Button";
            this.Five_Button.Size = new System.Drawing.Size(94, 58);
            this.Five_Button.TabIndex = 4;
            this.Five_Button.Tag = "5";
            this.Five_Button.Text = "5";
            this.Five_Button.UseVisualStyleBackColor = false;
            this.Five_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Four_Button
            // 
            this.Four_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Four_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Four_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Four_Button.Location = new System.Drawing.Point(3, 131);
            this.Four_Button.Name = "Four_Button";
            this.Four_Button.Size = new System.Drawing.Size(94, 58);
            this.Four_Button.TabIndex = 3;
            this.Four_Button.Tag = "4";
            this.Four_Button.Text = "4";
            this.Four_Button.UseVisualStyleBackColor = false;
            this.Four_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Nine_Button
            // 
            this.Nine_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nine_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Nine_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nine_Button.Location = new System.Drawing.Point(203, 67);
            this.Nine_Button.Name = "Nine_Button";
            this.Nine_Button.Size = new System.Drawing.Size(94, 58);
            this.Nine_Button.TabIndex = 2;
            this.Nine_Button.Tag = "9";
            this.Nine_Button.Text = "9";
            this.Nine_Button.UseVisualStyleBackColor = false;
            this.Nine_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Eight_Button
            // 
            this.Eight_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Eight_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Eight_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Eight_Button.Location = new System.Drawing.Point(103, 67);
            this.Eight_Button.Name = "Eight_Button";
            this.Eight_Button.Size = new System.Drawing.Size(94, 58);
            this.Eight_Button.TabIndex = 1;
            this.Eight_Button.Tag = "8";
            this.Eight_Button.Text = "8";
            this.Eight_Button.UseVisualStyleBackColor = false;
            this.Eight_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Seven_Button
            // 
            this.Seven_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Seven_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Seven_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Seven_Button.Location = new System.Drawing.Point(3, 67);
            this.Seven_Button.Name = "Seven_Button";
            this.Seven_Button.Size = new System.Drawing.Size(94, 58);
            this.Seven_Button.TabIndex = 0;
            this.Seven_Button.Tag = "7";
            this.Seven_Button.Text = "7";
            this.Seven_Button.UseVisualStyleBackColor = false;
            this.Seven_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Resut_Label
            // 
            this.Resut_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resut_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Resut_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.Resut_Label, 4);
            this.Resut_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resut_Label.Location = new System.Drawing.Point(3, 0);
            this.Resut_Label.Name = "Resut_Label";
            this.Resut_Label.Size = new System.Drawing.Size(394, 64);
            this.Resut_Label.TabIndex = 1;
            this.Resut_Label.Tag = "Result";
            this.Resut_Label.Text = "0";
            this.Resut_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Back_Button
            // 
            this.Back_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Back_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Back_Button.BackgroundImage = global::BMI_Calculator.Properties.Resources.backbutton;
            this.Back_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back_Button.Location = new System.Drawing.Point(303, 67);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(94, 58);
            this.Back_Button.TabIndex = 2;
            this.Back_Button.Tag = "Back";
            this.Back_Button.UseVisualStyleBackColor = false;
            this.Back_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Decimal_Button
            // 
            this.Decimal_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Decimal_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Decimal_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Decimal_Button.Location = new System.Drawing.Point(203, 259);
            this.Decimal_Button.Name = "Decimal_Button";
            this.Decimal_Button.Size = new System.Drawing.Size(94, 61);
            this.Decimal_Button.TabIndex = 10;
            this.Decimal_Button.Tag = "Decimal";
            this.Decimal_Button.Text = ".";
            this.Decimal_Button.UseVisualStyleBackColor = false;
            this.Decimal_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear_Button.BackColor = System.Drawing.Color.OrangeRed;
            this.Clear_Button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear_Button.Location = new System.Drawing.Point(303, 131);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(94, 58);
            this.Clear_Button.TabIndex = 5;
            this.Clear_Button.Tag = "Clear";
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Output_Label
            // 
            this.Output_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Output_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_Label.Location = new System.Drawing.Point(188, 48);
            this.Output_Label.Name = "Output_Label";
            this.Output_Label.Size = new System.Drawing.Size(97, 52);
            this.Output_Label.TabIndex = 1;
            this.Output_Label.Tag = "Result";
            this.Output_Label.Text = "0";
            this.Output_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Output_Label.Click += new System.EventHandler(this.Output_Result_Event);
            // 
            // BMI_Calculator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.BMICalculatorTableLayoutPanel);
            this.Controls.Add(this.Output_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMI_Calculator_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMI_Calculator_Form_Load);
            this.BMICalculatorTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMICalculatorTableLayoutPanel;
        private System.Windows.Forms.Button Seven_Button;
        private System.Windows.Forms.Button Done_Button;
        private System.Windows.Forms.Button Zero_Button;
        private System.Windows.Forms.Button Three_Button;
        private System.Windows.Forms.Button Two_Button;
        private System.Windows.Forms.Button One_Button;
        private System.Windows.Forms.Button SIX_Button;
        private System.Windows.Forms.Button Five_Button;
        private System.Windows.Forms.Button Four_Button;
        private System.Windows.Forms.Button Nine_Button;
        private System.Windows.Forms.Button Eight_Button;
        private System.Windows.Forms.Label Resut_Label;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Decimal_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Label Output_Label;
    }
}

