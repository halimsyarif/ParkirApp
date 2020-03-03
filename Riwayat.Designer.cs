namespace UAS_ParkirApp
{
    partial class Riwayat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rwyat = new System.Windows.Forms.Label();
            this.dataGridParkir = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridRiwayat = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParkir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // Rwyat
            // 
            this.Rwyat.AutoSize = true;
            this.Rwyat.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rwyat.ForeColor = System.Drawing.Color.White;
            this.Rwyat.Location = new System.Drawing.Point(242, 27);
            this.Rwyat.Name = "Rwyat";
            this.Rwyat.Size = new System.Drawing.Size(178, 30);
            this.Rwyat.TabIndex = 2;
            this.Rwyat.Text = "Masih Parkir";
            // 
            // dataGridParkir
            // 
            this.dataGridParkir.AllowUserToAddRows = false;
            this.dataGridParkir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParkir.Location = new System.Drawing.Point(49, 71);
            this.dataGridParkir.Name = "dataGridParkir";
            this.dataGridParkir.ReadOnly = true;
            this.dataGridParkir.RowHeadersWidth = 51;
            this.dataGridParkir.RowTemplate.Height = 24;
            this.dataGridParkir.Size = new System.Drawing.Size(544, 189);
            this.dataGridParkir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Riwayat Parkir";
            // 
            // dataGridRiwayat
            // 
            this.dataGridRiwayat.AllowUserToAddRows = false;
            this.dataGridRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRiwayat.Location = new System.Drawing.Point(49, 316);
            this.dataGridRiwayat.Name = "dataGridRiwayat";
            this.dataGridRiwayat.ReadOnly = true;
            this.dataGridRiwayat.RowHeadersWidth = 51;
            this.dataGridRiwayat.RowTemplate.Height = 24;
            this.dataGridRiwayat.Size = new System.Drawing.Size(544, 190);
            this.dataGridRiwayat.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(49, 27);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(132, 30);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "UpdateData";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Riwayat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridRiwayat);
            this.Controls.Add(this.dataGridParkir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rwyat);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Riwayat";
            this.Size = new System.Drawing.Size(619, 537);
            this.Load += new System.EventHandler(this.Riwayat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParkir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rwyat;
        private System.Windows.Forms.DataGridView dataGridParkir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridRiwayat;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
