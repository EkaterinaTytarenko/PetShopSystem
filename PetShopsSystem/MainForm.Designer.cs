namespace PetShopsSystem
{
    partial class PetShopsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.animalsTabPage = new System.Windows.Forms.TabPage();
            this.animalsDeleteButton = new System.Windows.Forms.Button();
            this.animalsSaveButton = new System.Windows.Forms.Button();
            this.animalsDataGridView = new System.Windows.Forms.DataGridView();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsDataSet = new PetShopsSystem.AnimalsDataSet();
            this.speciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopsTabPage = new System.Windows.Forms.TabPage();
            this.cellsInfoButton = new System.Windows.Forms.Button();
            this.shopsDeleteButton = new System.Windows.Forms.Button();
            this.shopsSaveButton = new System.Windows.Forms.Button();
            this.shopsDataGridView = new System.Windows.Forms.DataGridView();
            this.shopIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciestabPage = new System.Windows.Forms.TabPage();
            this.showFoodButton = new System.Windows.Forms.Button();
            this.speciesDeleteButton = new System.Windows.Forms.Button();
            this.speciesSaveButton = new System.Windows.Forms.Button();
            this.speciesDataGridView = new System.Windows.Forms.DataGridView();
            this.speciesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesLifetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesTemperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queriesTableAdapter1 = new PetShopsSystem.AnimalsDataSetTableAdapters.QueriesTableAdapter();
            this.searchButton = new System.Windows.Forms.Button();
            this.cageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopTableAdapter = new PetShopsSystem.AnimalsDataSetTableAdapters.ShopTableAdapter();
            this.speciesTableAdapter = new PetShopsSystem.AnimalsDataSetTableAdapters.SpeciesTableAdapter();
            this.animalTableAdapter = new PetShopsSystem.AnimalsDataSetTableAdapters.AnimalTableAdapter();
            this.cageTableAdapter = new PetShopsSystem.AnimalsDataSetTableAdapters.CageTableAdapter();
            this.colorsTableAdapter = new PetShopsSystem.AnimalsDataSetTableAdapters.ColorsTableAdapter();
            this.animalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalSexColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.animalShopIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalsShopColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.animalCageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalSpeciesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalsSpeciesColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.animalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalColorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalsColorColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.animalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.animalsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.shopsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopsDataGridView)).BeginInit();
            this.speciestabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speciesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.animalsTabPage);
            this.tabControl.Controls.Add(this.shopsTabPage);
            this.tabControl.Controls.Add(this.speciestabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 105);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(788, 333);
            this.tabControl.TabIndex = 0;
            // 
            // animalsTabPage
            // 
            this.animalsTabPage.Controls.Add(this.animalsDeleteButton);
            this.animalsTabPage.Controls.Add(this.animalsSaveButton);
            this.animalsTabPage.Controls.Add(this.animalsDataGridView);
            this.animalsTabPage.Location = new System.Drawing.Point(4, 22);
            this.animalsTabPage.Name = "animalsTabPage";
            this.animalsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.animalsTabPage.Size = new System.Drawing.Size(780, 307);
            this.animalsTabPage.TabIndex = 0;
            this.animalsTabPage.Text = "Тварини";
            this.animalsTabPage.UseVisualStyleBackColor = true;
            // 
            // animalsDeleteButton
            // 
            this.animalsDeleteButton.Location = new System.Drawing.Point(321, 24);
            this.animalsDeleteButton.Name = "animalsDeleteButton";
            this.animalsDeleteButton.Size = new System.Drawing.Size(109, 23);
            this.animalsDeleteButton.TabIndex = 2;
            this.animalsDeleteButton.Text = "Видалити";
            this.animalsDeleteButton.UseVisualStyleBackColor = true;
            this.animalsDeleteButton.Click += new System.EventHandler(this.animalsDeleteButton_Click);
            // 
            // animalsSaveButton
            // 
            this.animalsSaveButton.Location = new System.Drawing.Point(70, 24);
            this.animalsSaveButton.Name = "animalsSaveButton";
            this.animalsSaveButton.Size = new System.Drawing.Size(110, 23);
            this.animalsSaveButton.TabIndex = 1;
            this.animalsSaveButton.Text = "Зберегти";
            this.animalsSaveButton.UseVisualStyleBackColor = true;
            this.animalsSaveButton.Click += new System.EventHandler(this.animalsSaveButton_Click);
            // 
            // animalsDataGridView
            // 
            this.animalsDataGridView.AutoGenerateColumns = false;
            this.animalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalIdDataGridViewTextBoxColumn,
            this.animalNameDataGridViewTextBoxColumn,
            this.animalSexDataGridViewTextBoxColumn,
            this.AnimalSexColumn,
            this.animalShopIdDataGridViewTextBoxColumn,
            this.AnimalsShopColumn,
            this.animalCageIdDataGridViewTextBoxColumn,
            this.animalSpeciesIdDataGridViewTextBoxColumn,
            this.AnimalsSpeciesColumn,
            this.animalDateDataGridViewTextBoxColumn,
            this.animalColorIdDataGridViewTextBoxColumn,
            this.AnimalsColorColumn,
            this.animalPriceDataGridViewTextBoxColumn});
            this.animalsDataGridView.DataSource = this.animalBindingSource;
            this.animalsDataGridView.Location = new System.Drawing.Point(3, 62);
            this.animalsDataGridView.Name = "animalsDataGridView";
            this.animalsDataGridView.Size = new System.Drawing.Size(774, 150);
            this.animalsDataGridView.TabIndex = 0;
            this.animalsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.animalsDataGridView_CellEndEdit);
            this.animalsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.animalsDataGridView_DataError);
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataMember = "Shop";
            this.shopBindingSource.DataSource = this.animalsDataSet;
            // 
            // animalsDataSet
            // 
            this.animalsDataSet.DataSetName = "AnimalsDataSet";
            this.animalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // speciesBindingSource
            // 
            this.speciesBindingSource.DataMember = "Species";
            this.speciesBindingSource.DataSource = this.animalsDataSet;
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataMember = "Colors";
            this.colorsBindingSource.DataSource = this.animalsDataSet;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.animalsDataSet;
            // 
            // shopsTabPage
            // 
            this.shopsTabPage.Controls.Add(this.cellsInfoButton);
            this.shopsTabPage.Controls.Add(this.shopsDeleteButton);
            this.shopsTabPage.Controls.Add(this.shopsSaveButton);
            this.shopsTabPage.Controls.Add(this.shopsDataGridView);
            this.shopsTabPage.Location = new System.Drawing.Point(4, 22);
            this.shopsTabPage.Name = "shopsTabPage";
            this.shopsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shopsTabPage.Size = new System.Drawing.Size(780, 307);
            this.shopsTabPage.TabIndex = 1;
            this.shopsTabPage.Text = "Магазини";
            this.shopsTabPage.UseVisualStyleBackColor = true;
            // 
            // cellsInfoButton
            // 
            this.cellsInfoButton.Location = new System.Drawing.Point(355, 20);
            this.cellsInfoButton.Name = "cellsInfoButton";
            this.cellsInfoButton.Size = new System.Drawing.Size(214, 23);
            this.cellsInfoButton.TabIndex = 3;
            this.cellsInfoButton.Text = "Переглянути інформацію про клітки";
            this.cellsInfoButton.UseVisualStyleBackColor = true;
            this.cellsInfoButton.Click += new System.EventHandler(this.cellsInfoButton_Click);
            // 
            // shopsDeleteButton
            // 
            this.shopsDeleteButton.Location = new System.Drawing.Point(205, 20);
            this.shopsDeleteButton.Name = "shopsDeleteButton";
            this.shopsDeleteButton.Size = new System.Drawing.Size(90, 23);
            this.shopsDeleteButton.TabIndex = 2;
            this.shopsDeleteButton.Text = "Видалити";
            this.shopsDeleteButton.UseVisualStyleBackColor = true;
            this.shopsDeleteButton.Click += new System.EventHandler(this.shopsDeleteButton_Click);
            // 
            // shopsSaveButton
            // 
            this.shopsSaveButton.Location = new System.Drawing.Point(27, 20);
            this.shopsSaveButton.Name = "shopsSaveButton";
            this.shopsSaveButton.Size = new System.Drawing.Size(99, 23);
            this.shopsSaveButton.TabIndex = 1;
            this.shopsSaveButton.Text = "Зберегти";
            this.shopsSaveButton.UseVisualStyleBackColor = true;
            this.shopsSaveButton.Click += new System.EventHandler(this.shopsSaveButton_Click);
            // 
            // shopsDataGridView
            // 
            this.shopsDataGridView.AutoGenerateColumns = false;
            this.shopsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shopIdDataGridViewTextBoxColumn,
            this.shopNameDataGridViewTextBoxColumn,
            this.shopAdressDataGridViewTextBoxColumn});
            this.shopsDataGridView.DataSource = this.shopBindingSource;
            this.shopsDataGridView.Location = new System.Drawing.Point(6, 63);
            this.shopsDataGridView.Name = "shopsDataGridView";
            this.shopsDataGridView.Size = new System.Drawing.Size(378, 216);
            this.shopsDataGridView.TabIndex = 0;
            this.shopsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.shopsDataGridView_DataError);
            // 
            // shopIdDataGridViewTextBoxColumn
            // 
            this.shopIdDataGridViewTextBoxColumn.DataPropertyName = "Shop_Id";
            this.shopIdDataGridViewTextBoxColumn.HeaderText = "Код магазину";
            this.shopIdDataGridViewTextBoxColumn.Name = "shopIdDataGridViewTextBoxColumn";
            this.shopIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.shopIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // shopNameDataGridViewTextBoxColumn
            // 
            this.shopNameDataGridViewTextBoxColumn.DataPropertyName = "Shop_Name";
            this.shopNameDataGridViewTextBoxColumn.HeaderText = "Назва магазину";
            this.shopNameDataGridViewTextBoxColumn.Name = "shopNameDataGridViewTextBoxColumn";
            // 
            // shopAdressDataGridViewTextBoxColumn
            // 
            this.shopAdressDataGridViewTextBoxColumn.DataPropertyName = "Shop_Adress";
            this.shopAdressDataGridViewTextBoxColumn.HeaderText = "Адреса магазину";
            this.shopAdressDataGridViewTextBoxColumn.Name = "shopAdressDataGridViewTextBoxColumn";
            // 
            // speciestabPage
            // 
            this.speciestabPage.Controls.Add(this.showFoodButton);
            this.speciestabPage.Controls.Add(this.speciesDeleteButton);
            this.speciestabPage.Controls.Add(this.speciesSaveButton);
            this.speciestabPage.Controls.Add(this.speciesDataGridView);
            this.speciestabPage.Location = new System.Drawing.Point(4, 22);
            this.speciestabPage.Name = "speciestabPage";
            this.speciestabPage.Size = new System.Drawing.Size(780, 307);
            this.speciestabPage.TabIndex = 2;
            this.speciestabPage.Text = "Види тварин";
            this.speciestabPage.UseVisualStyleBackColor = true;
            // 
            // showFoodButton
            // 
            this.showFoodButton.Location = new System.Drawing.Point(426, 33);
            this.showFoodButton.Name = "showFoodButton";
            this.showFoodButton.Size = new System.Drawing.Size(186, 23);
            this.showFoodButton.TabIndex = 3;
            this.showFoodButton.Text = "Переглянути інформацію про їжу";
            this.showFoodButton.UseVisualStyleBackColor = true;
            this.showFoodButton.Click += new System.EventHandler(this.showFoodButton_Click);
            // 
            // speciesDeleteButton
            // 
            this.speciesDeleteButton.Location = new System.Drawing.Point(253, 33);
            this.speciesDeleteButton.Name = "speciesDeleteButton";
            this.speciesDeleteButton.Size = new System.Drawing.Size(98, 23);
            this.speciesDeleteButton.TabIndex = 2;
            this.speciesDeleteButton.Text = "Видалити";
            this.speciesDeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.speciesDeleteButton.UseVisualStyleBackColor = true;
            this.speciesDeleteButton.Click += new System.EventHandler(this.speciesDeleteButton_Click);
            // 
            // speciesSaveButton
            // 
            this.speciesSaveButton.Location = new System.Drawing.Point(50, 33);
            this.speciesSaveButton.Name = "speciesSaveButton";
            this.speciesSaveButton.Size = new System.Drawing.Size(99, 23);
            this.speciesSaveButton.TabIndex = 1;
            this.speciesSaveButton.Text = "Зберегти";
            this.speciesSaveButton.UseVisualStyleBackColor = true;
            this.speciesSaveButton.Click += new System.EventHandler(this.speciesSaveButton_Click);
            // 
            // speciesDataGridView
            // 
            this.speciesDataGridView.AutoGenerateColumns = false;
            this.speciesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.speciesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.speciesIdDataGridViewTextBoxColumn,
            this.speciesNameDataGridViewTextBoxColumn,
            this.speciesLifetimeDataGridViewTextBoxColumn,
            this.speciesTemperatureDataGridViewTextBoxColumn});
            this.speciesDataGridView.DataSource = this.speciesBindingSource;
            this.speciesDataGridView.Location = new System.Drawing.Point(17, 62);
            this.speciesDataGridView.Name = "speciesDataGridView";
            this.speciesDataGridView.Size = new System.Drawing.Size(446, 228);
            this.speciesDataGridView.TabIndex = 0;
            this.speciesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.speciesDataGridView_CellEndEdit);
            this.speciesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.speciesDataGridView_DataError);
            // 
            // speciesIdDataGridViewTextBoxColumn
            // 
            this.speciesIdDataGridViewTextBoxColumn.DataPropertyName = "Species_Id";
            this.speciesIdDataGridViewTextBoxColumn.HeaderText = "Код виду";
            this.speciesIdDataGridViewTextBoxColumn.Name = "speciesIdDataGridViewTextBoxColumn";
            this.speciesIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.speciesIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // speciesNameDataGridViewTextBoxColumn
            // 
            this.speciesNameDataGridViewTextBoxColumn.DataPropertyName = "Species_Name";
            this.speciesNameDataGridViewTextBoxColumn.HeaderText = "Назва виду";
            this.speciesNameDataGridViewTextBoxColumn.Name = "speciesNameDataGridViewTextBoxColumn";
            // 
            // speciesLifetimeDataGridViewTextBoxColumn
            // 
            this.speciesLifetimeDataGridViewTextBoxColumn.DataPropertyName = "Species_Lifetime";
            this.speciesLifetimeDataGridViewTextBoxColumn.HeaderText = "Середня тривалість життя";
            this.speciesLifetimeDataGridViewTextBoxColumn.Name = "speciesLifetimeDataGridViewTextBoxColumn";
            // 
            // speciesTemperatureDataGridViewTextBoxColumn
            // 
            this.speciesTemperatureDataGridViewTextBoxColumn.DataPropertyName = "Species_Temperature";
            this.speciesTemperatureDataGridViewTextBoxColumn.HeaderText = "Середня комфортна температура";
            this.speciesTemperatureDataGridViewTextBoxColumn.Name = "speciesTemperatureDataGridViewTextBoxColumn";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(16, 36);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(115, 52);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Виконати пошук ";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cageBindingSource
            // 
            this.cageBindingSource.DataMember = "Cage";
            this.cageBindingSource.DataSource = this.animalsDataSet;
            // 
            // animalsDataSetBindingSource
            // 
            this.animalsDataSetBindingSource.DataSource = this.animalsDataSet;
            this.animalsDataSetBindingSource.Position = 0;
            // 
            // animalsDataSetBindingSource1
            // 
            this.animalsDataSetBindingSource1.DataSource = this.animalsDataSet;
            this.animalsDataSetBindingSource1.Position = 0;
            // 
            // shopTableAdapter
            // 
            this.shopTableAdapter.ClearBeforeFill = true;
            // 
            // speciesTableAdapter
            // 
            this.speciesTableAdapter.ClearBeforeFill = true;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // cageTableAdapter
            // 
            this.cageTableAdapter.ClearBeforeFill = true;
            // 
            // colorsTableAdapter
            // 
            this.colorsTableAdapter.ClearBeforeFill = true;
            // 
            // animalIdDataGridViewTextBoxColumn
            // 
            this.animalIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_Id";
            this.animalIdDataGridViewTextBoxColumn.HeaderText = "Animal_Id";
            this.animalIdDataGridViewTextBoxColumn.Name = "animalIdDataGridViewTextBoxColumn";
            this.animalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalNameDataGridViewTextBoxColumn
            // 
            this.animalNameDataGridViewTextBoxColumn.DataPropertyName = "Animal_Name";
            this.animalNameDataGridViewTextBoxColumn.HeaderText = "Ім\'я тварини";
            this.animalNameDataGridViewTextBoxColumn.Name = "animalNameDataGridViewTextBoxColumn";
            // 
            // animalSexDataGridViewTextBoxColumn
            // 
            this.animalSexDataGridViewTextBoxColumn.DataPropertyName = "Animal_Sex";
            this.animalSexDataGridViewTextBoxColumn.HeaderText = "Animal_Sex";
            this.animalSexDataGridViewTextBoxColumn.Name = "animalSexDataGridViewTextBoxColumn";
            this.animalSexDataGridViewTextBoxColumn.Visible = false;
            // 
            // AnimalSexColumn
            // 
            this.AnimalSexColumn.DataPropertyName = "Animal_Sex";
            this.AnimalSexColumn.HeaderText = "Стать";
            this.AnimalSexColumn.Items.AddRange(new object[] {
            "Ч",
            "Ж",
            "-"});
            this.AnimalSexColumn.Name = "AnimalSexColumn";
            // 
            // animalShopIdDataGridViewTextBoxColumn
            // 
            this.animalShopIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_ShopId";
            this.animalShopIdDataGridViewTextBoxColumn.HeaderText = "Animal_ShopId";
            this.animalShopIdDataGridViewTextBoxColumn.Name = "animalShopIdDataGridViewTextBoxColumn";
            this.animalShopIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // AnimalsShopColumn
            // 
            this.AnimalsShopColumn.DataPropertyName = "Animal_ShopId";
            this.AnimalsShopColumn.DataSource = this.shopBindingSource;
            this.AnimalsShopColumn.DisplayMember = "Shop_Name";
            this.AnimalsShopColumn.HeaderText = "Назва магазину";
            this.AnimalsShopColumn.Name = "AnimalsShopColumn";
            this.AnimalsShopColumn.ValueMember = "Shop_Id";
            // 
            // animalCageIdDataGridViewTextBoxColumn
            // 
            this.animalCageIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_CageId";
            this.animalCageIdDataGridViewTextBoxColumn.HeaderText = "Animal_CageId";
            this.animalCageIdDataGridViewTextBoxColumn.Name = "animalCageIdDataGridViewTextBoxColumn";
            this.animalCageIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalSpeciesIdDataGridViewTextBoxColumn
            // 
            this.animalSpeciesIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_SpeciesId";
            this.animalSpeciesIdDataGridViewTextBoxColumn.HeaderText = "Animal_SpeciesId";
            this.animalSpeciesIdDataGridViewTextBoxColumn.Name = "animalSpeciesIdDataGridViewTextBoxColumn";
            this.animalSpeciesIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // AnimalsSpeciesColumn
            // 
            this.AnimalsSpeciesColumn.DataPropertyName = "Animal_SpeciesId";
            this.AnimalsSpeciesColumn.DataSource = this.speciesBindingSource;
            this.AnimalsSpeciesColumn.DisplayMember = "Species_Name";
            this.AnimalsSpeciesColumn.HeaderText = "Вид тварини";
            this.AnimalsSpeciesColumn.Name = "AnimalsSpeciesColumn";
            this.AnimalsSpeciesColumn.ValueMember = "Species_Id";
            // 
            // animalDateDataGridViewTextBoxColumn
            // 
            this.animalDateDataGridViewTextBoxColumn.DataPropertyName = "Animal_Date";
            this.animalDateDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.animalDateDataGridViewTextBoxColumn.Name = "animalDateDataGridViewTextBoxColumn";
            // 
            // animalColorIdDataGridViewTextBoxColumn
            // 
            this.animalColorIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_ColorId";
            this.animalColorIdDataGridViewTextBoxColumn.HeaderText = "Animal_ColorId";
            this.animalColorIdDataGridViewTextBoxColumn.Name = "animalColorIdDataGridViewTextBoxColumn";
            this.animalColorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // AnimalsColorColumn
            // 
            this.AnimalsColorColumn.DataPropertyName = "Animal_ColorId";
            this.AnimalsColorColumn.DataSource = this.colorsBindingSource;
            this.AnimalsColorColumn.DisplayMember = "Color_Name";
            this.AnimalsColorColumn.HeaderText = "Колір";
            this.AnimalsColorColumn.Name = "AnimalsColorColumn";
            this.AnimalsColorColumn.ValueMember = "Color_Id";
            // 
            // animalPriceDataGridViewTextBoxColumn
            // 
            this.animalPriceDataGridViewTextBoxColumn.DataPropertyName = "Animal_Price";
            this.animalPriceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.animalPriceDataGridViewTextBoxColumn.Name = "animalPriceDataGridViewTextBoxColumn";
            // 
            // PetShopsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "PetShopsForm";
            this.Text = "Система контролю зоомагазинів";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PetShopsForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.animalsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.shopsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shopsDataGridView)).EndInit();
            this.speciestabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speciesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage animalsTabPage;
        private System.Windows.Forms.TabPage shopsTabPage;
        private System.Windows.Forms.TabPage speciestabPage;
        private System.Windows.Forms.DataGridView shopsDataGridView;
        private AnimalsDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private AnimalsDataSet animalsDataSet;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private AnimalsDataSetTableAdapters.ShopTableAdapter shopTableAdapter;
        private System.Windows.Forms.Button shopsSaveButton;
        private System.Windows.Forms.Button shopsDeleteButton;
        private System.Windows.Forms.DataGridView speciesDataGridView;
        private System.Windows.Forms.BindingSource speciesBindingSource;
        private AnimalsDataSetTableAdapters.SpeciesTableAdapter speciesTableAdapter;
        private System.Windows.Forms.Button speciesSaveButton;
        private System.Windows.Forms.Button speciesDeleteButton;
        private System.Windows.Forms.DataGridView animalsDataGridView;
        private System.Windows.Forms.BindingSource animalsDataSetBindingSource1;
        private System.Windows.Forms.BindingSource animalsDataSetBindingSource;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private AnimalsDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource cageBindingSource;
        private AnimalsDataSetTableAdapters.CageTableAdapter cageTableAdapter;
        private System.Windows.Forms.BindingSource colorsBindingSource;
        private AnimalsDataSetTableAdapters.ColorsTableAdapter colorsTableAdapter;
        private System.Windows.Forms.Button animalsSaveButton;
        private System.Windows.Forms.Button animalsDeleteButton;
        private System.Windows.Forms.Button cellsInfoButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesLifetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesTemperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button showFoodButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AnimalSexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalShopIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AnimalsShopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalCageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalSpeciesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AnimalsSpeciesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalColorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AnimalsColorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalPriceDataGridViewTextBoxColumn;
    }
}

