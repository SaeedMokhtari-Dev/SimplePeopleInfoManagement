using System;
using System.Linq;
using System.Windows.Forms;
using SimplePeopleInfoManagement.DbContext;
using SimplePeopleInfoManagement.Entity;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

namespace SimplePeopleInfoManagement
{
    public partial class PersonForm : Form
    {
        //private PeopleInfoDbContext _context;
        public PersonForm()
        {
            //  _context = ConnectionHelper.getDbConntext();
            InitializeComponent();
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            getCategories();
        }
        private void getCategories()
        {
            using (DbConnection connection = new SQLiteConnection(@"data source=.\db\PeopleInfoDb\PeopleInfoDb.sqlite; Foreign Key Constraints=On;"))
            {
                // This is important! Else the in memory database will not work.
                connection.Open();

                using (var _context = new PeopleInfoDbContext(connection, true))
                {
                    // ReSharper disable once UnusedVariable
                    var categories = _context.Categories.ToList().Select(w => new
            ComboboxItem()
                    {
                        Value = w.Id,
                        Text = w.Title
                    }).ToList();
                    if (categories.Any())
                    {
                        foreach (var category in categories)
                        {
                            category_group.Items.Add(category);
                        }
                    }

                }
            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {

        }

        private void saveAndNew_btn_Click(object sender, EventArgs e)
        {
            InsertNewPerson();
        }
        private void InsertNewPerson()
        {
            using (DbConnection connection = new SQLiteConnection(@"data source=.\db\PeopleInfoDb\PeopleInfoDb.sqlite; Foreign Key Constraints=On;"))
            {
                // This is important! Else the in memory database will not work.
                connection.Open();

                using (var _context = new PeopleInfoDbContext(connection, true))
                {
                    try
                    {
                        int? categoryId = category_group.SelectedItem != null ? (int?)((ComboboxItem)category_group.SelectedItem).Value : null;
                        Person person = new Person
                        {
                            FirstName = firstName_txt.Text,
                            LastName = lastName_txt.Text,
                            Address = address_txt.Text,
                            BirthDate = birthDate_txt.Text,
                            CategoryId = categoryId,
                            Email = email_txt.Text,
                            FatherName = fatherName_txt.Text,
                            Instagram = instagram_txt.Text,
                            Job = job_txt.Text,
                            Mobile = mobile_txt.Text,
                            NationalId = nationalId_txt.Text,
                            NationalSeries = nationalSeries_txt.Text,
                            PhoneNumber = phoneNumber_txt.Text,
                            Qualification = qualification_txt.Text,
                            Sex = manSex_radio.Checked ? "مرد" : "زن",
                            Telegram = telegram_txt.Text,
                            Description = description_txt.Text,
                            CreatedUtc = DateTime.Now
                        };

                        person = _context.Persons.Add(person);
                        _context.SaveChanges();

                        Directory.CreateDirectory($"PersonData/{person.Id}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            InsertNewPerson();
        }
    }
    public class ComboboxItem
    {
        public ComboboxItem()
        {

        }
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}