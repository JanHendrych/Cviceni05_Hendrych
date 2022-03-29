namespace ChampionsLeague
{
    partial class AddPlayerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxGoals = new System.Windows.Forms.TextBox();
            this.cmBxClub = new System.Windows.Forms.ComboBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnStorno = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Klub:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Počet gólů:";
            // 
            // txtBoxGoals
            // 
            this.txtBoxGoals.Location = new System.Drawing.Point(89, 117);
            this.txtBoxGoals.Name = "txtBoxGoals";
            this.txtBoxGoals.Size = new System.Drawing.Size(193, 23);
            this.txtBoxGoals.TabIndex = 1;
            // 
            // cmBxClub
            // 
            this.cmBxClub.FormattingEnabled = true;
            this.cmBxClub.Location = new System.Drawing.Point(89, 71);
            this.cmBxClub.Name = "cmBxClub";
            this.cmBxClub.Size = new System.Drawing.Size(193, 23);
            this.cmBxClub.TabIndex = 2;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(89, 25);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(193, 23);
            this.txtBoxName.TabIndex = 3;
            // 
            // btnStorno
            // 
            this.btnStorno.Location = new System.Drawing.Point(8, 168);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(75, 35);
            this.btnStorno.TabIndex = 4;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(216, 168);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 35);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 215);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.cmBxClub);
            this.Controls.Add(this.txtBoxGoals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPlayerForm";
            this.Text = "Přidat/Upravit hráče";
            this.Load += new System.EventHandler(this.AddPlayerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxGoals;
        private ComboBox cmBxClub;
        private TextBox txtBoxName;
        private Button btnStorno;
        private Button btnOk;
    }
}