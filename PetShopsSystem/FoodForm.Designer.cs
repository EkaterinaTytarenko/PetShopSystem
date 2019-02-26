namespace PetShopsSystem
{
    partial class FoodForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.foodDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsDataSet2 = new PetShopsSystem.AnimalsDataSet();
            this.concreteSpeciesFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concreteSpeciesFoodTableAdapter = new PetShopsSystem.AnimalsDataSetTableAdapters.ConcreteSpeciesFoodTableAdapter();
            this.foodTableAdapter = new PetShopsSystem.AnimalsDataSetTableAdapters.FoodTableAdapter();
            this.foodSaveButton = new System.Windows.Forms.Button();
            this.foodDeleteButton = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new PetShopsSystem.AnimalsDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concreteSpeciesFoodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // foodDataGridView
            // 
            this.foodDataGridView.AutoGenerateColumns = false;
            this.foodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.FoodColumn});
            this.foodDataGridView.DataSource = this.concreteSpeciesFoodBindingSource;
            this.foodDataGridView.Location = new System.Drawing.Point(60, 97);
            this.foodDataGridView.Name = "foodDataGridView";
            this.foodDataGridView.Size = new System.Drawing.Size(146, 150);
            this.foodDataGridView.TabIndex = 0;
            this.foodDataGridView.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.foodDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.foodDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SpeciesFood_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "SpeciesFood_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Species_Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Species_Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Food_Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Food_Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // FoodColumn
            // 
            this.FoodColumn.DataPropertyName = "Food_Id";
            this.FoodColumn.DataSource = this.foodBindingSource;
            this.FoodColumn.DisplayMember = "Food_Name";
            this.FoodColumn.HeaderText = "Їжа";
            this.FoodColumn.Name = "FoodColumn";
            this.FoodColumn.ValueMember = "Food_Id";
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "Food";
            this.foodBindingSource.DataSource = this.animalsDataSet2;
            // 
            // animalsDataSet2
            // 
            this.animalsDataSet2.DataSetName = "AnimalsDataSet";
            this.animalsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // concreteSpeciesFoodBindingSource
            // 
            this.concreteSpeciesFoodBindingSource.DataMember = "ConcreteSpeciesFood";
            this.concreteSpeciesFoodBindingSource.DataSource = this.animalsDataSet2;
            // 
            // concreteSpeciesFoodTableAdapter
            // 
            this.concreteSpeciesFoodTableAdapter.ClearBeforeFill = true;
            // 
            // foodTableAdapter
            // 
            this.foodTableAdapter.ClearBeforeFill = true;
            // 
            // foodSaveButton
            // 
            this.foodSaveButton.Location = new System.Drawing.Point(60, 38);
            this.foodSaveButton.Name = "foodSaveButton";
            this.foodSaveButton.Size = new System.Drawing.Size(112, 23);
            this.foodSaveButton.TabIndex = 1;
            this.foodSaveButton.Text = "Зберегти";
            this.foodSaveButton.UseVisualStyleBackColor = true;
            this.foodSaveButton.Click += new System.EventHandler(this.foodSaveButton_Click);
            // 
            // foodDeleteButton
            // 
            this.foodDeleteButton.Location = new System.Drawing.Point(205, 38);
            this.foodDeleteButton.Name = "foodDeleteButton";
            this.foodDeleteButton.Size = new System.Drawing.Size(109, 23);
            this.foodDeleteButton.TabIndex = 2;
            this.foodDeleteButton.Text = "Видалити";
            this.foodDeleteButton.UseVisualStyleBackColor = true;
            this.foodDeleteButton.Click += new System.EventHandler(this.foodDeleteButton_Click);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.foodDeleteButton);
            this.Controls.Add(this.foodSaveButton);
            this.Controls.Add(this.foodDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FoodForm";
            this.Text = "Їжа для конкретного виду";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FoodForm_FormClosing);
            this.Load += new System.EventHandler(this.FoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concreteSpeciesFoodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AnimalsDataSet animalsDataSet;
        private AnimalsDataSet animalsDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesFoodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView foodDataGridView;
        private System.Windows.Forms.BindingSource concreteSpeciesFoodBindingSource;
        private AnimalsDataSet animalsDataSet2;
        private AnimalsDataSetTableAdapters.ConcreteSpeciesFoodTableAdapter concreteSpeciesFoodTableAdapter;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private AnimalsDataSetTableAdapters.FoodTableAdapter foodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn FoodColumn;
        private System.Windows.Forms.Button foodSaveButton;
        private System.Windows.Forms.Button foodDeleteButton;
        private AnimalsDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}