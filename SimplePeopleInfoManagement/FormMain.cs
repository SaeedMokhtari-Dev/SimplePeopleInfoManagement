using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Zuby.ADGV;
using System.Data.Common;
using System.Data.SQLite;
using SimplePeopleInfoManagement.DbContext;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using SimplePeopleInfoManagement.Entity;

namespace SimplePeopleInfoManagement
{
    public partial class FormMain : Form
    {
        private DataTable _dataTable = null;
        private DataSet _dataSet = null;

        private bool _testtranslations = false;
        private bool _testtranslationsFromFile = false;
        private object[][] _inrows = new object[][] { };

        public FormMain()
        {
            InitializeComponent();

            //set localization strings
            Dictionary<string, string> translations = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> translation in AdvancedDataGridView.Translations)
            {
                if (!translations.ContainsKey(translation.Key))
                    translations.Add(translation.Key, "." + translation.Value);
            }

            foreach (KeyValuePair<string, string> translation in AdvancedDataGridViewSearchToolBar.Translations)
            {
                if (!translations.ContainsKey(translation.Key))
                    translations.Add(translation.Key, "." + translation.Value);
            }

            if (_testtranslations)
            {
                AdvancedDataGridView.SetTranslations(translations);
                AdvancedDataGridViewSearchToolBar.SetTranslations(translations);
            }

            if (_testtranslationsFromFile)
            {
                AdvancedDataGridView.SetTranslations(AdvancedDataGridView.LoadTranslationsFromFile("lang.json"));
                AdvancedDataGridViewSearchToolBar.SetTranslations(
                    AdvancedDataGridViewSearchToolBar.LoadTranslationsFromFile("lang.json"));
            }

            //initialize dataset
            _dataTable = new DataTable();
            _dataSet = new DataSet();

            //initialize bindingsource
            bindingSource_main.DataSource = _dataSet;

            //initialize datagridview
            advancedDataGridView_main.SetDoubleBuffered();
            advancedDataGridView_main.DataSource = bindingSource_main;

            //set bindingsource
            SetTestData();
        }

        public FormMain(object[][] inrows)
            : this()
        {
            _inrows = inrows;
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            //add test data to bindsource
            AddTestData();
        }

        private void SetTestData()
        {
            _dataTable = _dataSet.Tables.Add("TableTest");
            _dataTable.Columns.Add("Id", typeof(int));
            _dataTable.Columns.Add("FirstName", typeof(string));
            _dataTable.Columns.Add("LastName", typeof(string));
            _dataTable.Columns.Add("FatherName", typeof(string));
            _dataTable.Columns.Add("BirthDate", typeof(string));
            _dataTable.Columns.Add("NationalId", typeof(string));
            _dataTable.Columns.Add("NationalSeries", typeof(string));
            _dataTable.Columns.Add("Mobile", typeof(string));
            _dataTable.Columns.Add("PhoneNumber", typeof(string));
            _dataTable.Columns.Add("Email", typeof(string));
            _dataTable.Columns.Add("Category", typeof(string));
            _dataTable.Columns.Add("Address", typeof(string));
            _dataTable.Columns.Add("Sex", typeof(string));
            _dataTable.Columns.Add("Telegram", typeof(string));
            _dataTable.Columns.Add("Instagram", typeof(string));
            _dataTable.Columns.Add("Job", typeof(string));
            _dataTable.Columns.Add("Qualification", typeof(string));
            _dataTable.Columns.Add("Documents", typeof(Bitmap));
            _dataTable.Columns.Add("Edit", typeof(Bitmap));
            _dataTable.Columns.Add("Delete", typeof(Bitmap));

            bindingSource_main.DataMember = _dataTable.TableName;

            advancedDataGridViewSearchToolBar_main.SetColumns(advancedDataGridView_main.Columns);
        }

        private void AddTestData()
        {
            /*_dataTable.Rows.Add(new PersonModel()
            {
                Id=22,
                FirstName = "سعید",
                LastName = "مختاری"
            });*/

        }
        private void getPeople()
        {
            using (DbConnection connection = new SQLiteConnection(@"data source=.\db\PeopleInfoDb\PeopleInfoDb.sqlite; Foreign Key Constraints=On;"))
            {
                // This is important! Else the in memory database will not work.
                connection.Open();

                using (var _context = new PeopleInfoDbContext(connection, true))
                {
                    // ReSharper disable once UnusedVariable
                    var people = _context.People.ToList();
                    _dataTable.Clear();

                    foreach (var item in people)
                    {
                        object[] newrow = new object[]
                        {
                            item.Id,
                            item.FirstName,
                            item.LastName,
                            item.FatherName,
                            item.BirthDate,
                            item.NationalId,
                            item.NationalSeries,
                            item.Mobile,
                            item.PhoneNumber,
                            item.Email,
                            item.Category?.Title,
                            item.Address,
                            item.Sex,
                            item.Telegram,
                            item.Instagram,
                            item.Job,
                            item.Qualification,
                            Image.FromFile(Path.Combine(Application.StartupPath, "Images", "docs.png")),
                            Image.FromFile(Path.Combine(Application.StartupPath, "Images", "edit.png")),
                            Image.FromFile(Path.Combine(Application.StartupPath, "Images", "delete.png")),
                    };
                        _dataTable.Rows.Add(newrow);
                    }

                }
            }

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //add test data to bindsource
            //AddTestData();
            getPeople();

            //setup datagridview
            advancedDataGridView_main.SetFilterAndSortEnabled(advancedDataGridView_main.Columns["Id"], true);
            advancedDataGridView_main.SetFilterChecklistEnabled(advancedDataGridView_main.Columns["FirstName"], true);
            advancedDataGridView_main.SetFilterChecklistEnabled(advancedDataGridView_main.Columns["LastName"], true);
            advancedDataGridView_main.SetFilterChecklistEnabled(advancedDataGridView_main.Columns["FatherName"], true);
            advancedDataGridView_main.SetFilterChecklistEnabled(advancedDataGridView_main.Columns["BirthDate"], true);
            advancedDataGridView_main.SetFilterChecklistEnabled(advancedDataGridView_main.Columns["NationalId"], true);
            advancedDataGridView_main.SetFilterChecklistEnabled(advancedDataGridView_main.Columns["NationalSeries"], true);
            advancedDataGridView_main.SetFilterChecklistEnabled(advancedDataGridView_main.Columns["Mobile"], true);
            advancedDataGridView_main.SetFilterChecklistEnabled(advancedDataGridView_main.Columns["Address"], true);
            advancedDataGridView_main.SetFilterChecklistEnabled(advancedDataGridView_main.Columns["CategoryId"], true);



            foreach (DataGridViewColumn column in advancedDataGridView_main.Columns)
                advancedDataGridView_main.ShowMenuStrip(column);
        }

