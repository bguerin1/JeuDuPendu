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
            this.dgv_Mots = new System.Windows.Forms.DataGridView();
            this.comboBox_Difficult = new System.Windows.Forms.ComboBox();
            this.lbl_Difficult = new System.Windows.Forms.Label();
            this.lbl_Mot = new System.Windows.Forms.Label();
            this.txt_Mot = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mots)).BeginInit();
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
            // dgv_Mots
            // 
            this.dgv_Mots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mots.Location = new System.Drawing.Point(124, 88);
            this.dgv_Mots.Name = "dgv_Mots";
            this.dgv_Mots.Size = new System.Drawing.Size(396, 282);
            this.dgv_Mots.TabIndex = 1;
            // 
            // comboBox_Difficult
            // 
            this.comboBox_Difficult.FormattingEnabled = true;
            this.comboBox_Difficult.Location = new System.Drawing.Point(292, 54);
            this.comboBox_Difficult.Name = "comboBox_Difficult";
            this.comboBox_Difficult.Size = new System.Drawing.Size(228, 21);
            this.comboBox_Difficult.TabIndex = 2;
            this.comboBox_Difficult.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Difficult_SelectionChangeCommitted);
            // 
            // lbl_Difficult
            // 
            this.lbl_Difficult.AutoSize = true;
            this.lbl_Difficult.Location = new System.Drawing.Point(121, 57);
            this.lbl_Difficult.Name = "lbl_Difficult";
            this.lbl_Difficult.Size = new System.Drawing.Size(132, 13);
            this.lbl_Difficult.TabIndex = 3;
            this.lbl_Difficult.Text = "Rechercher une difficulté :";
            // 
            // lbl_Mot
            // 
            this.lbl_Mot.AutoSize = true;
            this.lbl_Mot.Location = new System.Drawing.Point(121, 25);
            this.lbl_Mot.Name = "lbl_Mot";
            this.lbl_Mot.Size = new System.Drawing.Size(104, 13);
            this.lbl_Mot.TabIndex = 4;
            this.lbl_Mot.Text = "Rechercher un mot :";
            // 
            // txt_Mot
            // 
            this.txt_Mot.Location = new System.Drawing.Point(292, 22);
            this.txt_Mot.Name = "txt_Mot";
            this.txt_Mot.Size = new System.Drawing.Size(228, 20);
            this.txt_Mot.TabIndex = 5;
            this.txt_Mot.TextChanged += new System.EventHandler(this.txt_Mot_TextChanged);
            // 
            // affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 407);
            this.Controls.Add(this.txt_Mot);
            this.Controls.Add(this.lbl_Mot);
            this.Controls.Add(this.lbl_Difficult);
            this.Controls.Add(this.comboBox_Difficult);
            this.Controls.Add(this.dgv_Mots);
            this.Controls.Add(this.btn_quitterAffichage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "affichage";
            this.Text = "affichage";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quitterAffichage;
        private System.Windows.Forms.DataGridView dgv_Mots;
        private System.Windows.Forms.ComboBox comboBox_Difficult;
        private System.Windows.Forms.Label lbl_Difficult;
        private System.Windows.Forms.Label lbl_Mot;
        private System.Windows.Forms.TextBox txt_Mot;
    }
}