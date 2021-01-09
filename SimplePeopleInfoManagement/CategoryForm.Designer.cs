using System.ComponentModel;

namespace SimplePeopleInfoManagement
{
    partial class CategoryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveAndNew_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveAndNew_btn);
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.Controls.Add(this.save_btn);
            this.groupBox1.Controls.Add(this.description_txt);
            this.groupBox1.Controls.Add(this.title_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(531, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات";
            // 
            // saveAndNew_btn
            // 
            this.saveAndNew_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveAndNew_btn.Location = new System.Drawing.Point(353, 220);
            this.saveAndNew_btn.Name = "saveAndNew_btn";
            this.saveAndNew_btn.Size = new System.Drawing.Size(148, 45);
            this.saveAndNew_btn.TabIndex = 7;
            this.saveAndNew_btn.Text = "ذخیره و بعدی";
            this.saveAndNew_btn.UseVisualStyleBackColor = true;
            this.saveAndNew_btn.Click += new System.EventHandler(this.saveAndNew_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(63, 220);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(104, 45);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "انصراف";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_btn.Location = new System.Drawing.Point(218, 220);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(118, 45);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "ذخیره";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // description_txt
            // 
            this.description_txt.Location = new System.Drawing.Point(38, 75);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(374, 118);
            this.description_txt.TabIndex = 4;
            // 
            // title_txt
            // 
            this.title_txt.Location = new System.Drawing.Point(38, 36);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(374, 30);
            this.title_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(388, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "توضیحات:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(388, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "عنوان:";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 293);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Koodak", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.Button saveAndNew_btn;
    }
}