        private void advancedDataGridView_main_FilterStringChanged(object sender,
            Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            //eventually set the FilterString here
            //if e.Cancel is set to true one have to update the datasource here using
            //bindingSource_main.Filter = advancedDataGridView_main.FilterString;
            //otherwise it will be updated by the component

            //sample use of the override string filter
            /*string stringcolumnfilter = textBox_strfilter.Text;
            if (!String.IsNullOrEmpty(stringcolumnfilter))
                e.FilterString += (!String.IsNullOrEmpty(e.FilterString) ? " AND " : "") +
                                  String.Format("string LIKE '%{0}%'", stringcolumnfilter.Replace("'", "''"));

            textBox_filter.Text = e.FilterString;*/
        }

        private void advancedDataGridView_main_SortStringChanged(object sender,
            Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            //eventually set the SortString here
            //if e.Cancel is set to true one have to update the datasource here
            //bindingSource_main.Sort = advancedDataGridView_main.SortString;
            //otherwise it will be updated by the component

            // textBox_sort.Text = e.SortString;
        }

        private void textBox_strfilter_TextChanged(object sender, EventArgs e)
        {
            //trigger the filter string changed function when text is changed
            advancedDataGridView_main.TriggerFilterStringChanged();
        }

        private void bindingSource_main_ListChanged(object sender, ListChangedEventArgs e)
        {
            textBox_total.Text = bindingSource_main.List.Count.ToString();
        }

        private void button_savefilters_Click(object sender, EventArgs e)
        {
        }

        private void button_setsavedfilter_Click(object sender, EventArgs e)
        {
            /*if (comboBox_filtersaved.SelectedIndex != -1 && comboBox_sortsaved.SelectedIndex != -1)
                advancedDataGridView_main.LoadFilterAndSort(comboBox_filtersaved.SelectedValue.ToString(),
                    comboBox_sortsaved.SelectedValue.ToString());*/
        }

        private void button_unloadfilters_Click(object sender, EventArgs e)
        {
            advancedDataGridView_main.CleanFilterAndSort();
            /*comboBox_filtersaved.SelectedIndex = -1;
            comboBox_sortsaved.SelectedIndex = -1;*/
        }

        private void advancedDataGridViewSearchToolBar_main_Search(object sender,
            Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = advancedDataGridView_main.CurrentCell.ColumnIndex + 1 >=
                              advancedDataGridView_main.ColumnCount;
                bool endrow = advancedDataGridView_main.CurrentCell.RowIndex + 1 >= advancedDataGridView_main.RowCount;

                if (endcol && endrow)
                {
                    startColumn = advancedDataGridView_main.CurrentCell.ColumnIndex;
                    startRow = advancedDataGridView_main.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : advancedDataGridView_main.CurrentCell.ColumnIndex + 1;
                    startRow = advancedDataGridView_main.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }

            DataGridViewCell c = advancedDataGridView_main.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = advancedDataGridView_main.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                advancedDataGridView_main.CurrentCell = c;
        }


        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            if (categoryForm.ShowDialog() == DialogResult.OK)
            {
                getPeople();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonForm personForm = new PersonForm();
            if (personForm.ShowDialog() == DialogResult.OK)
            {
                getPeople();
            }
        }

        private void advancedDataGridView_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(advancedDataGridView_main.Rows[e.RowIndex].Cells[0].Value);
            switch (e.ColumnIndex)
            {
                case 17:
                    Process.Start("explorer.exe", $"{Application.StartupPath}\\PersonData\\{id}");
                    break;
                case 18:
                    PersonForm personForm = new PersonForm(id);
                    if(personForm.ShowDialog() == DialogResult.OK)
                    {
                        getPeople();
                    }
                    break;
                case 19:
                    var confirmResult = MessageBox.Show("برای حذف مطمئنید؟",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            deletePerson(id);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    break;
            }
        }
        private void deletePerson(int id)
        {
            try
            {
                using (DbConnection connection = new SQLiteConnection(@"data source=.\db\PeopleInfoDb\PeopleInfoDb.sqlite; Foreign Key Constraints=On;"))
                {
                    // This is important! Else the in memory database will not work.
                    connection.Open();

                    using (var _context = new PeopleInfoDbContext(connection, true))
                    {
                        Person person = _context.People.Find(id);
                        if (person == null)
                            throw new Exception("PersonId is not valid");

                        _context.People.Remove(person);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}