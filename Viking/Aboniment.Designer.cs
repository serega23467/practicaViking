namespace Viking
{
    partial class Aboniment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aboniment));
            this.panelAboniment = new System.Windows.Forms.Panel();
            this.labelAboniment = new System.Windows.Forms.Label();
            this.comboBoxAbonimentExtend = new System.Windows.Forms.ComboBox();
            this.buttonAboniment = new System.Windows.Forms.Button();
            this.panelAboniment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAboniment
            // 
            this.panelAboniment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.panelAboniment.Controls.Add(this.labelAboniment);
            this.panelAboniment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAboniment.Location = new System.Drawing.Point(0, 0);
            this.panelAboniment.Name = "panelAboniment";
            this.panelAboniment.Size = new System.Drawing.Size(251, 77);
            this.panelAboniment.TabIndex = 0;
            // 
            // labelAboniment
            // 
            this.labelAboniment.AutoSize = true;
            this.labelAboniment.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboniment.Location = new System.Drawing.Point(12, 21);
            this.labelAboniment.Name = "labelAboniment";
            this.labelAboniment.Size = new System.Drawing.Size(232, 33);
            this.labelAboniment.TabIndex = 0;
            this.labelAboniment.Text = "Выберите срок";
            // 
            // comboBoxAbonimentExtend
            // 
            this.comboBoxAbonimentExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAbonimentExtend.FormattingEnabled = true;
            this.comboBoxAbonimentExtend.Items.AddRange(new object[] {
            "30",
            "90",
            "365"});
            this.comboBoxAbonimentExtend.Location = new System.Drawing.Point(33, 93);
            this.comboBoxAbonimentExtend.Name = "comboBoxAbonimentExtend";
            this.comboBoxAbonimentExtend.Size = new System.Drawing.Size(166, 45);
            this.comboBoxAbonimentExtend.TabIndex = 1;
            // 
            // buttonAboniment
            // 
            this.buttonAboniment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAboniment.Location = new System.Drawing.Point(33, 158);
            this.buttonAboniment.Name = "buttonAboniment";
            this.buttonAboniment.Size = new System.Drawing.Size(166, 34);
            this.buttonAboniment.TabIndex = 2;
            this.buttonAboniment.Text = "Выбрать";
            this.buttonAboniment.UseVisualStyleBackColor = true;
            this.buttonAboniment.Click += new System.EventHandler(this.buttonAboniment_Click);
            // 
            // Aboniment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(251, 208);
            this.Controls.Add(this.buttonAboniment);
            this.Controls.Add(this.comboBoxAbonimentExtend);
            this.Controls.Add(this.panelAboniment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(267, 247);
            this.MinimumSize = new System.Drawing.Size(267, 247);
            this.Name = "Aboniment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Абонимент";
            this.panelAboniment.ResumeLayout(false);
            this.panelAboniment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAboniment;
        private System.Windows.Forms.Label labelAboniment;
        private System.Windows.Forms.ComboBox comboBoxAbonimentExtend;
        private System.Windows.Forms.Button buttonAboniment;
    }
}