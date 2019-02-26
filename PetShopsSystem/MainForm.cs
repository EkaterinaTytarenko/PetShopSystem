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
    public partial class PetShopsForm : Form
    {
        public PetShopsForm()
        {
            InitializeComponent();
            shopTableAdapter.Fill(animalsDataSet.Shop);
            animalTableAdapter.Fill(animalsDataSet.Animal);
            speciesTableAdapter.Fill(animalsDataSet.Species);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "animalsDataSet.Colors". При необходимости она может быть перемещена или удалена.
            this.colorsTableAdapter.Fill(this.animalsDataSet.Colors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "animalsDataSet.Cage". При необходимости она может быть перемещена или удалена.
            this.cageTableAdapter.Fill(this.animalsDataSet.Cage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "animalsDataSet.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.animalsDataSet.Animal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "animalsDataSet.Species". При необходимости она может быть перемещена или удалена.
            this.speciesTableAdapter.Fill(this.animalsDataSet.Species);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "animalsDataSet.Shop". При необходимости она может быть перемещена или удалена.
            this.shopTableAdapter.Fill(this.animalsDataSet.Shop);

        }

        private void shopsSaveButton_Click(object sender, EventArgs e)
        {
            shopTableAdapter.Update(animalsDataSet.Shop);
        }

        private void shopsDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int shoip_Id = (int)shopsDataGridView.CurrentRow.Cells["shopIdDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> shopsNum = queriesTableAdapter1.SQLCountShopsInAnimals(shoip_Id);
                if (shopsNum == 0)
                {
                    shopBindingSource.RemoveCurrent();
                    queriesTableAdapter1.SQLDeleteCagesWithShops(shoip_Id);
                }
                else
                    MessageBox.Show("Неможливо видалити магазин, у якому є тварини");
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення");
            }
        }

        private void speciesSaveButton_Click(object sender, EventArgs e)
        {
            speciesTableAdapter.Update(animalsDataSet.Species);
        }

        private void speciesDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int species_Id = (int)speciesDataGridView.CurrentRow.Cells["speciesIdDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> speciesNum = queriesTableAdapter1.SQLCountSpeciesInAnimals(species_Id);
                if (speciesNum == 0)
                {
                    speciesBindingSource.RemoveCurrent();
                    queriesTableAdapter1.SQLDeleteSpeciesFoodWithSpecies(species_Id);
                }
                else
                    MessageBox.Show("Неможливо видалити цей вид, бо його представники є у магазинах");
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення");
            }

        }

        private void animalsSaveButton_Click(object sender, EventArgs e)
        {
            animalTableAdapter.Update(animalsDataSet.Animal);
        }

        private void animalsDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                animalBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення");
            }
        }

        private void cellsInfoButton_Click(object sender, EventArgs e)
        {
            CagesForm cagesForm = new CagesForm((int)shopsDataGridView.CurrentRow.Cells["shopIdDataGridViewTextBoxColumn"].Value);
            cagesForm.ShowDialog(this);
            cagesForm.Dispose();
        }

        private void showFoodButton_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm((int)speciesDataGridView.CurrentRow.Cells["speciesIdDataGridViewTextBoxColumn"].Value);
            foodForm.ShowDialog(this);
            foodForm.Dispose();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog(this);
            searchForm.Dispose();

        }



        private void animalsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (animalsDataGridView.CurrentCell.ColumnIndex == 5)
                {
                    int shop_id;
                    try
                    {
                        shop_id = (int)animalsDataGridView.CurrentRow.Cells["animalShopIdDataGridViewTextBoxColumn"].Value;

                    }
                    catch (Exception)
                    {
                        animalsDataGridView.CurrentRow.Cells["animalCageIdDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                        return;

                    }
                    if (queriesTableAdapter1.SQLCountCagesInShop(shop_id) == 0)
                    {
                        MessageBox.Show("Неможливо обрати цей магазин,тому що у ньому немає жодної клітки для тварин");
                        animalsDataGridView.CurrentRow.Cells["animalCageIdDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                        animalsDataGridView.CurrentRow.Cells["animalShopIdDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                        animalsDataGridView.CurrentRow.Cells["AnimalsShopColumn"].Value = System.DBNull.Value;
                        return;

                    }
                    ChooseCagesForm chooseCagesForm = new ChooseCagesForm(shop_id, animalsDataGridView);
                    chooseCagesForm.ShowDialog(this);
                    chooseCagesForm.Dispose();

                }
                if (animalsDataGridView.CurrentCell.ColumnIndex == 12)
                {
                    int price;
                    try
                    {
                        price = (int)animalsDataGridView.CurrentRow.Cells["animalPriceDataGridViewTextBoxColumn"].Value;

                    }
                    catch (Exception)
                    {
                        animalsDataGridView.CurrentRow.Cells["animalPriceDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                        return;

                    }
                    if (price < 0)
                    {
                        MessageBox.Show("Помилкові дані.Ціна не може бути від'ємною");
                        animalsDataGridView.CurrentRow.Cells["animalPriceDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                    }


                }
            }
            catch (Exception)
            {

            }

        }

        private void animalsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено некоректні дані");

        }

        private void PetShopsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
    "Ви дійсно хочете вийти з програми?",
    "Завершення програми",
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

        private void speciesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (speciesDataGridView.CurrentCell.ColumnIndex == 2)
            {
                int lifeTime;
                try
                {
                    lifeTime = (int)speciesDataGridView.CurrentRow.Cells["speciesLifetimeDataGridViewTextBoxColumn"].Value;

                }
                catch (Exception)
                {
                    speciesDataGridView.CurrentRow.Cells["speciesLifetimeDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                    return;

                }
                if (lifeTime <= 0)
                {
                    MessageBox.Show("Помилкові дані. Тривалість життя не може бути недодатньою");
                    speciesDataGridView.CurrentRow.Cells["speciesLifetimeDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                }


            }

        }

        private void shopsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено некоректні дані");

        }

        private void speciesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено некоректні дані");
        }
    }
}
