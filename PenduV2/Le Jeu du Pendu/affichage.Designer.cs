namespace Le_Jeu_du_Pendu
{
    partial class affichage
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
            this.btn_quitterAffichage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_quitterAffichage
            // 
            this.btn_quitterAffichage.Location = new System.Drawing.Point(12, 12);
            this.btn_quitterAffichage.Name = "btn_quitterAffichage";
            this.btn_quitterAffichage.Size = new System.Drawing.Size(75, 23);
            this.btn_quitterAffichage.TabIndex = 0;
            this.btn_quitterAffichage.Text = "QUIT";
            this.btn_quitterAffichage.UseVisualStyleBackColor = true;
            this.btn_quitterAffichage.Click += new System.EventHandler(this.btn_quitterAffichage_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 311);
            this.dataGridView1.TabIndex = 1;
            // 
            // affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 407);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_quitterAffichage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "affichage";
            this.Text = "affichage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quitterAffichage;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}