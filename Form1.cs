using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPlayground
{
    public partial class Form1 : Form
    {
        public event ColorChangedEventHandler ColorChangedEvent;
        public event TextChangedEventHandler TextChangedEvent;

        public Form1()
        {
            InitializeComponent();

            cmbColors.Items.Add("Red");
            cmbColors.Items.Add("Green");
            cmbColors.Items.Add("Blue");
            cmbColors.SelectedIndex = 0;

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

        private void UpdateLabelColor(object sender, ColorEventArgs e)
        {
            lblStatus.ForeColor = Color.FromName(e.ColorName);
        }

        private void ShowNotification(object sender, ColorEventArgs e)
        {
            MessageBox.Show($"Color changed to {e.ColorName}");
        }

        private void UpdateLabelText(object sender, EventArgs e)
        {
            lblStatus.Text = "Current: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }

}
