namespace WindowsFormsApp
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnToEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvEmployeeTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 384);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 30);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnToEdit
            // 
            this.btnToEdit.Location = new System.Drawing.Point(602, 384);
            this.btnToEdit.Name = "btnToEdit";
            this.btnToEdit.Size = new System.Drawing.Size(90, 30);
            this.btnToEdit.TabIndex = 1;
            this.btnToEdit.Text = "Editar";
            this.btnToEdit.UseVisualStyleBackColor = true;
            this.btnToEdit.Click += new System.EventHandler(this.btnToEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(698, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvEmployeeTable
            // 
            this.dgvEmployeeTable.AllowUserToAddRows = false;
            this.dgvEmployeeTable.AllowUserToDeleteRows = false;
            this.dgvEmployeeTable.AllowUserToResizeRows = false;
            this.dgvEmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeTable.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployeeTable.Name = "dgvEmployeeTable";
            this.dgvEmployeeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeTable.Size = new System.Drawing.Size(776, 366);
            this.dgvEmployeeTable.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmployeeTable);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnToEdit);
            this.Controls.Add(this.btnNew);
            this.Name = "Form1";
            this.Text = "Tela Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeTable)).EndInit();
            this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Button btnNew;
    private System.Windows.Forms.Button btnToEdit;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.DataGridView dgvEmployeeTable;
  }
}

