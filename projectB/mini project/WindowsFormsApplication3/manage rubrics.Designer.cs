namespace WindowsFormsApplication3
{
    partial class manage_rubrics
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new WindowsFormsApplication3.ProjectBDataSet();
            this.txtdetailrubric = new System.Windows.Forms.RichTextBox();
            this.btn_addrubric = new System.Windows.Forms.Button();
            this.btn_updaterubric = new System.Windows.Forms.Button();
            this.btn_deleterubric = new System.Windows.Forms.Button();
            this.txtcloid = new System.Windows.Forms.TextBox();
            this.rubricTableAdapter = new WindowsFormsApplication3.ProjectBDataSetTableAdapters.RubricTableAdapter();
            this.btn_view = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLO Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "detail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.cloIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rubricBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 358);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 119);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CloId";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtdetailrubric
            // 
            this.txtdetailrubric.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtdetailrubric.Location = new System.Drawing.Point(310, 161);
            this.txtdetailrubric.Margin = new System.Windows.Forms.Padding(4);
            this.txtdetailrubric.Name = "txtdetailrubric";
            this.txtdetailrubric.Size = new System.Drawing.Size(364, 107);
            this.txtdetailrubric.TabIndex = 5;
            this.txtdetailrubric.Text = "";
            this.txtdetailrubric.TextChanged += new System.EventHandler(this.txtdetailrubric_TextChanged);
            // 
            // btn_addrubric
            // 
            this.btn_addrubric.Location = new System.Drawing.Point(33, 300);
            this.btn_addrubric.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addrubric.Name = "btn_addrubric";
            this.btn_addrubric.Size = new System.Drawing.Size(112, 28);
            this.btn_addrubric.TabIndex = 7;
            this.btn_addrubric.Text = "Add";
            this.btn_addrubric.UseVisualStyleBackColor = true;
            this.btn_addrubric.Click += new System.EventHandler(this.btn_addrubric_Click);
            // 
            // btn_updaterubric
            // 
            this.btn_updaterubric.Location = new System.Drawing.Point(483, 300);
            this.btn_updaterubric.Margin = new System.Windows.Forms.Padding(4);
            this.btn_updaterubric.Name = "btn_updaterubric";
            this.btn_updaterubric.Size = new System.Drawing.Size(112, 28);
            this.btn_updaterubric.TabIndex = 8;
            this.btn_updaterubric.Text = "update";
            this.btn_updaterubric.UseVisualStyleBackColor = true;
            this.btn_updaterubric.Click += new System.EventHandler(this.btn_updaterubric_Click);
            // 
            // btn_deleterubric
            // 
            this.btn_deleterubric.Location = new System.Drawing.Point(258, 300);
            this.btn_deleterubric.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleterubric.Name = "btn_deleterubric";
            this.btn_deleterubric.Size = new System.Drawing.Size(112, 28);
            this.btn_deleterubric.TabIndex = 9;
            this.btn_deleterubric.Text = "delete";
            this.btn_deleterubric.UseVisualStyleBackColor = true;
            this.btn_deleterubric.Click += new System.EventHandler(this.btn_deleterubric_Click);
            // 
            // txtcloid
            // 
            this.txtcloid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtcloid.Location = new System.Drawing.Point(310, 51);
            this.txtcloid.Margin = new System.Windows.Forms.Padding(4);
            this.txtcloid.Name = "txtcloid";
            this.txtcloid.Size = new System.Drawing.Size(148, 27);
            this.txtcloid.TabIndex = 10;
            this.txtcloid.TextChanged += new System.EventHandler(this.txtcloid_TextChanged);
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(698, 300);
            this.btn_view.Margin = new System.Windows.Forms.Padding(4);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(103, 28);
            this.btn_view.TabIndex = 11;
            this.btn_view.Text = "view";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // manage_rubrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(864, 490);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.txtcloid);
            this.Controls.Add(this.btn_deleterubric);
            this.Controls.Add(this.btn_updaterubric);
            this.Controls.Add(this.btn_addrubric);
            this.Controls.Add(this.txtdetailrubric);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "manage_rubrics";
            this.Text = "manage_rubrics";
            this.Load += new System.EventHandler(this.manage_rubrics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox txtdetailrubric;
        private System.Windows.Forms.Button btn_addrubric;
        private System.Windows.Forms.Button btn_updaterubric;
        private System.Windows.Forms.Button btn_deleterubric;
        private System.Windows.Forms.TextBox txtcloid;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSetTableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_view;
    }
}