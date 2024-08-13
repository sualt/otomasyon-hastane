namespace Hastane_Otomasyonu1
{
    partial class Kan_Verenlerin_Listesi
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
            this.bagısIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagıscıİsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagıscıSoyismiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagıscıYasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagıscıCinsiyetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagıscıTcsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanGrubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamKanVermeSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanVerenlerinListesiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_OtomasyonuDataSet4 = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.hastane_OtomasyonuDataSet2 = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet2();
            this.kanVerenlerinListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kanVerenlerinListesiTableAdapter = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet2TableAdapters.KanVerenlerinListesiTableAdapter();
            this.hastane_OtomasyonuDataSet3 = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet3();
            this.kanVerenlerinListesiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kanVerenlerinListesiTableAdapter1 = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet3TableAdapters.KanVerenlerinListesiTableAdapter();
            this.kanVerenlerinListesiTableAdapter2 = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet4TableAdapters.KanVerenlerinListesiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanVerenlerinListesiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanVerenlerinListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanVerenlerinListesiBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.bagısIDDataGridViewTextBoxColumn,
            this.bagıscıİsmiDataGridViewTextBoxColumn,
            this.bagıscıSoyismiDataGridViewTextBoxColumn,
            this.bagıscıYasıDataGridViewTextBoxColumn,
            this.bagıscıCinsiyetiDataGridViewTextBoxColumn,
            this.bagıscıTcsiDataGridViewTextBoxColumn,
            this.kanGrubuDataGridViewTextBoxColumn,
            this.toplamKanVermeSayısıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kanVerenlerinListesiBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(54, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(597, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // bagısIDDataGridViewTextBoxColumn
            // 
            this.bagısIDDataGridViewTextBoxColumn.DataPropertyName = "BagısID";
            this.bagısIDDataGridViewTextBoxColumn.HeaderText = "BagısID";
            this.bagısIDDataGridViewTextBoxColumn.Name = "bagısIDDataGridViewTextBoxColumn";
            this.bagısIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagıscıİsmiDataGridViewTextBoxColumn
            // 
            this.bagıscıİsmiDataGridViewTextBoxColumn.DataPropertyName = "Bagıscıİsmi";
            this.bagıscıİsmiDataGridViewTextBoxColumn.HeaderText = "Bagıscıİsmi";
            this.bagıscıİsmiDataGridViewTextBoxColumn.Name = "bagıscıİsmiDataGridViewTextBoxColumn";
            this.bagıscıİsmiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagıscıSoyismiDataGridViewTextBoxColumn
            // 
            this.bagıscıSoyismiDataGridViewTextBoxColumn.DataPropertyName = "BagıscıSoyismi";
            this.bagıscıSoyismiDataGridViewTextBoxColumn.HeaderText = "BagıscıSoyismi";
            this.bagıscıSoyismiDataGridViewTextBoxColumn.Name = "bagıscıSoyismiDataGridViewTextBoxColumn";
            this.bagıscıSoyismiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagıscıYasıDataGridViewTextBoxColumn
            // 
            this.bagıscıYasıDataGridViewTextBoxColumn.DataPropertyName = "BagıscıYası";
            this.bagıscıYasıDataGridViewTextBoxColumn.HeaderText = "BagıscıYası";
            this.bagıscıYasıDataGridViewTextBoxColumn.Name = "bagıscıYasıDataGridViewTextBoxColumn";
            this.bagıscıYasıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagıscıCinsiyetiDataGridViewTextBoxColumn
            // 
            this.bagıscıCinsiyetiDataGridViewTextBoxColumn.DataPropertyName = "BagıscıCinsiyeti";
            this.bagıscıCinsiyetiDataGridViewTextBoxColumn.HeaderText = "BagıscıCinsiyeti";
            this.bagıscıCinsiyetiDataGridViewTextBoxColumn.Name = "bagıscıCinsiyetiDataGridViewTextBoxColumn";
            this.bagıscıCinsiyetiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagıscıTcsiDataGridViewTextBoxColumn
            // 
            this.bagıscıTcsiDataGridViewTextBoxColumn.DataPropertyName = "BagıscıTcsi";
            this.bagıscıTcsiDataGridViewTextBoxColumn.HeaderText = "BagıscıTcsi";
            this.bagıscıTcsiDataGridViewTextBoxColumn.Name = "bagıscıTcsiDataGridViewTextBoxColumn";
            this.bagıscıTcsiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kanGrubuDataGridViewTextBoxColumn
            // 
            this.kanGrubuDataGridViewTextBoxColumn.DataPropertyName = "KanGrubu";
            this.kanGrubuDataGridViewTextBoxColumn.HeaderText = "KanGrubu";
            this.kanGrubuDataGridViewTextBoxColumn.Name = "kanGrubuDataGridViewTextBoxColumn";
            this.kanGrubuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toplamKanVermeSayısıDataGridViewTextBoxColumn
            // 
            this.toplamKanVermeSayısıDataGridViewTextBoxColumn.DataPropertyName = "ToplamKanVermeSayısı";
            this.toplamKanVermeSayısıDataGridViewTextBoxColumn.HeaderText = "ToplamKanVermeSayısı";
            this.toplamKanVermeSayısıDataGridViewTextBoxColumn.Name = "toplamKanVermeSayısıDataGridViewTextBoxColumn";
            this.toplamKanVermeSayısıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kanVerenlerinListesiBindingSource2
            // 
            this.kanVerenlerinListesiBindingSource2.DataMember = "KanVerenlerinListesi";
            this.kanVerenlerinListesiBindingSource2.DataSource = this.hastane_OtomasyonuDataSet4;
            // 
            // hastane_OtomasyonuDataSet4
            // 
            this.hastane_OtomasyonuDataSet4.DataSetName = "Hastane_OtomasyonuDataSet4";
            this.hastane_OtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yeni Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(515, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kayıt Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // hastane_OtomasyonuDataSet2
            // 
            this.hastane_OtomasyonuDataSet2.DataSetName = "Hastane_OtomasyonuDataSet2";
            this.hastane_OtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kanVerenlerinListesiBindingSource
            // 
            this.kanVerenlerinListesiBindingSource.DataMember = "KanVerenlerinListesi";
            this.kanVerenlerinListesiBindingSource.DataSource = this.hastane_OtomasyonuDataSet2;
            // 
            // kanVerenlerinListesiTableAdapter
            // 
            this.kanVerenlerinListesiTableAdapter.ClearBeforeFill = true;
            // 
            // hastane_OtomasyonuDataSet3
            // 
            this.hastane_OtomasyonuDataSet3.DataSetName = "Hastane_OtomasyonuDataSet3";
            this.hastane_OtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kanVerenlerinListesiBindingSource1
            // 
            this.kanVerenlerinListesiBindingSource1.DataMember = "KanVerenlerinListesi";
            this.kanVerenlerinListesiBindingSource1.DataSource = this.hastane_OtomasyonuDataSet3;
            // 
            // kanVerenlerinListesiTableAdapter1
            // 
            this.kanVerenlerinListesiTableAdapter1.ClearBeforeFill = true;
            // 
            // kanVerenlerinListesiTableAdapter2
            // 
            this.kanVerenlerinListesiTableAdapter2.ClearBeforeFill = true;
            // 
            // Kan_Verenlerin_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hastane_Otomasyonu1.Properties.Resources._609b7cba70380e0fe09448c9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 367);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kan_Verenlerin_Listesi";
            this.Text = "Kan_Verenlerin_Listesi";
            this.Load += new System.EventHandler(this.Kan_Verenlerin_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanVerenlerinListesiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanVerenlerinListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanVerenlerinListesiBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private Hastane_OtomasyonuDataSet2 hastane_OtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource kanVerenlerinListesiBindingSource;
        private Hastane_OtomasyonuDataSet2TableAdapters.KanVerenlerinListesiTableAdapter kanVerenlerinListesiTableAdapter;
        private Hastane_OtomasyonuDataSet3 hastane_OtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource kanVerenlerinListesiBindingSource1;
        private Hastane_OtomasyonuDataSet3TableAdapters.KanVerenlerinListesiTableAdapter kanVerenlerinListesiTableAdapter1;
        private Hastane_OtomasyonuDataSet4 hastane_OtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource kanVerenlerinListesiBindingSource2;
        private Hastane_OtomasyonuDataSet4TableAdapters.KanVerenlerinListesiTableAdapter kanVerenlerinListesiTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagısIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagıscıİsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagıscıSoyismiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagıscıYasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagıscıCinsiyetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagıscıTcsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanGrubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamKanVermeSayısıDataGridViewTextBoxColumn;
    }
}