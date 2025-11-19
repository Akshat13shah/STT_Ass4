using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventPlayground1
{
    public partial class Form1 : Form
    {
        public event ColorChangedEventHandler ColorChangedEvent;
        public event TextChangedEventHandler TextChangedEvent;

        public Form1()
        {
            InitializeComponent();

            // Fill ComboBox
            cmbColors.Items.Add("Red");
            cmbColors.Items.Add("Green");
            cmbColors.Items.Add("Blue");
            cmbColors.SelectedIndex = 0;

            // MULTICAST EVENT SUBSCRIBERS
            ColorChangedEvent += UpdateLabelColor;
            ColorChangedEvent += ShowNotification;

            TextChangedEvent += UpdateLabelText;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            string selected = cmbColors.SelectedItem.ToString();
            var args = new ColorEventArgs(selected);
            ColorChangedEvent?.Invoke(this, args);
        }

        private void btnChangeText_Click(object sender, EventArgs e)
        {
            TextChangedEvent?.Invoke(this, EventArgs.Empty);
        }

        // Subscriber 1
        private void UpdateLabelColor(object sender, ColorEventArgs e)
        {
            lblStatus.ForeColor = Color.FromName(e.ColorName);
        }

        // Subscriber 2
        private void ShowNotification(object sender, ColorEventArgs e)
        {
            MessageBox.Show($"Color changed to {e.ColorName}");
        }

        // For TextChangedEvent
        private void UpdateLabelText(object sender, EventArgs e)
        {
            lblStatus.Text = "Current: " + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}

