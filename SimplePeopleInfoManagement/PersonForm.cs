using System;
using System.Linq;
using System.Windows.Forms;
using SimplePeopleInfoManagement.DbContext;
using SimplePeopleInfoManagement.Entity;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Data.Entity;

namespace SimplePeopleInfoManagement
{
    public partial class PersonForm : Form
    {
        //private PeopleInfoDbContext _context;
        public PersonForm()
        {
            
            //  _context = ConnectionHelper.getDbConntext();
            InitializeComponent();
            getCategories();
        }
        public PersonForm(int id)
        {
            InitializeComponent();
            getCategories();
            loadPersonAndSetToForm(id);
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            
        }
        private void getCategories()
        {
            using (DbConnection connection = new SQLiteConnection(ConnectionHelper.ConnectionString))
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
            using (DbConnection connection = new SQLiteConnection(ConnectionHelper.ConnectionString))
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
                        if (string.IsNullOrEmpty(id_txt.Text))
                        {  
                            person = _context.People.Add(person);
                        }
                        else
                        {
                            person.Id = Convert.ToInt32(id_txt.Text);
                            _context.People.Attach(person);
                            _context.Entry(person).State = EntityState.Modified;
                        }
                        _context.SaveChanges();
                        if(!Directory.Exists($"PersonData/{person.Id}"))
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

        private void loadPersonAndSetToForm(int id)
        {
            using (DbConnection connection = new SQLiteConnection(ConnectionHelper.ConnectionString))
            {
                // This is important! Else the in memory database will not work.
                connection.Open();

                using (var _context = new PeopleInfoDbContext(connection, true))
                {
                    try
                    {
                        var person = _context.People.Find(id);
                        if (person == null)
                            throw new Exception("Person Not Found");

                        id_txt.Text = person.Id.ToString();
                        //category_group.SelectedItem = new ComboboxItem(person.Category.Title, person.CategoryId);
                        //category_group.SelectedIndex = category_group.Items.IndexOf(new ComboboxItem(person.Category.Title, person.CategoryId));
                        category_group.SelectedIndex = category_group.FindString(person.Category.Title);
                        firstName_txt.Text = person.FirstName;
                        lastName_txt.Text = person.LastName;
                        fatherName_txt.Text = person.FatherName;
                        birthDate_txt.Text = person.BirthDate;                        
                        nationalId_txt.Text = person.NationalId;
                        nationalSeries_txt.Text = person.NationalSeries;
                        mobile_txt.Text = person.Mobile;
                        phoneNumber_txt.Text = person.PhoneNumber;
                        address_txt.Text = person.Address;
                        manSex_radio.Checked = person.Sex == "مرد";
                        womanSex_radio.Checked = person.Sex == "زن";
                        telegram_txt.Text = person.Telegram;
                        instagram_txt.Text = person.Instagram;
                        email_txt.Text = person.Email;
                        job_txt.Text = person.Job;
                        qualification_txt.Text = person.Qualification;
                        description_txt.Text = person.Description;

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
            }
        }
    }
    public class ComboboxItem
    {
        public ComboboxItem()
        {

        }

        public ComboboxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }

        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}