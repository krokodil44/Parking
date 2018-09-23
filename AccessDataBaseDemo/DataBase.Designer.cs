namespace AccessDataBaseDemo
{
    partial class DataBase
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
            this.parkingDataSet1 = new AccessDataBaseDemo.ParkingDataSet1();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingTableAdapter = new AccessDataBaseDemo.ParkingDataSet1TableAdapters.ParkingTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gosNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandAutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelAutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.gosNumDataGridViewTextBoxColumn,
            this.brandAutoDataGridViewTextBoxColumn,
            this.modelAutoDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.dateOutDataGridViewTextBoxColumn,
            this.sumInDataGridViewTextBoxColumn,
            this.sumOutDataGridViewTextBoxColumn,
            this.outDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.parkingBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // parkingDataSet1
            // 
            this.parkingDataSet1.DataSetName = "ParkingDataSet1";
            this.parkingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkingBindingSource
            // 
            this.parkingBindingSource.DataMember = "Parking";
            this.parkingBindingSource.DataSource = this.parkingDataSet1;
            // 
            // parkingTableAdapter
            // 
            this.parkingTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "Fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Fio";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // gosNumDataGridViewTextBoxColumn
            // 
            this.gosNumDataGridViewTextBoxColumn.DataPropertyName = "GosNum";
            this.gosNumDataGridViewTextBoxColumn.HeaderText = "GosNum";
            this.gosNumDataGridViewTextBoxColumn.Name = "gosNumDataGridViewTextBoxColumn";
            // 
            // brandAutoDataGridViewTextBoxColumn
            // 
            this.brandAutoDataGridViewTextBoxColumn.DataPropertyName = "BrandAuto";
            this.brandAutoDataGridViewTextBoxColumn.HeaderText = "BrandAuto";
            this.brandAutoDataGridViewTextBoxColumn.Name = "brandAutoDataGridViewTextBoxColumn";
            // 
            // modelAutoDataGridViewTextBoxColumn
            // 
            this.modelAutoDataGridViewTextBoxColumn.DataPropertyName = "ModelAuto";
            this.modelAutoDataGridViewTextBoxColumn.HeaderText = "ModelAuto";
            this.modelAutoDataGridViewTextBoxColumn.Name = "modelAutoDataGridViewTextBoxColumn";
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "DateIn";
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            // 
            // dateOutDataGridViewTextBoxColumn
            // 
            this.dateOutDataGridViewTextBoxColumn.DataPropertyName = "DateOut";
            this.dateOutDataGridViewTextBoxColumn.HeaderText = "DateOut";
            this.dateOutDataGridViewTextBoxColumn.Name = "dateOutDataGridViewTextBoxColumn";
            // 
            // sumInDataGridViewTextBoxColumn
            // 
            this.sumInDataGridViewTextBoxColumn.DataPropertyName = "SumIn";
            this.sumInDataGridViewTextBoxColumn.HeaderText = "SumIn";
            this.sumInDataGridViewTextBoxColumn.Name = "sumInDataGridViewTextBoxColumn";
            // 
            // sumOutDataGridViewTextBoxColumn
            // 
            this.sumOutDataGridViewTextBoxColumn.DataPropertyName = "SumOut";
            this.sumOutDataGridViewTextBoxColumn.HeaderText = "SumOut";
            this.sumOutDataGridViewTextBoxColumn.Name = "sumOutDataGridViewTextBoxColumn";
            // 
            // outDataGridViewCheckBoxColumn
            // 
            this.outDataGridViewCheckBoxColumn.DataPropertyName = "Out";
            this.outDataGridViewCheckBoxColumn.HeaderText = "Out";
            this.outDataGridViewCheckBoxColumn.Name = "outDataGridViewCheckBoxColumn";
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataBase";
            this.Text = "DataBase";
            this.Load += new System.EventHandler(this.DataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ParkingDataSet1 parkingDataSet1;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private ParkingDataSet1TableAdapters.ParkingTableAdapter parkingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gosNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandAutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelAutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn outDataGridViewCheckBoxColumn;
    }
}