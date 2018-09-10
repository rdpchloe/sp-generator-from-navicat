namespace GenerateSPFromNavicatDDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tfInsert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tfResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateInsert = new System.Windows.Forms.Button();
            this.btnGenerateUpdate = new System.Windows.Forms.Button();
            this.dgTableData = new System.Windows.Forms.DataGridView();
            this.dataGridFieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridFieldType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridFieldLen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tfResultParameter = new System.Windows.Forms.TextBox();
            this.tfResultVariableCI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTableData)).BeginInit();
            this.SuspendLayout();
            // 
            // tfInsert
            // 
            this.tfInsert.Location = new System.Drawing.Point(12, 25);
            this.tfInsert.Multiline = true;
            this.tfInsert.Name = "tfInsert";
            this.tfInsert.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tfInsert.Size = new System.Drawing.Size(326, 214);
            this.tfInsert.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert table DDL here";
            // 
            // tfResult
            // 
            this.tfResult.Location = new System.Drawing.Point(461, 25);
            this.tfResult.Multiline = true;
            this.tfResult.Name = "tfResult";
            this.tfResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tfResult.Size = new System.Drawing.Size(343, 361);
            this.tfResult.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(768, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnGenerateInsert
            // 
            this.btnGenerateInsert.Location = new System.Drawing.Point(344, 162);
            this.btnGenerateInsert.Name = "btnGenerateInsert";
            this.btnGenerateInsert.Size = new System.Drawing.Size(112, 44);
            this.btnGenerateInsert.TabIndex = 4;
            this.btnGenerateInsert.Text = "Generate INSERT query";
            this.btnGenerateInsert.UseVisualStyleBackColor = true;
            this.btnGenerateInsert.Click += new System.EventHandler(this.btnGenerateInsert_Click);
            // 
            // btnGenerateUpdate
            // 
            this.btnGenerateUpdate.Location = new System.Drawing.Point(344, 212);
            this.btnGenerateUpdate.Name = "btnGenerateUpdate";
            this.btnGenerateUpdate.Size = new System.Drawing.Size(112, 42);
            this.btnGenerateUpdate.TabIndex = 5;
            this.btnGenerateUpdate.Text = "Generate UPDATE query";
            this.btnGenerateUpdate.UseVisualStyleBackColor = true;
            this.btnGenerateUpdate.Click += new System.EventHandler(this.btnGenerateUpdate_Click);
            // 
            // dgTableData
            // 
            this.dgTableData.AllowUserToAddRows = false;
            this.dgTableData.AllowUserToDeleteRows = false;
            this.dgTableData.AllowUserToResizeColumns = false;
            this.dgTableData.AllowUserToResizeRows = false;
            this.dgTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTableData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridFieldName,
            this.dataGridFieldType,
            this.dataGridFieldLen});
            this.dgTableData.Location = new System.Drawing.Point(12, 245);
            this.dgTableData.Name = "dgTableData";
            this.dgTableData.ReadOnly = true;
            this.dgTableData.Size = new System.Drawing.Size(326, 193);
            this.dgTableData.TabIndex = 6;
            this.dgTableData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTableData_CellContentClick);
            // 
            // dataGridFieldName
            // 
            this.dataGridFieldName.HeaderText = "Name";
            this.dataGridFieldName.Name = "dataGridFieldName";
            this.dataGridFieldName.ReadOnly = true;
            // 
            // dataGridFieldType
            // 
            this.dataGridFieldType.HeaderText = "Type";
            this.dataGridFieldType.Name = "dataGridFieldType";
            this.dataGridFieldType.ReadOnly = true;
            // 
            // dataGridFieldLen
            // 
            this.dataGridFieldLen.HeaderText = "Length";
            this.dataGridFieldLen.Name = "dataGridFieldLen";
            this.dataGridFieldLen.ReadOnly = true;
            // 
            // tfResultParameter
            // 
            this.tfResultParameter.Location = new System.Drawing.Point(461, 392);
            this.tfResultParameter.Name = "tfResultParameter";
            this.tfResultParameter.Size = new System.Drawing.Size(343, 20);
            this.tfResultParameter.TabIndex = 7;
            // 
            // tfResultVariableCI
            // 
            this.tfResultVariableCI.Location = new System.Drawing.Point(461, 418);
            this.tfResultVariableCI.Name = "tfResultVariableCI";
            this.tfResultVariableCI.Size = new System.Drawing.Size(343, 20);
            this.tfResultVariableCI.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.tfResultVariableCI);
            this.Controls.Add(this.tfResultParameter);
            this.Controls.Add(this.dgTableData);
            this.Controls.Add(this.btnGenerateUpdate);
            this.Controls.Add(this.btnGenerateInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tfResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tfInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generate SP From Navicat Table DDL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTableData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tfInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tfResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateInsert;
        private System.Windows.Forms.Button btnGenerateUpdate;
        private System.Windows.Forms.DataGridView dgTableData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridFieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridFieldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridFieldLen;
        private System.Windows.Forms.TextBox tfResultParameter;
        private System.Windows.Forms.TextBox tfResultVariableCI;
    }
}

