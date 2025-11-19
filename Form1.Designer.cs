namespace EventPlayground
{
    partial class Form1
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
            lblStatus = new Label();
            cmbColors = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14F);
            lblStatus.Location = new Point(104, 62);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(262, 32);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Welcome to Events Lab";
            // 
            // cmbColors
            // 
            cmbColors.FormattingEnabled = true;
            cmbColors.Location = new Point(104, 106);
            cmbColors.Name = "cmbColors";
            cmbColors.Size = new Size(151, 28);
            cmbColors.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(104, 159);
            button1.Name = "button1";
            button1.Size = new Size(195, 29);
            button1.TabIndex = 2;
            button1.Text = "Change Color";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.btnChangeColor_Click;
            // 
            // button2
            // 
            button2.Location = new Point(104, 210);
            button2.Name = "button2";
            button2.Size = new Size(195, 29);
            button2.TabIndex = 3;
            button2.Text = "Change Text";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.btnChangeText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbColors);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private ComboBox cmbColors;
        private Button button1;
        private Button button2;
    }
}