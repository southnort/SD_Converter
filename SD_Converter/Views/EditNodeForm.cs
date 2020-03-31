using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SD_Converter
{
    public partial class EditNodeForm : Form
    {
        private TableConstructor tableConstructor = new TableConstructor();
        public DataRow Row;

        public EditNodeForm(string node, DataTable table)
        {
            InitializeComponent();
            Row = table.NewRow();
            FillPanel(node);
        }

        private void FillPanel(string node)
        {
            TableConstructor tc = new TableConstructor();

            SDNumber.Text = tc.GetSDNumber(node);
            FormNumber.Text = tc.GetFormNumber(node);
            Status.SelectedIndex = tc.GetStatus(node);

            CreationDate.Text = tc.GetCreationDate(node);
            CompleteDate.Text = tc.GetCompleteDate(node);

            BFTFIO.Text = tc.GetBFTFIO(node);
            ClientFIO.Text = tc.GetClientFIO(node);
            Email.Text = tc.GetEmail(node);

            emailThemeTextBox.Text = tc.GetTheme(node);
            emailTextTextBox.Text = tc.GetDescription(node);


        }

        private void openInBrowserButton_Click(object sender, EventArgs e)
        {
            var number = SDNumber.Text;

            if (number.Length > 0)
            {
                string url =
                   $@"http://10.91.114.165:8080/WorkOrder.do?woMode=viewWO&woID={number}&&fromListView=true";
                System.Diagnostics.Process.Start(url);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        private void textBoxTextChange(object sender, EventArgs e)
        {
            var box = (TextBoxBase)sender;
            var text = box.Text;

            Row[box.Name] = text;
        }

        private void comboboxChange(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            var text = box.SelectedItem.ToString();

            Row[box.Name] = text;
        }

        private void Parent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Parent.SelectedIndex == 0)
                Organisation.Text = "ДФ города Москвы";
        }
    }
}
