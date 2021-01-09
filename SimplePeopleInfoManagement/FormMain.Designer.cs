using System.ComponentModel;

namespace SimplePeopleInfoManagement
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_search = new System.Windows.Forms.Panel();
            this.advancedDataGridViewSearchToolBar_main = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_total = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.panel_grid = new System.Windows.Forms.Panel();
            this.advancedDataGridView_main = new Zuby.ADGV.AdvancedDataGridView();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.bindingSource_main = new System.Windows.Forms.BindingSource(this.components);
            this.panel_top.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.advancedDataGridView_main)).BeginInit();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.bindingSource_main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.panel_search);
            this.panel_top.Controls.Add(this.menuStrip1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1045, 116);
            this.panel_top.TabIndex = 0;
            // 
            // panel_search
            // 
            this.panel_search.Controls.Add(this.advancedDataGridViewSearchToolBar_main);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_search.Location = new System.Drawing.Point(0, 74);
            this.panel_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(1045, 42);
            this.panel_search.TabIndex = 10;
            // 
            // advancedDataGridViewSearchToolBar_main
            // 
            this.advancedDataGridViewSearchToolBar_main.AllowMerge = false;
            this.advancedDataGridViewSearchToolBar_main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.advancedDataGridViewSearchToolBar_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.advancedDataGridViewSearchToolBar_main.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridViewSearchToolBar_main.MaximumSize = new System.Drawing.Size(0, 41);
            this.advancedDataGridViewSearchToolBar_main.MinimumSize = new System.Drawing.Size(0, 41);
            this.advancedDataGridViewSearchToolBar_main.Name = "advancedDataGridViewSearchToolBar_main";
            this.advancedDataGridViewSearchToolBar_main.RenderMode =
                System.Windows.Forms.ToolStripRenderMode.Professional;
            this.advancedDataGridViewSearchToolBar_main.Size = new System.Drawing.Size(1045, 41);
            this.advancedDataGridViewSearchToolBar_main.TabIndex = 0;
            this.advancedDataGridViewSearchToolBar_main.Text = "advancedDataGridViewSearchToolBar_main";
            this.advancedDataGridViewSearchToolBar_main.Search +=
                new Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventHandler(this
                    .advancedDataGridViewSearchToolBar_main_Search);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.newToolStripMenuItem, this.toolStripSeparator1, this.newCategoryToolStripMenuItem,
                this.exitToolStripMenuItem
            });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys =
                ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // newCategoryToolStripMenuItem
            // 
            this.newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            this.newCategoryToolStripMenuItem.ShortcutKeys =
                ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.newCategoryToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.newCategoryToolStripMenuItem.Text = "New Category";
            this.newCategoryToolStripMenuItem.Click += new System.EventHandler(this.newCategoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(16, 19);
            this.label_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(80, 20);
            this.label_total.TabIndex = 16;
            this.label_total.Text = "Total rows:";
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(103, 14);
            this.textBox_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.Size = new System.Drawing.Size(92, 27);
            this.textBox_total.TabIndex = 15;
            // 
            // panel_grid
            // 
            this.panel_grid.Controls.Add(this.advancedDataGridView_main);
            this.panel_grid.Controls.Add(this.panel_bottom);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid.Location = new System.Drawing.Point(0, 116);
            this.panel_grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(1045, 593);
            this.panel_grid.TabIndex = 1;
            // 
            // advancedDataGridView_main
            // 
            this.advancedDataGridView_main.AllowUserToAddRows = false;
            this.advancedDataGridView_main.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))),
                ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.advancedDataGridView_main.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView_main.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView_main.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView_main.FilterAndSortEnabled = true;
            this.advancedDataGridView_main.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView_main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.advancedDataGridView_main.Name = "advancedDataGridView_main";
            this.advancedDataGridView_main.ReadOnly = true;
            this.advancedDataGridView_main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView_main.RowHeadersVisible = false;
            this.advancedDataGridView_main.Size = new System.Drawing.Size(1045, 541);
            this.advancedDataGridView_main.TabIndex = 0;
            this.advancedDataGridView_main.SortStringChanged +=
                new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(
                    this.advancedDataGridView_main_SortStringChanged);
            this.advancedDataGridView_main.FilterStringChanged +=
                new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(
                    this.advancedDataGridView_main_FilterStringChanged);
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.textBox_total);
            this.panel_bottom.Controls.Add(this.label_total);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 541);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1045, 52);
            this.panel_bottom.TabIndex = 2;
            // 
            // bindingSource_main
            // 
            this.bindingSource_main.ListChanged +=
                new System.ComponentModel.ListChangedEventHandler(this.bindingSource_main_ListChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 709);
            this.Controls.Add(this.panel_grid);
            this.Controls.Add(this.panel_top);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1061, 745);
            this.Name = "FormMain";
            this.Text = "AdvancedDataGridView Sample";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.advancedDataGridView_main)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.bindingSource_main)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.BindingSource bindingSource_main;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView_main;
        private System.Windows.Forms.Panel panel_search;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar advancedDataGridViewSearchToolBar_main;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

