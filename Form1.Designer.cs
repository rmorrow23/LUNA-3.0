namespace Moonbase
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.GRBXLocationInfo = new System.Windows.Forms.GroupBox();
            this.LBLRoomDesc = new System.Windows.Forms.Label();
            this.TBRoomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personalNav = new System.Windows.Forms.GroupBox();
            this.LobbyBTN = new System.Windows.Forms.Button();
            this.medBayBTN = new System.Windows.Forms.Button();
            this.commandCenterBTN = new System.Windows.Forms.Button();
            this.livingQtBTN = new System.Windows.Forms.Button();
            this.labBTN = new System.Windows.Forms.Button();
            this.TXBXRoomDesc = new System.Windows.Forms.TextBox();
            this.GRBXLocationInfo.SuspendLayout();
            this.personalNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRBXLocationInfo
            // 
            this.GRBXLocationInfo.BackColor = System.Drawing.Color.Transparent;
            this.GRBXLocationInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GRBXLocationInfo.Controls.Add(this.label1);
            this.GRBXLocationInfo.Controls.Add(this.LBLRoomDesc);
            this.GRBXLocationInfo.Controls.Add(this.TXBXRoomDesc);
            this.GRBXLocationInfo.Controls.Add(this.TBRoomName);
            this.GRBXLocationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRBXLocationInfo.ForeColor = System.Drawing.Color.White;
            this.GRBXLocationInfo.Location = new System.Drawing.Point(11, 12);
            this.GRBXLocationInfo.Margin = new System.Windows.Forms.Padding(2);
            this.GRBXLocationInfo.Name = "GRBXLocationInfo";
            this.GRBXLocationInfo.Padding = new System.Windows.Forms.Padding(2);
            this.GRBXLocationInfo.Size = new System.Drawing.Size(332, 431);
            this.GRBXLocationInfo.TabIndex = 0;
            this.GRBXLocationInfo.TabStop = false;
            this.GRBXLocationInfo.Text = "Location Information";
            // 
            // LBLRoomDesc
            // 
            this.LBLRoomDesc.AutoSize = true;
            this.LBLRoomDesc.BackColor = System.Drawing.Color.Silver;
            this.LBLRoomDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRoomDesc.ForeColor = System.Drawing.Color.Black;
            this.LBLRoomDesc.Location = new System.Drawing.Point(12, 152);
            this.LBLRoomDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLRoomDesc.Name = "LBLRoomDesc";
            this.LBLRoomDesc.Size = new System.Drawing.Size(206, 29);
            this.LBLRoomDesc.TabIndex = 2;
            this.LBLRoomDesc.Text = "Room Description";
            this.LBLRoomDesc.Click += new System.EventHandler(this.label2_Click);
            // 
            // TBRoomName
            // 
            this.TBRoomName.BackColor = System.Drawing.Color.Silver;
            this.TBRoomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRoomName.Location = new System.Drawing.Point(12, 84);
            this.TBRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.TBRoomName.Name = "TBRoomName";
            this.TBRoomName.ReadOnly = true;
            this.TBRoomName.Size = new System.Drawing.Size(300, 19);
            this.TBRoomName.TabIndex = 1;
            this.TBRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBRoomName.TextChanged += new System.EventHandler(this.TBRoomName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Name";
            // 
            // personalNav
            // 
            this.personalNav.BackColor = System.Drawing.Color.Transparent;
            this.personalNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personalNav.Controls.Add(this.LobbyBTN);
            this.personalNav.Controls.Add(this.medBayBTN);
            this.personalNav.Controls.Add(this.commandCenterBTN);
            this.personalNav.Controls.Add(this.livingQtBTN);
            this.personalNav.Controls.Add(this.labBTN);
            this.personalNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalNav.ForeColor = System.Drawing.SystemColors.Info;
            this.personalNav.Location = new System.Drawing.Point(405, 12);
            this.personalNav.Name = "personalNav";
            this.personalNav.Size = new System.Drawing.Size(385, 197);
            this.personalNav.TabIndex = 1;
            this.personalNav.TabStop = false;
            this.personalNav.Text = "Personal Nav Device";
            // 
            // LobbyBTN
            // 
            this.LobbyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LobbyBTN.ForeColor = System.Drawing.Color.Black;
            this.LobbyBTN.Image = global::Moonbase.Properties.Resources.buttonBackground;
            this.LobbyBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LobbyBTN.Location = new System.Drawing.Point(134, 79);
            this.LobbyBTN.Name = "LobbyBTN";
            this.LobbyBTN.Size = new System.Drawing.Size(99, 63);
            this.LobbyBTN.TabIndex = 4;
            this.LobbyBTN.Text = "Lobby";
            this.LobbyBTN.UseVisualStyleBackColor = true;
            this.LobbyBTN.Click += new System.EventHandler(this.LobbyBTN_Click);
            // 
            // medBayBTN
            // 
            this.medBayBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.medBayBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medBayBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.medBayBTN.Image = global::Moonbase.Properties.Resources.buttonBackground;
            this.medBayBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.medBayBTN.Location = new System.Drawing.Point(120, 148);
            this.medBayBTN.Name = "medBayBTN";
            this.medBayBTN.Size = new System.Drawing.Size(129, 40);
            this.medBayBTN.TabIndex = 3;
            this.medBayBTN.Text = "Medbay";
            this.medBayBTN.UseVisualStyleBackColor = true;
            this.medBayBTN.Click += new System.EventHandler(this.medBayBTN_Click);
            // 
            // commandCenterBTN
            // 
            this.commandCenterBTN.BackColor = System.Drawing.Color.Transparent;
            this.commandCenterBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.commandCenterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandCenterBTN.ForeColor = System.Drawing.Color.Black;
            this.commandCenterBTN.Image = global::Moonbase.Properties.Resources.buttonBackground;
            this.commandCenterBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.commandCenterBTN.Location = new System.Drawing.Point(120, 30);
            this.commandCenterBTN.Name = "commandCenterBTN";
            this.commandCenterBTN.Size = new System.Drawing.Size(129, 38);
            this.commandCenterBTN.TabIndex = 0;
            this.commandCenterBTN.Text = "Command";
            this.commandCenterBTN.UseVisualStyleBackColor = false;
            this.commandCenterBTN.Click += new System.EventHandler(this.commandCenterBTN_Click);
            // 
            // livingQtBTN
            // 
            this.livingQtBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.livingQtBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livingQtBTN.ForeColor = System.Drawing.Color.Black;
            this.livingQtBTN.Image = global::Moonbase.Properties.Resources.buttonBackground;
            this.livingQtBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.livingQtBTN.Location = new System.Drawing.Point(239, 89);
            this.livingQtBTN.Name = "livingQtBTN";
            this.livingQtBTN.Size = new System.Drawing.Size(103, 42);
            this.livingQtBTN.TabIndex = 2;
            this.livingQtBTN.Text = "Living";
            this.livingQtBTN.UseVisualStyleBackColor = true;
            this.livingQtBTN.Click += new System.EventHandler(this.livingQtBTN_Click);
            // 
            // labBTN
            // 
            this.labBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.labBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.labBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBTN.ForeColor = System.Drawing.Color.Black;
            this.labBTN.Image = global::Moonbase.Properties.Resources.buttonBackground;
            this.labBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labBTN.Location = new System.Drawing.Point(33, 89);
            this.labBTN.Name = "labBTN";
            this.labBTN.Size = new System.Drawing.Size(95, 42);
            this.labBTN.TabIndex = 1;
            this.labBTN.Text = "Lab";
            this.labBTN.UseVisualStyleBackColor = true;
            this.labBTN.Click += new System.EventHandler(this.labBTN_Click);
            // 
            // TXBXRoomDesc
            // 
            this.TXBXRoomDesc.BackColor = System.Drawing.Color.Silver;
            this.TXBXRoomDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBXRoomDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBXRoomDesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TXBXRoomDesc.Location = new System.Drawing.Point(12, 177);
            this.TXBXRoomDesc.Margin = new System.Windows.Forms.Padding(2);
            this.TXBXRoomDesc.Multiline = true;
            this.TXBXRoomDesc.Name = "TXBXRoomDesc";
            this.TXBXRoomDesc.ReadOnly = true;
            this.TXBXRoomDesc.Size = new System.Drawing.Size(306, 241);
            this.TXBXRoomDesc.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::Moonbase.Properties.Resources.lobby;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 458);
            this.Controls.Add(this.personalNav);
            this.Controls.Add(this.GRBXLocationInfo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LUNA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GRBXLocationInfo.ResumeLayout(false);
            this.GRBXLocationInfo.PerformLayout();
            this.personalNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRBXLocationInfo;
        private System.Windows.Forms.TextBox TBRoomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLRoomDesc;
        private System.Windows.Forms.GroupBox personalNav;
        private System.Windows.Forms.Button medBayBTN;
        private System.Windows.Forms.Button livingQtBTN;
        private System.Windows.Forms.Button labBTN;
        private System.Windows.Forms.Button commandCenterBTN;
        private System.Windows.Forms.Button LobbyBTN;
        private System.Windows.Forms.TextBox TXBXRoomDesc;
    }
}

