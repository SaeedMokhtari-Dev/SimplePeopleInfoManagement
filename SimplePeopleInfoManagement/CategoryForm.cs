using System;
using System.Windows.Forms;
using SimplePeopleInfoManagement.DbContext;
using SimplePeopleInfoManagement.Entity;
using System.Data.Common;
using System.Data.SQLite;

namespace SimplePeopleInfoManagement
{
    public partial class CategoryForm : Form
    {
        //private readonly PeopleInfoDbContext _context;
        public CategoryForm()
        {
            //_context = ConnectionHelper.getDbConntext();
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            InsertNewCategory();
        }
        private void saveAndNew_btn_Click(object sender, EventArgs e)
        {
            InsertNewCategory();
            
        }

        private void InsertNewCategory()
        {
            using (DbConnection connection = new SQLiteConnection(@"data source=.\db\PeopleInfoDb\PeopleInfoDb.sqlite; Foreign Key Constraints=On;"))
            {
                // This is important! Else the in memory database will not work.
                connection.Open();

                using (var _context = new PeopleInfoDbContext(connection, true))
                {
                    // ReSharper disable once UnusedVariable
                    Category category = new Category
                    {
                        Title = title_txt.Text,
                        Description = description_txt.Text,
                        CreatedUtc = DateTime.Now
                    };

                    _context.Categories.Add(category);
                    _context.SaveChanges();

                }
            }
            
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {

        }
    }
}