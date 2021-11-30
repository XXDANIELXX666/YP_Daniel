
namespace WindowsFormsApp11
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
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Добавить = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fFFFDataSet = new WindowsFormsApp11.FFFFDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp11.FFFFDataSetTableAdapters.ClientTableAdapter();
            this.serviceTableAdapter = new WindowsFormsApp11.FFFFDataSetTableAdapters.ServiceTableAdapter();
            this.clientServiceTableAdapter = new WindowsFormsApp11.FFFFDataSetTableAdapters.ClientServiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFFFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(361, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // Добавить
            // 
            this.Добавить.BackColor = System.Drawing.Color.White;
            this.Добавить.Location = new System.Drawing.Point(229, 365);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(87, 52);
            this.Добавить.TabIndex = 11;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = false;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.serviceBindingSource;
            this.comboBox2.DisplayMember = "Title";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(179, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(336, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "ID";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.fFFFDataSet;
            // 
            // fFFFDataSet
            // 
            this.fFFFDataSet.DataSetName = "FFFFDataSet";
            this.fFFFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientBindingSource;
            this.comboBox1.DisplayMember = "FirstName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "ID";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.fFFFDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.serviceIDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.clientServiceBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(168, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(570, 150);
            this.dataGridView2.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // clientServiceBindingSource
            // 
            this.clientServiceBindingSource.DataMember = "ClientService";
            this.clientServiceBindingSource.DataSource = this.fFFFDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // clientServiceTableAdapter
            // 
            this.clientServiceTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFFFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientServiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private FFFFDataSet fFFFDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private FFFFDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private FFFFDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.BindingSource clientServiceBindingSource;
        private FFFFDataSetTableAdapters.ClientServiceTableAdapter clientServiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}