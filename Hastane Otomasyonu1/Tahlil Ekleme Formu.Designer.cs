namespace Hastane_Otomasyonu1
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tahlilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahlilAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahlilAcıklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahlilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_OtomasyonuDataSet5 = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet5();
            this.tahlilTableAdapter = new Hastane_Otomasyonu1.Hastane_OtomasyonuDataSet5TableAdapters.TahlilTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahlilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TahlilID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tahlil Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 353);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taklil Açıklaması";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 193);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 271);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(216, 350);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(371, 118);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 513);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tahlil Sonucu Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tahlilIDDataGridViewTextBoxColumn,
            this.tahlilAdDataGridViewTextBoxColumn,
            this.tahlilAcıklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tahlilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // tahlilIDDataGridViewTextBoxColumn
            // 
            this.tahlilIDDataGridViewTextBoxColumn.DataPropertyName = "TahlilID";
            this.tahlilIDDataGridViewTextBoxColumn.HeaderText = "TahlilID";
            this.tahlilIDDataGridViewTextBoxColumn.Name = "tahlilIDDataGridViewTextBoxColumn";
            // 
            // tahlilAdDataGridViewTextBoxColumn
            // 
            this.tahlilAdDataGridViewTextBoxColumn.DataPropertyName = "TahlilAd";
            this.tahlilAdDataGridViewTextBoxColumn.HeaderText = "TahlilAd";
            this.tahlilAdDataGridViewTextBoxColumn.Name = "tahlilAdDataGridViewTextBoxColumn";
            // 
            // tahlilAcıklamaDataGridViewTextBoxColumn
            // 
            this.tahlilAcıklamaDataGridViewTextBoxColumn.DataPropertyName = "TahlilAcıklama";
            this.tahlilAcıklamaDataGridViewTextBoxColumn.HeaderText = "TahlilAcıklama";
            this.tahlilAcıklamaDataGridViewTextBoxColumn.Name = "tahlilAcıklamaDataGridViewTextBoxColumn";
            // 
            // tahlilBindingSource
            // 
            this.tahlilBindingSource.DataMember = "Tahlil";
            this.tahlilBindingSource.DataSource = this.hastane_OtomasyonuDataSet5;
            // 
            // hastane_OtomasyonuDataSet5
            // 
            this.hastane_OtomasyonuDataSet5.DataSetName = "Hastane_OtomasyonuDataSet5";
            this.hastane_OtomasyonuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tahlilTableAdapter
            // 
            this.tahlilTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 513);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "Tahlil Sonucu Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hastane_Otomasyonu1.Properties.Resources.hiv_aids_og_banner;
            this.ClientSize = new System.Drawing.Size(767, 587);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahlilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Hastane_OtomasyonuDataSet5 hastane_OtomasyonuDataSet5;
        private System.Windows.Forms.BindingSource tahlilBindingSource;
        private Hastane_OtomasyonuDataSet5TableAdapters.TahlilTableAdapter tahlilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahlilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahlilAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahlilAcıklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}