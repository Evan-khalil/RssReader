using System.Windows.Forms;

namespace BLL
{
    public class IEnable : IEnableRepository
    {
        public void IsFeedEmpty(TextBox textBox, TextBox textBox1, ComboBox comboBox, ComboBox comboBox1, Button button)
        {
            if (textBox.Text != "" && textBox1.Text != "" && comboBox.SelectedIndex != -1 && comboBox1.SelectedIndex != -1)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        public void IsFeedSelected(ListView listView, Button button)
        {
            if (listView.SelectedItems.Count != 0)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        public void IsCategoryEditable(ListBox listBox, Button button, TextBox textBox)
        {
            if (listBox.SelectedItems.Count != 0 && textBox.Text != "")
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        public void IsCategoryEmpty(TextBox textBox, Button button)
        {
            if (textBox.Text != "")
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        public void IsCategorySelected(ListBox listBox, Button button)
        {
            if (listBox.SelectedItems.Count != 0)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        public void IsFeedEditable(TextBox textBox, TextBox textBox1, ComboBox comboBox, ComboBox comboBox1, Button button, ListView listView)
        {
            if (textBox.Text != "" && textBox1.Text != "" && comboBox.SelectedIndex != -1 && comboBox1.SelectedIndex != -1 && listView.SelectedItems.Count != 0)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }
    }
}
