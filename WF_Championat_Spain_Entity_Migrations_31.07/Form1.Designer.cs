namespace WF_Championat_Spain_Entity_Migrations_31._07
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.listBoxTeams = new System.Windows.Forms.ListBox();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.listBoxGoals = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.Location = new System.Drawing.Point(261, 2);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(295, 225);
            this.listBoxPlayers.TabIndex = 0;
            // 
            // listBoxTeams
            // 
            this.listBoxTeams.FormattingEnabled = true;
            this.listBoxTeams.Location = new System.Drawing.Point(562, 2);
            this.listBoxTeams.Name = "listBoxTeams";
            this.listBoxTeams.Size = new System.Drawing.Size(226, 225);
            this.listBoxTeams.TabIndex = 1;
            this.listBoxTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxTeams_SelectedIndexChanged);
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.Location = new System.Drawing.Point(12, 2);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(243, 121);
            this.listBoxMatches.TabIndex = 2;
            this.listBoxMatches.SelectedIndexChanged += new System.EventHandler(this.listBoxMatches_SelectedIndexChanged);
            this.listBoxMatches.DoubleClick += new System.EventHandler(this.listBoxMatches_DoubleClick);
            // 
            // listBoxGoals
            // 
            this.listBoxGoals.FormattingEnabled = true;
            this.listBoxGoals.Location = new System.Drawing.Point(13, 130);
            this.listBoxGoals.Name = "listBoxGoals";
            this.listBoxGoals.Size = new System.Drawing.Size(242, 95);
            this.listBoxGoals.TabIndex = 3;
            this.listBoxGoals.SelectedIndexChanged += new System.EventHandler(this.listBoxGoals_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxGoals);
            this.Controls.Add(this.listBoxMatches);
            this.Controls.Add(this.listBoxTeams);
            this.Controls.Add(this.listBoxPlayers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.ListBox listBoxTeams;
        private System.Windows.Forms.ListBox listBoxMatches;
        private System.Windows.Forms.ListBox listBoxGoals;
    }
}

