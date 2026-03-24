namespace Task3
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
            this.clbMelodies = new System.Windows.Forms.CheckedListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbSelectedItems = new System.Windows.Forms.ListBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbMelodies
            // 
            this.clbMelodies.CheckOnClick = true;
            this.clbMelodies.FormattingEnabled = true;
            this.clbMelodies.Items.AddRange(new object[] {
            "Ludwig van Beethoven - Moonlight Sonata,",
            "Wolfgang Amadeus Mozart - Symphony No. 40",
            "The Beatles - Yesterday",
            "Queen - Bohemian Rhapsody",
            "Antonio Vivaldi - Four Seasons (Spring)",
            "Frédéric Chopin - Nocturne Op. 9 No. 2",
            "Johann Sebastian Bach - Air on the G String",
            "Led Zeppelin - Stairway to Heaven",
            "Louis Armstrong - What a Wonderful World",
            "Claude Debussy - Clair de Lune"});
            this.clbMelodies.Location = new System.Drawing.Point(42, 61);
            this.clbMelodies.Name = "clbMelodies";
            this.clbMelodies.Size = new System.Drawing.Size(263, 154);
            this.clbMelodies.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(653, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 35);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистити все";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(653, 61);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 35);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Видалити вибране";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbSelectedItems
            // 
            this.lbSelectedItems.FormattingEnabled = true;
            this.lbSelectedItems.Location = new System.Drawing.Point(311, 61);
            this.lbSelectedItems.Name = "lbSelectedItems";
            this.lbSelectedItems.Size = new System.Drawing.Size(308, 199);
            this.lbSelectedItems.TabIndex = 12;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(308, 32);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(126, 13);
            this.lblSelected.TabIndex = 11;
            this.lblSelected.Text = "Ваш список вибраного:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(42, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 41);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Додати до списку";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оберіть музичний твір:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clbMelodies);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbSelectedItems);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbMelodies;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbSelectedItems;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}

