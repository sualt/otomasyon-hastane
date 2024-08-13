namespace Hastane_Otomasyonu1
{
    partial class İlaç_Deposu
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ilacIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacFirmasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacAcıklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_OtomasyonuDataSet1 = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet1();
            this.İlacTableAdapter = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet1TableAdapters.İlacTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "İlaç Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ilacIDDataGridViewTextBoxColumn,
            this.ilacAdDataGridViewTextBoxColumn,
            this.ilacFirmasıDataGridViewTextBoxColumn,
            this.ilacAcıklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ilacBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(625, 233);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // ilacIDDataGridViewTextBoxColumn
            // 
            this.ilacIDDataGridViewTextBoxColumn.DataPropertyName = "İlacID";
            this.ilacIDDataGridViewTextBoxColumn.HeaderText = "İlacID";
            this.ilacIDDataGridViewTextBoxColumn.Name = "ilacIDDataGridViewTextBoxColumn";
            this.ilacIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilacAdDataGridViewTextBoxColumn
            // 
            this.ilacAdDataGridViewTextBoxColumn.DataPropertyName = "İlacAd";
            this.ilacAdDataGridViewTextBoxColumn.HeaderText = "İlacAd";
            this.ilacAdDataGridViewTextBoxColumn.Name = "ilacAdDataGridViewTextBoxColumn";
            this.ilacAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilacFirmasıDataGridViewTextBoxColumn
            // 
            this.ilacFirmasıDataGridViewTextBoxColumn.DataPropertyName = "İlacFirması";
            this.ilacFirmasıDataGridViewTextBoxColumn.HeaderText = "İlacFirması";
            this.ilacFirmasıDataGridViewTextBoxColumn.Name = "ilacFirmasıDataGridViewTextBoxColumn";
            this.ilacFirmasıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilacAcıklamaDataGridViewTextBoxColumn
            // 
            this.ilacAcıklamaDataGridViewTextBoxColumn.DataPropertyName = "İlacAcıklama";
            this.ilacAcıklamaDataGridViewTextBoxColumn.HeaderText = "İlacAcıklama";
            this.ilacAcıklamaDataGridViewTextBoxColumn.Name = "ilacAcıklamaDataGridViewTextBoxColumn";
            this.ilacAcıklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilacBindingSource
            // 
            this.ilacBindingSource.DataMember = "İlac";
            this.ilacBindingSource.DataSource = this.hastane_OtomasyonuDataSet1;
            // 
            // hastane_OtomasyonuDataSet1
            // 
            this.hastane_OtomasyonuDataSet1.DataSetName = "Hastane_OtomasyonuDataSet1";
            this.hastane_OtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // İlacTableAdapter
            // 
            this.İlacTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "İlaç Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "İlaç Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // İlaç_Deposu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hastane_Otomasyonu1.Properties.Resources.istockphoto_1193707945_1024x1024;
            this.ClientSize = new System.Drawing.Size(686, 381);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "İlaç_Deposu";
            this.Text = "İlaç_Deposu";
            this.Load += new System.EventHandler(this.İlaç_Deposu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Hastane_OtomasyonuDataSet1 hastane_OtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource ilacBindingSource;
        private Hastane_OtomasyonuDataSet1TableAdapters.İlacTableAdapter İlacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacFirmasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacAcıklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}