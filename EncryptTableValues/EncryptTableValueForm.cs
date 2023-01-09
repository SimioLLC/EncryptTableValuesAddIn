using SimioAPI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptTableValuesAddIn
{
    public partial class EncryptTableValueForm : Form
    {
        public IDesignContext _context;
        public EncryptTableValueForm(IDesignContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColumnComboBox.Items.Clear();
            ColumnComboBox.Text= string.Empty;
            foreach (var table in _context.ActiveModel.Tables)
            {
                if (table.Name == TableComboBox.Text)
                {
                    foreach(var column in table.Columns)
                    {
                        ColumnComboBox.Items.Add(column.Name);
                        if (ColumnComboBox.Text.Length == 0) ColumnComboBox.Text = column.Name;
                    }
                    break;
                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
