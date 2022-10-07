using BLL;
using System;
using System.IO;
using System.Windows.Forms;
using WindowsFormsTimer;

namespace RssProjct
{
    public partial class Form1 : Form
    {
        private readonly IRepository _repository = new Repository();
        private readonly IFeedRepository _feedRepository = new IFeed();
        private readonly IHelperRepository _helperRepository = new IHelpers();
        private readonly IUpdateRepository _iUpdateRepository = new IUpdateRepository();
        private readonly ICategoryRepository _categoryRepository = new ICategory();
        private readonly IEnableRepository _enableRepository = new IEnable();
        private string feedName;

        public Form1()
        {
            InitializeComponent();
            _helperRepository.FillCategories(lvCategory, cbCategory);
            _helperRepository.FillFeeds(lvFeeds, lvCategory);
            _helperRepository.FillComboBox(cbIntervall);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _iUpdateRepository.Update();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtCategory.Text;
                _categoryRepository.Add(input);
                lvCategory.Items.Add(input);
                cbCategory.Items.Add(input);
                txtCategory.Clear();
            }
            catch (Exception)
            {
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string NewName = txtCategory.Text;
                string OldName = lvCategory.SelectedItem.ToString();
                _categoryRepository.Edit(NewName, OldName);
                lvCategory.Items.Clear();
                _helperRepository.FillCategories(lvCategory, cbCategory);
                _helperRepository.FillFeeds(lvFeeds, lvCategory);
                txtCategory.Clear();
                txtCategory.Focus();
            }
            catch (Exception)
            {
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryRepository.Delete(lvCategory.SelectedItem.ToString());
                lvCategory.Items.Clear();
                _helperRepository.FillCategories(lvCategory, cbCategory);
                _helperRepository.FillFeeds(lvFeeds, lvCategory);
            }
            catch (Exception)
            {
            }
        }

        private async void btnAddFeed_Click(object sender, EventArgs e)
        {
            try
            {
                int updateIntevall = Convert.ToInt32(cbIntervall.Text);
                string folderDirection = Directory.GetCurrentDirectory() + @"\" + cbCategory.Text + @"\" + txtFeedName.Text + ".xml";
                await _feedRepository.Add(txtLink.Text, updateIntevall, folderDirection, txtFeedName.Text, cbCategory.Text);
                _repository.GetFeeds();
                _helperRepository.FillFeeds(lvFeeds, lvCategory);
            }
            catch (Exception)
            {
            }
        }

        private void lvFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection feedItems = lvFeeds.SelectedItems;
            lvEpisode.Clear();
            if (lvFeeds.SelectedItems.Count == 1)
            {
                string selectedItem = lvFeeds.SelectedItems[0].Text;
                feedName = selectedItem;
                System.Collections.Generic.List<DataLayer.Feed> feedList = _repository.GetFeeds();
                foreach (DataLayer.Feed feed in feedList)
                {
                    if (feed.Title.Equals(selectedItem))
                    {
                        foreach (DataLayer.Episode episode in feed.Episodes)
                        {
                            lvEpisode.Items.Add(episode.Title);
                        }
                    }
                }
            }
            _enableRepository.IsFeedSelected(lvFeeds, btnDeleteFeeds);
            _enableRepository.IsFeedEditable(txtLink, txtFeedName, cbCategory, cbIntervall, btnEditFeeds, lvFeeds);
        }

        private void lvEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDescription.Items.Clear();
            if (lvEpisode.SelectedItems.Count == 1)
            {
                string selectedEpisode = lvEpisode.SelectedItems[0].Text;
                System.Collections.Generic.List<DataLayer.Feed> feedList = _repository.GetFeeds();
                foreach (DataLayer.Feed item in feedList)
                {
                    foreach (DataLayer.Episode episode in item.Episodes)
                    {
                        if (episode.Title.Equals(selectedEpisode) && item.Title.Equals(feedName))
                        {
                            lvDescription.Items.Add(episode.Description + " " + episode.Date);
                        }
                    }
                }
            }
        }

        private void btnDeleteFeeds_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedFeedsOfListView = lvFeeds.SelectedItems[0].SubItems[0].Text;
                string selectedCtegory = lvFeeds.SelectedItems[0].SubItems[3].Text;
                _feedRepository.Delete(selectedFeedsOfListView, selectedCtegory);
            }
            catch (Exception)
            {
            }
        }

        private async void btnEditFeeds_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = lvFeeds.SelectedItems[0].SubItems[0].Text;
                string selectedCategory = lvFeeds.SelectedItems[0].SubItems[3].Text;
                int updateIntevall = Convert.ToInt32(cbIntervall.Text);
                string folderDirection = Directory.GetCurrentDirectory() + @"\" + cbCategory.Text + @"\" + selectedItem + ".xml";
                await _feedRepository.Delete(selectedItem, selectedCategory);
                _repository.GetFeeds();
                await _feedRepository.Add(txtLink.Text, updateIntevall, folderDirection, txtFeedName.Text, cbCategory.Text);
                _repository.GetFeeds();
                _helperRepository.FillFeeds(lvFeeds, lvCategory);
            }
            catch (Exception)
            {
            }
        }

        private void IndexChanged(object sender, EventArgs e)
        {
            _helperRepository.FillFeeds(lvFeeds, lvCategory);
            _enableRepository.IsCategorySelected(lvCategory, btnDeleteCategory);
            _enableRepository.IsCategoryEditable(lvCategory, btnEditCategory, txtCategory);
        }

        private void FeedNameChanged(object sender, EventArgs e)
        {
            _enableRepository.IsFeedEmpty(txtLink, txtFeedName, cbCategory, cbIntervall, btnAddFeed);
            _enableRepository.IsFeedEditable(txtLink, txtFeedName, cbCategory, cbIntervall, btnEditFeeds, lvFeeds);
        }

        private void UrlTextChanged(object sender, EventArgs e)
        {
            _enableRepository.IsFeedEmpty(txtLink, txtFeedName, cbCategory, cbIntervall, btnAddFeed);
            _enableRepository.IsFeedEditable(txtLink, txtFeedName, cbCategory, cbIntervall, btnEditFeeds, lvFeeds);
        }

        private void IntervalChanged(object sender, EventArgs e)
        {
            _enableRepository.IsFeedEmpty(txtLink, txtFeedName, cbCategory, cbIntervall, btnAddFeed);
            _enableRepository.IsFeedEditable(txtLink, txtFeedName, cbCategory, cbIntervall, btnEditFeeds, lvFeeds);
        }

        private void CategoryChanged(object sender, EventArgs e)
        {
            _enableRepository.IsFeedEmpty(txtLink, txtFeedName, cbCategory, cbIntervall, btnAddFeed);
            _enableRepository.IsFeedEditable(txtLink, txtFeedName, cbCategory, cbIntervall, btnEditFeeds, lvFeeds);
        }

        private void CategoryTextChanged(object sender, EventArgs e)
        {
            _enableRepository.IsCategoryEmpty(txtCategory, btnAdd);
            _enableRepository.IsCategoryEditable(lvCategory, btnEditCategory, txtCategory);
        }
    }
}

