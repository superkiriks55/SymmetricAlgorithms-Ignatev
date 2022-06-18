using SymmetricAlgorithms_Ignatev.TEST;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymmetricAlgorithms_Ignatev
{
    public partial class SymmetricForm : Form
    {
        private SymmetricDataService _dataService;
        public SymmetricForm()
        {
            InitializeComponent();
            _dataService = new SymmetricDataService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileChoiseBtn_Click(object sender, EventArgs e)
        {
            filePathTextBox.Text = openFileDialog.GetFilteredFileName(Filters.ALL, filePathTextBox.Text);
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string path = filePathTextBox.Text;
            string password = passwordTextBox.Text;
            Action<string, bool> setBtnsParams = (string text, bool enabled) =>
            {
                startBtn.Text = text;
                fileChoiseBtn.Enabled = enabled;
                startBtn.Enabled = enabled;
            };


            Action getData = async () =>
            {
                try
                {
                    errorLabel.Text = string.Empty;
                    summaryDataGridView.DataSource = null;

                    if (password == string.Empty || string.IsNullOrWhiteSpace(password))
                        throw new ArgumentException(Exception_USER.PASSWORD_ERROR);

                    var parameters = new FormData (path, password);
                    setBtnsParams.Invoke("Подождите...", false);
                    summaryDataGridView.DataSource = await  _dataService.GetAlgorithmResults(parameters);
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                    summaryDataGridView.DataSource = null;
                }
                finally
                {
                    setBtnsParams.Invoke("Старт", true);
                }
            };

            Task.Run(() => summaryDataGridView.BeginInvoke(getData));
        }
    }
    }

