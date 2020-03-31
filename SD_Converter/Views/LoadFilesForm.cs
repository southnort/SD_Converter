using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SD_Converter
{
    public partial class LoadFilesForm : Form
    {
        private readonly string login = "specialist3";
        private readonly string password = "vgYD4yEg";
        private LoadFilesController controller;

        public LoadFilesForm()
        {
            InitializeComponent();
            Text = Application.ProductVersion;
            controller = new LoadFilesController();

            exportTextBox.Text =
      controller.SetAuthorization(login, password);

        }


        private void loadButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Hide();
            try
            {
                var table = controller.GetTable(numbersTextBox.Text);
                if (table != null)
                {
                    var path = string.Format("{0}\\{1}.xlsx",
                        Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                        DateTime.Now.ToString("HH-mm-ss dd-MM"));


                    var writer = new ExcelWriter();
                    writer.SaveTableToExcel(table, path);



                    System.Diagnostics.Process.Start(path);

                    exportTextBox.Text = "Готово";
                    exportTextBox.ForeColor = System.Drawing.Color.Green;
                }

            }

            catch (Exception ex)
            {
                exportTextBox.Text = ex.ToString();
                exportTextBox.ForeColor = System.Drawing.Color.DarkRed;
            }

            Show();
            Cursor.Current = Cursors.Default;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            numbersTextBox.Clear();
        }

        private void numbersTextBox_TextChanged(object sender, EventArgs e)
        {
            loadButton.Enabled = numbersTextBox.Text.Length > 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            exportTextBox.Clear();
            exportTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (exportTextBox.Text.Length > 0)
                Clipboard.SetText(exportTextBox.Text);
        }
    }
}
