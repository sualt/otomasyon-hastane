namespace Hastane_Otomasyonu1
{
    partial class Kan_Veren_Güncelleme
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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bagısIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagıscıİsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagıscıSoyismiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagıscıYasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagıscıCinsiyetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagıscıTcsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanGrubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamKanVermeSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanVerenlerinListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_OtomasyonuDataSet4 = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet4();
            this.kanVerenlerinListesiTableAdapter = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet4TableAdapters.KanVerenlerinListesiTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanVerenlerinListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "Kan Bağışı Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(200, 329);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 28;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(200, 285);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 27;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(200, 247);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 201);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "KAN VERME SAYISI";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "KAN GRUBU";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "KAN VEREN TC Sİ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "KAN VEREN CİNSİYETİ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "KAN VEREN YAŞI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "KAN VEREN SOYİSMİ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "KAN VEREN İSMİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dataGridView1.DataSource = this.kanVerenlerinListesiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(324, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(471, 172);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
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
            // kanVerenlerinListesiBindingSource
            // 
            this.kanVerenlerinListesiBindingSource.DataMember = "KanVerenlerinListesi";
            this.kanVerenlerinListesiBindingSource.DataSource = this.hastane_OtomasyonuDataSet4;
            // 
            // hastane_OtomasyonuDataSet4
            // 
            this.hastane_OtomasyonuDataSet4.DataSetName = "Hastane_OtomasyonuDataSet4";
            this.hastane_OtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kanVerenlerinListesiTableAdapter
            // 
            this.kanVerenlerinListesiTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "KAN VEREN ID Sİ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(200, 28);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 32;
            // 
            // Kan_Veren_Güncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hastane_Otomasyonu1.Properties.Resources._72;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kan_Veren_Güncelleme";
            this.Text = "Kan_Veren_Güncelleme";
            this.Load += new System.EventHandler(this.Kan_Veren_Güncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanVerenlerinListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Hastane_OtomasyonuDataSet4 hastane_OtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource kanVerenlerinListesiBindingSource;
        private Hastane_OtomasyonuDataSet4TableAdapters.KanVerenlerinListesiTableAdapter kanVerenlerinListesiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagısIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagıscıİsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagıscıSoyismiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagıscıYasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagıscıCinsiyetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagıscıTcsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanGrubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamKanVermeSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
    }
}