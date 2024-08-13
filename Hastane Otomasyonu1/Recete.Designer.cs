namespace Hastane_Otomasyonu1
{
    partial class Recete
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receteTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilaclarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_OtomasyonuDataSet7 = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet7();
            this.receteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_OtomasyonuDataSet6 = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet6();
            this.receteTableAdapter = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet6TableAdapters.ReceteTableAdapter();
            this.receteTableAdapter1 = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet7TableAdapters.ReceteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yeni Reçete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reçete İşlem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receteIDDataGridViewTextBoxColumn,
            this.hastaIDDataGridViewTextBoxColumn,
            this.receteTarihiDataGridViewTextBoxColumn,
            this.doktorAdıDataGridViewTextBoxColumn,
            this.ilaclarDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receteBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(52, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // receteIDDataGridViewTextBoxColumn
            // 
            this.receteIDDataGridViewTextBoxColumn.DataPropertyName = "ReceteID";
            this.receteIDDataGridViewTextBoxColumn.HeaderText = "ReceteID";
            this.receteIDDataGridViewTextBoxColumn.Name = "receteIDDataGridViewTextBoxColumn";
            // 
            // hastaIDDataGridViewTextBoxColumn
            // 
            this.hastaIDDataGridViewTextBoxColumn.DataPropertyName = "HastaID";
            this.hastaIDDataGridViewTextBoxColumn.HeaderText = "HastaID";
            this.hastaIDDataGridViewTextBoxColumn.Name = "hastaIDDataGridViewTextBoxColumn";
            // 
            // receteTarihiDataGridViewTextBoxColumn
            // 
            this.receteTarihiDataGridViewTextBoxColumn.DataPropertyName = "ReceteTarihi";
            this.receteTarihiDataGridViewTextBoxColumn.HeaderText = "ReceteTarihi";
            this.receteTarihiDataGridViewTextBoxColumn.Name = "receteTarihiDataGridViewTextBoxColumn";
            // 
            // doktorAdıDataGridViewTextBoxColumn
            // 
            this.doktorAdıDataGridViewTextBoxColumn.DataPropertyName = "DoktorAdı";
            this.doktorAdıDataGridViewTextBoxColumn.HeaderText = "DoktorAdı";
            this.doktorAdıDataGridViewTextBoxColumn.Name = "doktorAdıDataGridViewTextBoxColumn";
            // 
            // ilaclarDataGridViewTextBoxColumn
            // 
            this.ilaclarDataGridViewTextBoxColumn.DataPropertyName = "İlaclar";
            this.ilaclarDataGridViewTextBoxColumn.HeaderText = "İlaclar";
            this.ilaclarDataGridViewTextBoxColumn.Name = "ilaclarDataGridViewTextBoxColumn";
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            // 
            // receteBindingSource1
            // 
            this.receteBindingSource1.DataMember = "Recete";
            this.receteBindingSource1.DataSource = this.hastane_OtomasyonuDataSet7;
            // 
            // hastane_OtomasyonuDataSet7
            // 
            this.hastane_OtomasyonuDataSet7.DataSetName = "Hastane_OtomasyonuDataSet7";
            this.hastane_OtomasyonuDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receteBindingSource
            // 
            this.receteBindingSource.DataMember = "Recete";
            this.receteBindingSource.DataSource = this.hastane_OtomasyonuDataSet6;
            // 
            // hastane_OtomasyonuDataSet6
            // 
            this.hastane_OtomasyonuDataSet6.DataSetName = "Hastane_OtomasyonuDataSet6";
            this.hastane_OtomasyonuDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receteTableAdapter
            // 
            this.receteTableAdapter.ClearBeforeFill = true;
            // 
            // receteTableAdapter1
            // 
            this.receteTableAdapter1.ClearBeforeFill = true;
            // 
            // Recete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hastane_Otomasyonu1.Properties.Resources.images4;
            this.ClientSize = new System.Drawing.Size(569, 350);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Recete";
            this.Text = "Recete";
            this.Load += new System.EventHandler(this.Recete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Hastane_OtomasyonuDataSet6 hastane_OtomasyonuDataSet6;
        private System.Windows.Forms.BindingSource receteBindingSource;
        private Hastane_OtomasyonuDataSet6TableAdapters.ReceteTableAdapter receteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn receteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receteTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilaclarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private Hastane_OtomasyonuDataSet7 hastane_OtomasyonuDataSet7;
        private System.Windows.Forms.BindingSource receteBindingSource1;
        private Hastane_OtomasyonuDataSet7TableAdapters.ReceteTableAdapter receteTableAdapter1;
    }
}