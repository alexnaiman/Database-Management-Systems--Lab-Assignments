namespace Lab1
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
            this.dataGridViewParty = new System.Windows.Forms.DataGridView();
            this.dataGridViewCharacterSheet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharacterSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewParty
            // 
            this.dataGridViewParty.AllowUserToAddRows = false;
            this.dataGridViewParty.AllowUserToDeleteRows = false;
            this.dataGridViewParty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParty.Location = new System.Drawing.Point(12, 29);
            this.dataGridViewParty.Name = "dataGridViewParty";
            this.dataGridViewParty.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridViewParty.RowTemplate.Height = 24;
            this.dataGridViewParty.Size = new System.Drawing.Size(356, 362);
            this.dataGridViewParty.TabIndex = 0;
            // 
            // dataGridViewCharacterSheet
            // 
            this.dataGridViewCharacterSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCharacterSheet.Location = new System.Drawing.Point(374, 29);
            this.dataGridViewCharacterSheet.Name = "dataGridViewCharacterSheet";
            this.dataGridViewCharacterSheet.RowTemplate.Height = 24;
            this.dataGridViewCharacterSheet.Size = new System.Drawing.Size(553, 362);
            this.dataGridViewCharacterSheet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Party Table - Parent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Character Sheet - Child";
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(53, 397);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(133, 41);
            this.viewAllButton.TabIndex = 4;
            this.viewAllButton.Text = "View All";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.Click += new System.EventHandler(this.viewAllButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(523, 397);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(243, 40);
            this.saveChangesButton.TabIndex = 5;
            this.saveChangesButton.Text = "Save All Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCharacterSheet);
            this.Controls.Add(this.dataGridViewParty);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharacterSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewParty;
        private System.Windows.Forms.DataGridView dataGridViewCharacterSheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewAllButton;
        private System.Windows.Forms.Button saveChangesButton;
    }
}

