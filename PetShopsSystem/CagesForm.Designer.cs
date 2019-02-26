namespace PetShopsSystem
{
    partial class CagesForm
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
            this.cagesDataGridView = new System.Windows.Forms.DataGridView();
            this.cageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageShopIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageSquareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cage1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsDataSet1 = new PetShopsSystem.AnimalsDataSet();
            this.cagesSaveButton = new System.Windows.Forms.Button();
            this.cagesDeletebutton = new System.Windows.Forms.Button();
            this.animalsDataSet = new PetShopsSystem.AnimalsDataSet();
            this.cage1TableAdapter = new PetShopsSystem.AnimalsDataSetTableAdapters.Cage1TableAdapter();
            this.queriesTableAdapter1 = new PetShopsSystem.AnimalsDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cagesDataGridView
            // 
            this.cagesDataGridView.AutoGenerateColumns = false;
            this.cagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cageIdDataGridViewTextBoxColumn,
            this.cageShopIdDataGridViewTextBoxColumn,
            this.cageNumberDataGridViewTextBoxColumn,
            this.cageSquareDataGridViewTextBoxColumn});
            this.cagesDataGridView.DataSource = this.cage1BindingSource;
            this.cagesDataGridView.Location = new System.Drawing.Point(30, 94);
            this.cagesDataGridView.Name = "cagesDataGridView";
            this.cagesDataGridView.Size = new System.Drawing.Size(246, 191);
            this.cagesDataGridView.TabIndex = 0;
            this.cagesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.cagesDataGridView_CellEndEdit);
            this.cagesDataGridView.CurrentCellChanged += new System.EventHandler(this.cagesDataGridView_CurrentCellChanged);
            this.cagesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.cagesDataGridView_DataError);
            // 
            // cageIdDataGridViewTextBoxColumn
            // 
            this.cageIdDataGridViewTextBoxColumn.DataPropertyName = "Cage_Id";
            this.cageIdDataGridViewTextBoxColumn.HeaderText = "Cage_Id";
            this.cageIdDataGridViewTextBoxColumn.Name = "cageIdDataGridViewTextBoxColumn";
            this.cageIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cageIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cageShopIdDataGridViewTextBoxColumn
            // 
            this.cageShopIdDataGridViewTextBoxColumn.DataPropertyName = "Cage_ShopId";
            this.cageShopIdDataGridViewTextBoxColumn.HeaderText = "Cage_ShopId";
            this.cageShopIdDataGridViewTextBoxColumn.Name = "cageShopIdDataGridViewTextBoxColumn";
            this.cageShopIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cageShopIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cageNumberDataGridViewTextBoxColumn
            // 
            this.cageNumberDataGridViewTextBoxColumn.DataPropertyName = "Cage_Number";
            this.cageNumberDataGridViewTextBoxColumn.HeaderText = "Номер клітки";
            this.cageNumberDataGridViewTextBoxColumn.Name = "cageNumberDataGridViewTextBoxColumn";
            // 
            // cageSquareDataGridViewTextBoxColumn
            // 
            this.cageSquareDataGridViewTextBoxColumn.DataPropertyName = "Cage_Square";
            this.cageSquareDataGridViewTextBoxColumn.HeaderText = "Площа клітки";
            this.cageSquareDataGridViewTextBoxColumn.Name = "cageSquareDataGridViewTextBoxColumn";
            // 
            // cage1BindingSource
            // 
            this.cage1BindingSource.DataMember = "Cage1";
            this.cage1BindingSource.DataSource = this.animalsDataSet1;
            // 
            // animalsDataSet1
            // 
            this.animalsDataSet1.DataSetName = "AnimalsDataSet";
            this.animalsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cagesSaveButton
            // 
            this.cagesSaveButton.Location = new System.Drawing.Point(30, 40);
            this.cagesSaveButton.Name = "cagesSaveButton";
            this.cagesSaveButton.Size = new System.Drawing.Size(109, 23);
            this.cagesSaveButton.TabIndex = 1;
            this.cagesSaveButton.Text = "Зберегти";
            this.cagesSaveButton.UseVisualStyleBackColor = true;
            this.cagesSaveButton.Click += new System.EventHandler(this.cagesSaveButton_Click);
            // 
            // cagesDeletebutton
            // 
            this.cagesDeletebutton.Location = new System.Drawing.Point(169, 40);
            this.cagesDeletebutton.MaximumSize = new System.Drawing.Size(107, 23);
            this.cagesDeletebutton.MinimumSize = new System.Drawing.Size(107, 23);
            this.cagesDeletebutton.Name = "cagesDeletebutton";
            this.cagesDeletebutton.Size = new System.Drawing.Size(107, 23);
            this.cagesDeletebutton.TabIndex = 2;
            this.cagesDeletebutton.Text = "Видалити";
            this.cagesDeletebutton.UseVisualStyleBackColor = true;
            this.cagesDeletebutton.Click += new System.EventHandler(this.cagesDeletebutton_Click);
            // 
            // animalsDataSet
            // 
            this.animalsDataSet.DataSetName = "AnimalsDataSet";
            this.animalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cage1TableAdapter
            // 
            this.cage1TableAdapter.ClearBeforeFill = true;
            // 
            // CagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.cagesDeletebutton);
            this.Controls.Add(this.cagesSaveButton);
            this.Controls.Add(this.cagesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "CagesForm";
            this.Text = "Список кліток у конкретному магазині";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CagesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cage1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AnimalsDataSet animalsDataSet;
        private System.Windows.Forms.DataGridView cagesDataGridView;
        private System.Windows.Forms.BindingSource cage1BindingSource;
        private AnimalsDataSet animalsDataSet1;
        private AnimalsDataSetTableAdapters.Cage1TableAdapter cage1TableAdapter;
        private System.Windows.Forms.Button cagesSaveButton;
        private System.Windows.Forms.Button cagesDeletebutton;
        private AnimalsDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageShopIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageSquareDataGridViewTextBoxColumn;
    }
}