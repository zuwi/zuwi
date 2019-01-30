namespace WidgetCreator
{
    partial class Hub
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
            this.zuwiDBSitesDataSet = new WidgetCreator.ZuwiDBSitesDataSet();
            this.sitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sitesTableAdapter = new WidgetCreator.ZuwiDBSitesDataSetTableAdapters.SitesTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.zuwiDBWidgetsDataSet = new WidgetCreator.ZuwiDBWidgetsDataSet();
            this.widgetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.widgetsTableAdapter = new WidgetCreator.ZuwiDBWidgetsDataSetTableAdapters.WidgetsTableAdapter();
            this.partialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zuwiDBSitesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zuwiDBWidgetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sitesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(243, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // zuwiDBSitesDataSet
            // 
            this.zuwiDBSitesDataSet.DataSetName = "ZuwiDBSitesDataSet";
            this.zuwiDBSitesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sitesBindingSource
            // 
            this.sitesBindingSource.DataMember = "Sites";
            this.sitesBindingSource.DataSource = this.zuwiDBSitesDataSet;
            // 
            // sitesTableAdapter
            // 
            this.sitesTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sites";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partialNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.widgetsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(424, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(243, 438);
            this.dataGridView2.TabIndex = 2;
            // 
            // zuwiDBWidgetsDataSet
            // 
            this.zuwiDBWidgetsDataSet.DataSetName = "ZuwiDBWidgetsDataSet";
            this.zuwiDBWidgetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // widgetsBindingSource
            // 
            this.widgetsBindingSource.DataMember = "Widgets";
            this.widgetsBindingSource.DataSource = this.zuwiDBWidgetsDataSet;
            // 
            // widgetsTableAdapter
            // 
            this.widgetsTableAdapter.ClearBeforeFill = true;
            // 
            // partialNameDataGridViewTextBoxColumn
            // 
            this.partialNameDataGridViewTextBoxColumn.DataPropertyName = "PartialName";
            this.partialNameDataGridViewTextBoxColumn.HeaderText = "PartialName";
            this.partialNameDataGridViewTextBoxColumn.Name = "partialNameDataGridViewTextBoxColumn";
            this.partialNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.partialNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Widget";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Site";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "Create Widget";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 686);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Hub";
            this.Text = "Hub";
            this.Load += new System.EventHandler(this.Hub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zuwiDBSitesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zuwiDBWidgetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ZuwiDBSitesDataSet zuwiDBSitesDataSet;
        private System.Windows.Forms.BindingSource sitesBindingSource;
        private ZuwiDBSitesDataSetTableAdapters.SitesTableAdapter sitesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ZuwiDBWidgetsDataSet zuwiDBWidgetsDataSet;
        private System.Windows.Forms.BindingSource widgetsBindingSource;
        private ZuwiDBWidgetsDataSetTableAdapters.WidgetsTableAdapter widgetsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}