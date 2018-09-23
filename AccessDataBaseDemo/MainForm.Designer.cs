namespace AccessDataBaseDemo
{
    partial class MainForm
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
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGosNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrandAuto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxModelAuto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSumIn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.parkingDataSet = new AccessDataBaseDemo.ParkingDataSet();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingTableAdapter = new AccessDataBaseDemo.ParkingDataSetTableAdapters.ParkingTableAdapter();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxSumOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSumItog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDateIn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.ViewAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(121, 28);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(202, 20);
            this.textBoxFio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // textBoxGosNum
            // 
            this.textBoxGosNum.Location = new System.Drawing.Point(121, 54);
            this.textBoxGosNum.Name = "textBoxGosNum";
            this.textBoxGosNum.Size = new System.Drawing.Size(202, 20);
            this.textBoxGosNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Гос. Номер";
            // 
            // textBoxBrandAuto
            // 
            this.textBoxBrandAuto.Location = new System.Drawing.Point(121, 80);
            this.textBoxBrandAuto.Name = "textBoxBrandAuto";
            this.textBoxBrandAuto.Size = new System.Drawing.Size(202, 20);
            this.textBoxBrandAuto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Марка";
            // 
            // textBoxModelAuto
            // 
            this.textBoxModelAuto.Location = new System.Drawing.Point(121, 106);
            this.textBoxModelAuto.Name = "textBoxModelAuto";
            this.textBoxModelAuto.Size = new System.Drawing.Size(202, 20);
            this.textBoxModelAuto.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Модель";
            // 
            // textBoxSumIn
            // 
            this.textBoxSumIn.Location = new System.Drawing.Point(121, 132);
            this.textBoxSumIn.Name = "textBoxSumIn";
            this.textBoxSumIn.Size = new System.Drawing.Size(202, 20);
            this.textBoxSumIn.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Оплачено";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(121, 176);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(202, 30);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Заехать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // parkingDataSet
            // 
            this.parkingDataSet.DataSetName = "ParkingDataSet";
            this.parkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkingBindingSource
            // 
            this.parkingBindingSource.DataMember = "Parking";
            this.parkingBindingSource.DataSource = this.parkingDataSet;
            // 
            // parkingTableAdapter
            // 
            this.parkingTableAdapter.ClearBeforeFill = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(358, 53);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(49, 21);
            this.buttonFind.TabIndex = 6;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxSumOut
            // 
            this.textBoxSumOut.Location = new System.Drawing.Point(435, 132);
            this.textBoxSumOut.Name = "textBoxSumOut";
            this.textBoxSumOut.ReadOnly = true;
            this.textBoxSumOut.Size = new System.Drawing.Size(202, 20);
            this.textBoxSumOut.TabIndex = 11;
            this.textBoxSumOut.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "К оплате";
            // 
            // textBoxSumItog
            // 
            this.textBoxSumItog.Location = new System.Drawing.Point(435, 106);
            this.textBoxSumItog.Name = "textBoxSumItog";
            this.textBoxSumItog.ReadOnly = true;
            this.textBoxSumItog.Size = new System.Drawing.Size(202, 20);
            this.textBoxSumItog.TabIndex = 10;
            this.textBoxSumItog.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Итого";
            // 
            // textBoxDateIn
            // 
            this.textBoxDateIn.Location = new System.Drawing.Point(435, 80);
            this.textBoxDateIn.Name = "textBoxDateIn";
            this.textBoxDateIn.ReadOnly = true;
            this.textBoxDateIn.Size = new System.Drawing.Size(202, 20);
            this.textBoxDateIn.TabIndex = 0;
            this.textBoxDateIn.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Заезд";
            // 
            // buttonPay
            // 
            this.buttonPay.Enabled = false;
            this.buttonPay.Location = new System.Drawing.Point(435, 176);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(202, 30);
            this.buttonPay.TabIndex = 8;
            this.buttonPay.Text = "Оплатить и Выехать";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(435, 28);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(202, 20);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.TabStop = false;
            this.textBoxID.Visible = false;
            // 
            // ViewAllButton
            // 
            this.ViewAllButton.Location = new System.Drawing.Point(342, 176);
            this.ViewAllButton.Name = "ViewAllButton";
            this.ViewAllButton.Size = new System.Drawing.Size(75, 30);
            this.ViewAllButton.TabIndex = 12;
            this.ViewAllButton.Text = "ViewAll";
            this.ViewAllButton.UseVisualStyleBackColor = true;
            this.ViewAllButton.Click += new System.EventHandler(this.ViewAllButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(734, 230);
            this.Controls.Add(this.ViewAllButton);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDateIn);
            this.Controls.Add(this.textBoxSumItog);
            this.Controls.Add(this.textBoxSumOut);
            this.Controls.Add(this.textBoxSumIn);
            this.Controls.Add(this.textBoxModelAuto);
            this.Controls.Add(this.textBoxBrandAuto);
            this.Controls.Add(this.textBoxGosNum);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxFio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Автостоянка ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGosNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBrandAuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxModelAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSumIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd;
        private ParkingDataSet parkingDataSet;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private ParkingDataSetTableAdapters.ParkingTableAdapter parkingTableAdapter;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxSumOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSumItog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDateIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button ViewAllButton;
    }
}