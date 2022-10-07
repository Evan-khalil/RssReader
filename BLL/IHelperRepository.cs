using System.Windows.Forms;

namespace BLL
{
    public interface IHelperRepository
    {
        void FillComboBox(ComboBox comboBox);
        void FillCategories(ListBox listBox, ComboBox comboBox);
        void FillFeeds(ListView listView, ListBox listBox);
    }
}
