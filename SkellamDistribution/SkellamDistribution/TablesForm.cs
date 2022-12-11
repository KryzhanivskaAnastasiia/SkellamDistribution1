using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkellamDistribution
{
    public partial class TablesForm : Form
    {
        public TablesForm(ProcessData process)
        { 
            InitializeComponent();
            createTable(dataGridViewReverse, process.reverseDictionary);
            createTable(dataGridViewNeumann, process.neumannDictionary);
            createTable(dataGridViewMetropolis, process.metropolisDictionary);
        }

        private void createTable(DataGridView dataGrid, Dictionary<int, long> array)
        {
            DataGridViewColumn column1 = new DataGridViewColumn();
            column1.HeaderText = "X";
            column1.ReadOnly = true;
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();
            DataGridViewColumn column2 = new DataGridViewColumn();
            column2.HeaderText = "N";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);

            int tmp;
            foreach (KeyValuePair<int, long> pair in array)
            {
                tmp = pair.Key;
                dataGrid.Rows.Add(tmp, pair.Value);
            }
        }


        private void TablesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
