using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymmetricAlgorithms_Ignatev.TEST
{
    public static class Extensions
    {
        public static string GetFilteredFileName(this OpenFileDialog fileDialog, string filter, string defaultName = "")
        {
            fileDialog.Filter = filter;
            fileDialog.FileName = string.Empty;
            if (fileDialog.ShowDialog() == DialogResult.OK)
                return fileDialog.FileName;
            return defaultName;
        }

        /// <summary>
        /// Отображает стандартный результат удачной операции
        /// </summary>
        public static void GetOkMessage()
        {
            MessageBox.Show("Готово!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
