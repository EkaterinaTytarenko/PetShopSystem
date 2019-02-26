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
    public partial class CagesForm : Form
    {
        public CagesForm(int shopId)
        {
            InitializeComponent();
            cage1TableAdapter.Fill(animalsDataSet1.Cage1,shopId);
            shop_Id = shopId;

        }

        private int shop_Id;

        private void cagesSaveButton_Click(object sender, EventArgs e)
        {
            cage1TableAdapter.Update(animalsDataSet1.Cage1);
        }

        private void cagesDeletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                int cage_Id = (int)cagesDataGridView.CurrentRow.Cells["cageIdDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> cagesNum = queriesTableAdapter1.SQLCountAnimalsInCage(cage_Id);
                if (cagesNum == 0)
                {
                    cage1BindingSource.RemoveCurrent();
                   
                }
                else
                    MessageBox.Show("Неможливо видалити цю клітку.У ній живуть тварини");
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення");
            }
        }

        

        private void cagesDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                cagesDataGridView.CurrentRow.Cells["cageShopIdDataGridViewTextBoxColumn"].Value = shop_Id;
            }
            catch(Exception)
            { }
        }

        private void cagesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено некоректні дані");
        }

        private void CagesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
    "Закрити вікно?",
    "Закриття вікна",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning
   );
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void cagesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (cagesDataGridView.CurrentCell.ColumnIndex ==3 )
            {
                int cageSquare;
                try
                {
                    cageSquare = (int)cagesDataGridView.CurrentRow.Cells["cageSquareDataGridViewTextBoxColumn"].Value;

                }
                catch (Exception)
                {
                    cagesDataGridView.CurrentRow.Cells["cageSquareDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                    return;

                }
                if (cageSquare <= 0)
                {
                    MessageBox.Show("Помилкові дані. Площа клітки не може бути недодатньою");
                    cagesDataGridView.CurrentRow.Cells["cageSquareDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                }


            }
        }
    }
}
