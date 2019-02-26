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
    public partial class FoodForm : Form
    {
        public FoodForm(int speciesId)
        {
            InitializeComponent();
            concreteSpeciesFoodTableAdapter.Fill(animalsDataSet2.ConcreteSpeciesFood, speciesId);
            foodTableAdapter.Fill(animalsDataSet2.Food);
            species_Id = speciesId;
        }

        private int species_Id;

        private void FoodForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "animalsDataSet2.Food". При необходимости она может быть перемещена или удалена.
            this.foodTableAdapter.Fill(this.animalsDataSet2.Food);
            

        }

        private void foodSaveButton_Click(object sender, EventArgs e)
        {
            
            concreteSpeciesFoodTableAdapter.Update(animalsDataSet2.ConcreteSpeciesFood);
            

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                foodDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value = species_Id;
                foodDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn3"].Value = queriesTableAdapter1.SQLFindFoodIdByName((string)foodDataGridView.CurrentRow.Cells["FoodColumn"].Value);
            }
            catch (Exception)
            {
            }
        }

        private void foodDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                concreteSpeciesFoodBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення");
            }
        }

        private void foodDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено некоректні дані");
        }

        private void FoodForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
    }

