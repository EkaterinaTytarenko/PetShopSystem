using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopsSystem
{
    public partial class ChooseCagesForm : Form
    {
        public ChooseCagesForm(int shop_id, DataGridView table)
        {
            InitializeComponent();
            cage1TableAdapter.Fill(animalsDataSet.Cage1, shop_id);
            shop_Id = shop_id;
            myTable = table;
        }
        private int shop_Id;
        private DataGridView myTable;
        private void chooseCagesButton_Click(object sender, EventArgs e)
        {
           cage1TableAdapter.Update(animalsDataSet.Cage1);
            int num = int.Parse(cageNumsComboBox.Text);
            myTable.CurrentRow.Cells["animalCageIdDataGridViewTextBoxColumn"].Value=(int)queriesTableAdapter1.SQLGetCageIdByNumAndShop(shop_Id, num);
            this.Close();
           

        }

        

        
    }
}
