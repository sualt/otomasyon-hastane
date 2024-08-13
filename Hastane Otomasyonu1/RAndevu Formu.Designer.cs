namespace Hastane_Otomasyonu1
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bölümDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_OtomasyonuDataSet = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.randevuTableAdapter = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSetTableAdapters.RandevuTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hastaAdıDataGridViewTextBoxColumn,
            this.hastaSoyadıDataGridViewTextBoxColumn,
            this.hastaTcNoDataGridViewTextBoxColumn,
            this.randevuTarihiDataGridViewTextBoxColumn,
            this.doktorDataGridViewTextBoxColumn,
            this.bölümDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.randevuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hastaAdıDataGridViewTextBoxColumn
            // 
            this.hastaAdıDataGridViewTextBoxColumn.DataPropertyName = "HastaAdı";
            this.hastaAdıDataGridViewTextBoxColumn.HeaderText = "HastaAdı";
            this.hastaAdıDataGridViewTextBoxColumn.Name = "hastaAdıDataGridViewTextBoxColumn";
            // 
            // hastaSoyadıDataGridViewTextBoxColumn
            // 
            this.hastaSoyadıDataGridViewTextBoxColumn.DataPropertyName = "HastaSoyadı";
            this.hastaSoyadıDataGridViewTextBoxColumn.HeaderText = "HastaSoyadı";
            this.hastaSoyadıDataGridViewTextBoxColumn.Name = "hastaSoyadıDataGridViewTextBoxColumn";
            // 
            // hastaTcNoDataGridViewTextBoxColumn
            // 
            this.hastaTcNoDataGridViewTextBoxColumn.DataPropertyName = "HastaTcNo";
            this.hastaTcNoDataGridViewTextBoxColumn.HeaderText = "HastaTcNo";
            this.hastaTcNoDataGridViewTextBoxColumn.Name = "hastaTcNoDataGridViewTextBoxColumn";
            // 
            // randevuTarihiDataGridViewTextBoxColumn
            // 
            this.randevuTarihiDataGridViewTextBoxColumn.DataPropertyName = "RandevuTarihi";
            this.randevuTarihiDataGridViewTextBoxColumn.HeaderText = "RandevuTarihi";
            this.randevuTarihiDataGridViewTextBoxColumn.Name = "randevuTarihiDataGridViewTextBoxColumn";
            // 
            // doktorDataGridViewTextBoxColumn
            // 
            this.doktorDataGridViewTextBoxColumn.DataPropertyName = "Doktor";
            this.doktorDataGridViewTextBoxColumn.HeaderText = "Doktor";
            this.doktorDataGridViewTextBoxColumn.Name = "doktorDataGridViewTextBoxColumn";
            // 
            // bölümDataGridViewTextBoxColumn
            // 
            this.bölümDataGridViewTextBoxColumn.DataPropertyName = "Bölüm";
            this.bölümDataGridViewTextBoxColumn.HeaderText = "Bölüm";
            this.bölümDataGridViewTextBoxColumn.Name = "bölümDataGridViewTextBoxColumn";
            // 
            // randevuBindingSource
            // 
            this.randevuBindingSource.DataMember = "Randevu";
            this.randevuBindingSource.DataSource = this.hastane_OtomasyonuDataSet;
            // 
            // hastane_OtomasyonuDataSet
            // 
            this.hastane_OtomasyonuDataSet.DataSetName = "Hastane_OtomasyonuDataSet";
            this.hastane_OtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(509, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Randevu Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // randevuTableAdapter
            // 
            this.randevuTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane_Otomasyonu1.Properties.Resources._52358869_life_and_health_insurance_icon;
            this.pictureBox1.Location = new System.Drawing.Point(44, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 429);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Hastane_OtomasyonuDataSet hastane_OtomasyonuDataSet;
        private System.Windows.Forms.BindingSource randevuBindingSource;
        private Hastane_OtomasyonuDataSetTableAdapters.RandevuTableAdapter randevuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bölümDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}