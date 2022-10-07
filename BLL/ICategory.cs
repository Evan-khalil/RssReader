using System;
using System.IO;
using System.Windows.Forms;

namespace BLL
{
    public class ICategory : ICategoryRepository
    {
        public void Add(string directory)
        {
            string Directory = directory;

            try
            {

                if (System.IO.Directory.Exists(Directory))
                {
                    MessageBox.Show(Directory + "already exists");
                }
                else
                {
                    System.IO.Directory.CreateDirectory(Directory);
                    MessageBox.Show(Directory + " created");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Edit(string New, string Old)
        {
            try
            {
                if (Directory.Exists(Old))
                {
                    Directory.Move(Old, New);
                    MessageBox.Show(Old + " changed to " + New);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Delete(string categoryName)
        {
            try
            {
                string Location = Directory.GetCurrentDirectory();
                string path = Path.Combine(Location, categoryName);
                Directory.Delete(path, true);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
