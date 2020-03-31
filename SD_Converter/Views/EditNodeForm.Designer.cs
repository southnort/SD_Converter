namespace SD_Converter
{
    partial class EditNodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.FormNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.upPanel = new System.Windows.Forms.Panel();
            this.openInBrowserButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BFTFIO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ClientFIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CompleteDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CreationDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SDNumber = new System.Windows.Forms.TextBox();
            this.downPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.Parent = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Organisation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailTextTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailThemeTextBox = new System.Windows.Forms.TextBox();
            this.upPanel.SuspendLayout();
            this.downPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormNumber
            // 
            this.FormNumber.Location = new System.Drawing.Point(112, 22);
            this.FormNumber.Name = "FormNumber";
            this.FormNumber.Size = new System.Drawing.Size(100, 20);
            this.FormNumber.TabIndex = 0;
            this.FormNumber.TextChanged += new System.EventHandler(this.textBoxTextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер формы";
            // 
            // upPanel
            // 
            this.upPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upPanel.Controls.Add(this.openInBrowserButton);
            this.upPanel.Controls.Add(this.label8);
            this.upPanel.Controls.Add(this.BFTFIO);
            this.upPanel.Controls.Add(this.label7);
            this.upPanel.Controls.Add(this.Email);
            this.upPanel.Controls.Add(this.label6);
            this.upPanel.Controls.Add(this.ClientFIO);
            this.upPanel.Controls.Add(this.label5);
            this.upPanel.Controls.Add(this.CompleteDate);
            this.upPanel.Controls.Add(this.label4);
            this.upPanel.Controls.Add(this.CreationDate);
            this.upPanel.Controls.Add(this.label3);
            this.upPanel.Controls.Add(this.Status);
            this.upPanel.Controls.Add(this.label2);
            this.upPanel.Controls.Add(this.SDNumber);
            this.upPanel.Controls.Add(this.label1);
            this.upPanel.Controls.Add(this.FormNumber);
            this.upPanel.Location = new System.Drawing.Point(12, 12);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(610, 127);
            this.upPanel.TabIndex = 2;
            // 
            // openInBrowserButton
            // 
            this.openInBrowserButton.Location = new System.Drawing.Point(453, 7);
            this.openInBrowserButton.Name = "openInBrowserButton";
            this.openInBrowserButton.Size = new System.Drawing.Size(152, 35);
            this.openInBrowserButton.TabIndex = 16;
            this.openInBrowserButton.Text = "Открыть в браузере";
            this.openInBrowserButton.UseVisualStyleBackColor = true;
            this.openInBrowserButton.Click += new System.EventHandler(this.openInBrowserButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ответственный БФТ";
            // 
            // BFTFIO
            // 
            this.BFTFIO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BFTFIO.Location = new System.Drawing.Point(234, 62);
            this.BFTFIO.Name = "BFTFIO";
            this.BFTFIO.Size = new System.Drawing.Size(371, 20);
            this.BFTFIO.TabIndex = 14;
            this.BFTFIO.TextChanged += new System.EventHandler(this.textBoxTextChange);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "e-mail";
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.Location = new System.Drawing.Point(412, 101);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(193, 20);
            this.Email.TabIndex = 12;
            this.Email.TextChanged += new System.EventHandler(this.textBoxTextChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Инициатор обращения";
            // 
            // ClientFIO
            // 
            this.ClientFIO.Location = new System.Drawing.Point(3, 101);
            this.ClientFIO.Name = "ClientFIO";
            this.ClientFIO.Size = new System.Drawing.Size(381, 20);
            this.ClientFIO.TabIndex = 10;
            this.ClientFIO.TextChanged += new System.EventHandler(this.textBoxTextChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата выполнения";
            // 
            // CompleteDate
            // 
            this.CompleteDate.Location = new System.Drawing.Point(112, 62);
            this.CompleteDate.Name = "CompleteDate";
            this.CompleteDate.Size = new System.Drawing.Size(100, 20);
            this.CompleteDate.TabIndex = 8;
            this.CompleteDate.TextChanged += new System.EventHandler(this.textBoxTextChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата регистрации";
            // 
            // CreationDate
            // 
            this.CreationDate.Location = new System.Drawing.Point(3, 62);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(100, 20);
            this.CreationDate.TabIndex = 6;
            this.CreationDate.TextChanged += new System.EventHandler(this.textBoxTextChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статус";
            // 
            // Status
            // 
            this.Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Выполнена",
            "Зарегистрирована"});
            this.Status.Location = new System.Drawing.Point(234, 21);
            this.Status.Name = "Status";
            this.Status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Status.Size = new System.Drawing.Size(144, 21);
            this.Status.TabIndex = 4;
            this.Status.SelectedValueChanged += new System.EventHandler(this.comboboxChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер заявки";
            // 
            // SDNumber
            // 
            this.SDNumber.Location = new System.Drawing.Point(3, 23);
            this.SDNumber.Name = "SDNumber";
            this.SDNumber.Size = new System.Drawing.Size(100, 20);
            this.SDNumber.TabIndex = 2;
            this.SDNumber.TextChanged += new System.EventHandler(this.textBoxTextChange);
            // 
            // downPanel
            // 
            this.downPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.downPanel.Controls.Add(this.saveButton);
            this.downPanel.Controls.Add(this.Parent);
            this.downPanel.Controls.Add(this.label11);
            this.downPanel.Controls.Add(this.Organisation);
            this.downPanel.Controls.Add(this.label10);
            this.downPanel.Controls.Add(this.Description);
            this.downPanel.Location = new System.Drawing.Point(12, 374);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(610, 120);
            this.downPanel.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveButton.Location = new System.Drawing.Point(434, 73);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(165, 38);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить и закрыть";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Parent
            // 
            this.Parent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Parent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Parent.FormattingEnabled = true;
            this.Parent.Items.AddRange(new object[] {
            "ДФ",
            "ГРБС (Департамент, Комитет, Префектура)",
            "ГАУ, ГБУ, ГКУ"});
            this.Parent.Location = new System.Drawing.Point(315, 47);
            this.Parent.Name = "Parent";
            this.Parent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Parent.Size = new System.Drawing.Size(284, 21);
            this.Parent.TabIndex = 19;
            this.Parent.SelectedIndexChanged += new System.EventHandler(this.Parent_SelectedIndexChanged);
            this.Parent.SelectedValueChanged += new System.EventHandler(this.comboboxChange);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Организация";
            // 
            // Organisation
            // 
            this.Organisation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Organisation.Location = new System.Drawing.Point(315, 21);
            this.Organisation.Name = "Organisation";
            this.Organisation.Size = new System.Drawing.Size(284, 20);
            this.Organisation.TabIndex = 17;
            this.Organisation.TextChanged += new System.EventHandler(this.textBoxTextChange);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Суть проблемы";
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.Location = new System.Drawing.Point(3, 21);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(306, 90);
            this.Description.TabIndex = 0;
            this.Description.Text = "";
            this.Description.TextChanged += new System.EventHandler(this.textBoxTextChange);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.emailTextTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.emailThemeTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 223);
            this.panel1.TabIndex = 4;
            // 
            // emailTextTextBox
            // 
            this.emailTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextTextBox.Location = new System.Drawing.Point(8, 51);
            this.emailTextTextBox.Name = "emailTextTextBox";
            this.emailTextTextBox.ReadOnly = true;
            this.emailTextTextBox.Size = new System.Drawing.Size(591, 160);
            this.emailTextTextBox.TabIndex = 2;
            this.emailTextTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Письмо:";
            // 
            // emailThemeTextBox
            // 
            this.emailThemeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailThemeTextBox.Location = new System.Drawing.Point(8, 22);
            this.emailThemeTextBox.Name = "emailThemeTextBox";
            this.emailThemeTextBox.ReadOnly = true;
            this.emailThemeTextBox.Size = new System.Drawing.Size(591, 20);
            this.emailThemeTextBox.TabIndex = 0;
            // 
            // EditNodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.upPanel);
            this.Name = "EditNodeForm";
            this.Text = "EditNodeForm";
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            this.downPanel.ResumeLayout(false);
            this.downPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FormNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ClientFIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CompleteDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CreationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SDNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BFTFIO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailThemeTextBox;
        private System.Windows.Forms.RichTextBox emailTextTextBox;
        private System.Windows.Forms.TextBox Organisation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Parent;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openInBrowserButton;
    }
}