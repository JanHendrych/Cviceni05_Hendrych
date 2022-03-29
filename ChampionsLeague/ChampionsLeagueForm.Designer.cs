namespace ChampionsLeague
{
    partial class ChampionsLeagueForm
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
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnModifyPlayer = new System.Windows.Forms.Button();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnBestClubs = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(566, 12);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(169, 32);
            this.btnAddPlayer.TabIndex = 1;
            this.btnAddPlayer.Text = "Přidat hráče";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnModifyPlayer
            // 
            this.btnModifyPlayer.Location = new System.Drawing.Point(566, 50);
            this.btnModifyPlayer.Name = "btnModifyPlayer";
            this.btnModifyPlayer.Size = new System.Drawing.Size(169, 32);
            this.btnModifyPlayer.TabIndex = 1;
            this.btnModifyPlayer.Text = "Upravit hráče";
            this.btnModifyPlayer.UseVisualStyleBackColor = true;
            this.btnModifyPlayer.Click += new System.EventHandler(this.btnModifyPlayer_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(566, 88);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(169, 32);
            this.btnRemovePlayer.TabIndex = 1;
            this.btnRemovePlayer.Text = "Smazat hráče";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnBestClubs
            // 
            this.btnBestClubs.Location = new System.Drawing.Point(566, 183);
            this.btnBestClubs.Name = "btnBestClubs";
            this.btnBestClubs.Size = new System.Drawing.Size(169, 32);
            this.btnBestClubs.TabIndex = 1;
            this.btnBestClubs.Text = "Nejlepší kluby";
            this.btnBestClubs.UseVisualStyleBackColor = true;
            this.btnBestClubs.Click += new System.EventHandler(this.btnBestClubs_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 15;
            this.listBoxEvents.Location = new System.Drawing.Point(12, 308);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(723, 124);
            this.listBoxEvents.TabIndex = 2;
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowTemplate.Height = 25;
            this.dataGridViewPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(548, 290);
            this.dataGridViewPlayers.TabIndex = 3;
            this.dataGridViewPlayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlayers_CellClick);
            // 
            // ChampionsLeagueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.btnBestClubs);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.btnModifyPlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Name = "ChampionsLeagueForm";
            this.Text = "ChampionsLeagueForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAddPlayer;
        private Button btnModifyPlayer;
        private Button btnRemovePlayer;
        private Button btnBestClubs;
        private ListBox listBoxEvents;
        private DataGridView dataGridViewPlayers;
    }
}