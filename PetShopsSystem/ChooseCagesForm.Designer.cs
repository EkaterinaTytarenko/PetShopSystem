namespace PetShopsSystem
{
    partial class ChooseCagesForm
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
            System.Windows.Forms.Label textLabel;
            this.cageNumsComboBox = new System.Windows.Forms.ComboBox();
            this.cage1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsDataSet = new PetShopsSystem.AnimalsDataSet();
            this.cage1TableAdapter = new PetShopsSystem.AnimalsDataSetTableAdapters.Cage1TableAdapter();
            this.chooseCagesButton = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new PetShopsSystem.AnimalsDataSetTableAdapters.QueriesTableAdapter();
            textLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cage1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cageNumsComboBox
            // 
            this.cageNumsComboBox.DataSource = this.cage1BindingSource;
            this.cageNumsComboBox.DisplayMember = "Cage_Number";
            this.cageNumsComboBox.FormattingEnabled = true;
            this.cageNumsComboBox.Location = new System.Drawing.Point(129, 119);
            this.cageNumsComboBox.Name = "cageNumsComboBox";
            this.cageNumsComboBox.Size = new System.Drawing.Size(121, 21);
            this.cageNumsComboBox.TabIndex = 0;
            this.cageNumsComboBox.ValueMember = "Cage_Number";
            // 
            // cage1BindingSource
            // 
            this.cage1BindingSource.DataMember = "Cage1";
            this.cage1BindingSource.DataSource = this.animalsDataSet;
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
            // chooseCagesButton
            // 
            this.chooseCagesButton.Location = new System.Drawing.Point(129, 181);
            this.chooseCagesButton.Name = "chooseCagesButton";
            this.chooseCagesButton.Size = new System.Drawing.Size(121, 23);
            this.chooseCagesButton.TabIndex = 1;
            this.chooseCagesButton.Text = "Ок";
            this.chooseCagesButton.UseVisualStyleBackColor = true;
            this.chooseCagesButton.Click += new System.EventHandler(this.chooseCagesButton_Click);
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new System.Drawing.Point(55, 70);
            textLabel.Name = "textLabel";
            textLabel.Size = new System.Drawing.Size(319, 13);
            textLabel.TabIndex = 2;
            textLabel.Text = "Оберіть для своєї тварини одну з кліток в обраному магазині";
            // 
            // ChooseCagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(textLabel);
            this.Controls.Add(this.chooseCagesButton);
            this.Controls.Add(this.cageNumsComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "ChooseCagesForm";
            this.Text = "ChooseCagesForm";
            ((System.ComponentModel.ISupportInitialize)(this.cage1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cageNumsComboBox;
        private System.Windows.Forms.BindingSource cage1BindingSource;
        private AnimalsDataSet animalsDataSet;
        private AnimalsDataSetTableAdapters.Cage1TableAdapter cage1TableAdapter;
        private System.Windows.Forms.Button chooseCagesButton;
        private AnimalsDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}