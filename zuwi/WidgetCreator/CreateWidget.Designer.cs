namespace WidgetCreator
{
    partial class CreateWidget
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateWidgetBtn = new System.Windows.Forms.Button();
            this.Keys = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartialName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Keys)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateWidget
            // 
            this.CreateWidgetBtn.Location = new System.Drawing.Point(79, 327);
            this.CreateWidgetBtn.Name = "CreateWidget";
            this.CreateWidgetBtn.Size = new System.Drawing.Size(240, 46);
            this.CreateWidgetBtn.TabIndex = 0;
            this.CreateWidgetBtn.Text = "Create Widget";
            this.CreateWidgetBtn.UseVisualStyleBackColor = true;
            this.CreateWidgetBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Keys
            // 
            this.Keys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Keys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key});
            this.Keys.Location = new System.Drawing.Point(79, 163);
            this.Keys.Name = "Keys";
            this.Keys.RowTemplate.Height = 28;
            this.Keys.Size = new System.Drawing.Size(240, 150);
            this.Keys.TabIndex = 1;
            // 
            // Key
            // 
            this.Key.HeaderText = "key";
            this.Key.Name = "Key";
            // 
            // PartialName
            // 
            this.PartialName.Location = new System.Drawing.Point(79, 89);
            this.PartialName.Name = "PartialName";
            this.PartialName.Size = new System.Drawing.Size(240, 26);
            this.PartialName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "PartialName / Widgetname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Required Keys";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartialName);
            this.Controls.Add(this.Keys);
            this.Controls.Add(this.CreateWidgetBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Keys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateWidgetBtn;
        private System.Windows.Forms.DataGridView Keys;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PartialName;
    }
}

