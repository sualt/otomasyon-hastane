namespace Hastane_Otomasyonu1
{
    partial class İlaç_Güncelle_Formu
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ilacIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacFirmasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacAcıklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_OtomasyonuDataSet1 = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet1();
            this.İlacTableAdapter = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet1TableAdapters.İlacTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(381, 336);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 96);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(541, 301);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(541, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "İlaç Açıklaması";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "İlaç Firması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "İlaç Adı";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(299, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 35);
            this.button3.TabIndex = 27;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ilacIDDataGridViewTextBoxColumn,
            this.ilacAdDataGridViewTextBoxColumn,
            this.ilacFirmasıDataGridViewTextBoxColumn,
            this.ilacAcıklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ilacBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(82, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(571, 160);
            this.dataGridView1.TabIndex = 28;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(541, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "İlaçID";
            // 
            // İlaç_Güncelle_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hastane_Otomasyonu1.Properties.Resources._2_245_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "İlaç_Güncelle_Formu";
            this.Text = "İlaç_Güncelle_Formu";
            this.Load += new System.EventHandler(this.İlaç_Güncelle_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Hastane_OtomasyonuDataSet1 hastane_OtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource ilacBindingSource;
        private Hastane_OtomasyonuDataSet1TableAdapters.İlacTableAdapter İlacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacFirmasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacAcıklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}