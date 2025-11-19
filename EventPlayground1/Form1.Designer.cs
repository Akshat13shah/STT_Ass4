namespace EventPlayground1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatus = new Label();
            cmbColors = new ComboBox();
            btnChangeColor = new Button();
            btnChangeText = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14F);
            lblStatus.Location = new Point(83, 38);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(262, 32);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Welcome to Events Lab";
            // 
            // cmbColors
            // 
            cmbColors.FormattingEnabled = true;
            cmbColors.Location = new Point(83, 100);
            cmbColors.Name = "cmbColors";
            cmbColors.Size = new Size(151, 28);
            cmbColors.TabIndex = 1;
            // 
            // btnChangeColor
            // 
            btnChangeColor.Location = new Point(83, 158);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new Size(151, 29);
            btnChangeColor.TabIndex = 2;
            btnChangeColor.Text = "Change Color";
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += btnChangeColor_Click;
            // 
            // btnChangeText
            // 
            btnChangeText.Location = new Point(83, 206);
            btnChangeText.Name = "btnChangeText";
            btnChangeText.Size = new Size(151, 29);
            btnChangeText.TabIndex = 3;
            btnChangeText.Text = "Change Text";
            btnChangeText.UseVisualStyleBackColor = true;
            btnChangeText.Click += btnChangeText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChangeText);
            Controls.Add(btnChangeColor);
            Controls.Add(cmbColors);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private ComboBox cmbColors;
        private Button btnChangeColor;
        private Button btnChangeText;
    }
}
