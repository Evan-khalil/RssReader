using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BLL
{
    public class IHelpers : IHelperRepository
    {
        private readonly IRepository _repository = new Repository();

        public void FillCategories(ListBox listBox, ComboBox comboBox)
        {
            try
            {
                comboBox.Items.Clear();
                comboBox.Items.Clear();
                foreach (DataLayer.Category category in _repository.GetCategories())
                {
                    listBox.Items.Add(category.Name);
                    comboBox.Items.Add(category.Name);
                }
            }
            catch (Exception)
            {
            }
        }

        public void FillComboBox(ComboBox comboBox)
        {
            comboBox.Items.Add(500);
            comboBox.Items.Add(1000);
            comboBox.Items.Add(1500);
            comboBox.Items.Add(2000);
        }

        public void FillFeeds(ListView listView, ListBox listBox)
        {
            try
            {
                listView.Items.Clear();
                List<DataLayer.Category> CategoryList = _repository.GetCategories();
                foreach (DataLayer.Category category in CategoryList)
                {
                    if(category.Name.Equals(listBox.SelectedItems[0].ToString()))
                    {
                        foreach (DataLayer.Feed feed in category.Feeds)
                        {
                            string episodes = feed.Episodes.Count().ToString();
                            string[] anRow = { feed.Title, episodes, feed.Intervall.ToString(), feed.CategoryName };
                            ListViewItem listViewItem = new ListViewItem(anRow);
                            listView.Items.Add(listViewItem);
                        }
                    }                    
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
