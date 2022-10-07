using System.Windows.Forms;

namespace BLL
{
    public interface IEnableRepository
    {
        void IsCategoryEmpty(TextBox textBox, Button button);
        void IsCategorySelected(ListBox listBox, Button button);
        void IsCategoryEditable(ListBox listBox, Button button, TextBox textBox);
        void IsFeedEmpty(TextBox textBox, TextBox textBox1, ComboBox comboBox, ComboBox comboBox1, Button button);
        void IsFeedEditable(TextBox textBox, TextBox textBox1, ComboBox comboBox, ComboBox comboBox1, Button button, ListView listView);
        void IsFeedSelected(ListView listView, Button button);
    }
}
