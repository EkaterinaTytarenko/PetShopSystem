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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "animalsDataSet1.Colors". При необходимости она может быть перемещена или удалена.
            this.colorsTableAdapter.Fill(this.animalsDataSet1.Colors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "animalsDataSet1.Cage". При необходимости она может быть перемещена или удалена.
            this.cageTableAdapter.Fill(this.animalsDataSet1.Cage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "animalsDataSet.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.animalsDataSet1.Animal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "animalsDataSet.Species". При необходимости она может быть перемещена или удалена.
            this.speciesTableAdapter.Fill(this.animalsDataSet1.Species);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "animalsDataSet.Shop". При необходимости она может быть перемещена или удалена.
            this.shopTableAdapter.Fill(this.animalsDataSet1.Shop);

        }

        private void shopSearchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (shopSearchRadioButton.Checked)
            {
                shopsComboBox.Visible = true;
                animalsShopsDataGridView.Visible = true;

            }
            else
            {
                shopsComboBox.Visible = false;
                animalsShopsDataGridView.Visible = false;

            }
        }

        private void speciesSearchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (speciesSearchRadioButton.Checked)
            {
                speciesComboBox.Visible = true;
                animalSpeciesDataGridView.Visible = true;
            }
            else
            {
                speciesComboBox.Visible = false;
                animalSpeciesDataGridView.Visible = false;
            }

        }

        private void priceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(priceCheckBox.Checked)
            {
                minPriceLabel.Visible = true;
                minPriceTextBox.Visible = true;
                maxPriceLabel.Visible = true;
                maxPriceTextBox.Visible = true;
            }
            else
            {
                minPriceLabel.Visible = false;
                minPriceTextBox.Visible = false;
                maxPriceLabel.Visible = false;
                maxPriceTextBox.Visible = false;
            }


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int minPrice = 0 ;
            int maxPrice=int.MaxValue;
            int minYear=0;
            int maxYear = int.MaxValue;
            if (priceCheckBox.Checked)
            {
                try
                {
                    minPrice = int.Parse(minPriceTextBox.Text);
                    maxPrice = int.Parse(maxPriceTextBox.Text);
                    if (minPrice < 0)
                        throw new Exception();
                }
                catch(Exception)
                {
                    MessageBox.Show("Некоректно введена ціна. Пошук неможливий.");
                    return;

                }

            }
            if (yearCheckBox.Checked)
            {
                try
                {
                    minYear = int.Parse(minYearTextBox.Text);
                    maxYear = int.Parse(maxYearTextBox.Text);
                    if (minYear < 0||minYear>maxYear)
                        throw new Exception();
                }
                catch (Exception)
                {
                    MessageBox.Show("Некоректно введені роки. Пошук неможливий.");
                    return;

                }

            }
            string searchParament;
            if (speciesSearchRadioButton.Checked)
            {
                searchParament = speciesComboBox.Text;
                animalsSpeciesTableAdapter1.Fill(animalsDataSet1.AnimalsSpecies,searchParament,minPrice,maxPrice,minYear,maxYear);
                
            }
            else
            {
                searchParament = shopsComboBox.Text;
                animalsShopsTableAdapter.Fill(animalsDataSet2.AnimalsShops, searchParament, minPrice, maxPrice, minYear, maxYear);
            }



        }

        private void animalsShopsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void yearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (yearCheckBox.Checked)
            {
                minYearLabel.Visible = true;
                minYearTextBox.Visible = true;
                maxYearLabel.Visible = true;
                maxYearTextBox.Visible = true;
            }
            else
            {
                minYearLabel.Visible = false;
                minYearTextBox.Visible = false;
                maxYearLabel.Visible = false;
                maxYearTextBox.Visible = false;
            }

        }
    }
}
