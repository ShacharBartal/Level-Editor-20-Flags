namespace Level_Editor
{
    partial class Form1
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
            this.NewShape = new System.Windows.Forms.DataGridView();
            this.AddRows = new System.Windows.Forms.Button();
            this.AddColumn = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NewShape)).BeginInit();
            this.SuspendLayout();
            // 
            // NewShape
            // 
            this.NewShape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewShape.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hide});
            this.NewShape.Location = new System.Drawing.Point(194, 12);
            this.NewShape.Name = "NewShape";
            this.NewShape.DefaultCellStyle.NullValue = "1"; // set null value as 1
            this.NewShape.Size = new System.Drawing.Size(540, 349);
            this.NewShape.TabIndex = 0;
            this.NewShape.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // AddRows
            // 
            this.AddRows.Location = new System.Drawing.Point(46, 33);
            this.AddRows.Name = "AddRows";
            this.AddRows.Size = new System.Drawing.Size(112, 32);
            this.AddRows.TabIndex = 1;
            this.AddRows.Text = "Add Rows";
            this.AddRows.UseVisualStyleBackColor = true;
            this.AddRows.Click += new System.EventHandler(this.AddRows_Click);
            // 
            // AddColumn
            // 
            this.AddColumn.Location = new System.Drawing.Point(46, 71);
            this.AddColumn.Name = "AddColumn";
            this.AddColumn.Size = new System.Drawing.Size(112, 28);
            this.AddColumn.TabIndex = 3;
            this.AddColumn.Text = "Add Column";
            this.AddColumn.UseVisualStyleBackColor = true;
            this.AddColumn.Click += new System.EventHandler(this.AddColumn_Click_1);
            // 
            // Hide
            // 
            this.Hide.HeaderText = "";
            this.Hide.Name = "Hide";
            this.Hide.Text = "0";
            this.Hide.Width = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddColumn);
            this.Controls.Add(this.AddRows);
            this.Controls.Add(this.NewShape);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NewShape)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NewShape;
        private System.Windows.Forms.Button AddRows;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Hide;
    }
}

