using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace SD_Converter
{
    public partial class LoadFilesForm : Form
    {
        private LoadFilesController controller;

        public LoadFilesForm()
        {
            InitializeComponent();
            Text = Application.ProductVersion;
            controller = new LoadFilesController();
        }


        private void loadButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //var text = controller.GetTableText(numbersTextBox.Text);
                //exportTextBox.Text = text;

                //if (exportTextBox.Text.Length > 0)
                //    {Clipboard.SetText(exportTextBox.Text);

                //MessageBox.Show("Таблицу можно вставить в Excel", "Данные скопированы",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Information);
                //}


                var table = controller.GetTable(numbersTextBox.Text);
                if (table != null)
                {
                    var path = string.Format("{0}\\{1}.csv",
                        Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                        DateTime.Now.ToString("HH-mm-ss dd-MM"));


                    var csvText = table.ToCsv();
                    exportTextBox.Text = csvText;

                    File.WriteAllText(path, csvText);

                    System.Diagnostics.Process.Start(path);

                    exportTextBox.Text = "Готово";
                    exportTextBox.ForeColor = System.Drawing.Color.Green;
                }

            }

            catch (Exception ex)
            {
                exportTextBox.Text = ex.Message;
                exportTextBox.ForeColor = System.Drawing.Color.DarkRed;
            }


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
