
namespace Praktikum_W12_S2
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBackAll = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNextAll = new System.Windows.Forms.Button();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblTeamNumber = new System.Windows.Forms.Label();
            this.tBoxPlayerID = new System.Windows.Forms.TextBox();
            this.tBoxPlayerName = new System.Windows.Forms.TextBox();
            this.dTimeBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cBoxTeam = new System.Windows.Forms.ComboBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.dUpDownTeamNumber = new System.Windows.Forms.DomainUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cBoxNationality = new System.Windows.Forms.ComboBox();
            this.lblIDLama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(244, 56);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 36);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBackAll
            // 
            this.btnBackAll.Location = new System.Drawing.Point(163, 56);
            this.btnBackAll.Name = "btnBackAll";
            this.btnBackAll.Size = new System.Drawing.Size(75, 36);
            this.btnBackAll.TabIndex = 1;
            this.btnBackAll.Text = "<<";
            this.btnBackAll.UseVisualStyleBackColor = true;
            this.btnBackAll.Click += new System.EventHandler(this.btnBackAll_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(325, 56);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 36);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNextAll
            // 
            this.btnNextAll.Location = new System.Drawing.Point(406, 56);
            this.btnNextAll.Name = "btnNextAll";
            this.btnNextAll.Size = new System.Drawing.Size(75, 36);
            this.btnNextAll.TabIndex = 3;
            this.btnNextAll.Text = ">>";
            this.btnNextAll.UseVisualStyleBackColor = true;
            this.btnNextAll.Click += new System.EventHandler(this.btnNextAll_Click);
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.Location = new System.Drawing.Point(160, 124);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(65, 17);
            this.lblPlayerID.TabIndex = 4;
            this.lblPlayerID.Text = "Player ID";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(160, 162);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(89, 17);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Player Name";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(160, 203);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(67, 17);
            this.lblBirthdate.TabIndex = 6;
            this.lblBirthdate.Text = "BirthDate";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(160, 240);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(74, 17);
            this.lblNationality.TabIndex = 7;
            this.lblNationality.Text = "Nationality";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(160, 279);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(44, 17);
            this.lblTeam.TabIndex = 8;
            this.lblTeam.Text = "Team";
            // 
            // lblTeamNumber
            // 
            this.lblTeamNumber.AutoSize = true;
            this.lblTeamNumber.Location = new System.Drawing.Point(160, 318);
            this.lblTeamNumber.Name = "lblTeamNumber";
            this.lblTeamNumber.Size = new System.Drawing.Size(98, 17);
            this.lblTeamNumber.TabIndex = 9;
            this.lblTeamNumber.Text = "Team Number";
            // 
            // tBoxPlayerID
            // 
            this.tBoxPlayerID.Location = new System.Drawing.Point(300, 121);
            this.tBoxPlayerID.Name = "tBoxPlayerID";
            this.tBoxPlayerID.Size = new System.Drawing.Size(100, 22);
            this.tBoxPlayerID.TabIndex = 10;
            // 
            // tBoxPlayerName
            // 
            this.tBoxPlayerName.Location = new System.Drawing.Point(300, 162);
            this.tBoxPlayerName.Name = "tBoxPlayerName";
            this.tBoxPlayerName.Size = new System.Drawing.Size(181, 22);
            this.tBoxPlayerName.TabIndex = 11;
            // 
            // dTimeBirthdate
            // 
            this.dTimeBirthdate.Location = new System.Drawing.Point(300, 203);
            this.dTimeBirthdate.Name = "dTimeBirthdate";
            this.dTimeBirthdate.Size = new System.Drawing.Size(200, 22);
            this.dTimeBirthdate.TabIndex = 12;
            // 
            // cBoxTeam
            // 
            this.cBoxTeam.FormattingEnabled = true;
            this.cBoxTeam.Items.AddRange(new object[] {
            "Arsenal",
            "Aston Villa",
            "Bournemouth",
            "Chelsea",
            "Crystal Palace",
            "Everton",
            "Leicester City",
            "Liverpool",
            "Manchester City",
            "Manchester United",
            "Newcastle United",
            "Norwich City",
            "Southampton",
            "Stoke City",
            "Sunderland",
            "Swansea City",
            "Tottenham Hotspur",
            "Watford",
            "West Bromwich Albion",
            "West Ham United"});
            this.cBoxTeam.Location = new System.Drawing.Point(300, 276);
            this.cBoxTeam.Name = "cBoxTeam";
            this.cBoxTeam.Size = new System.Drawing.Size(181, 24);
            this.cBoxTeam.TabIndex = 14;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(437, 318);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(0, 17);
            this.lblAvailability.TabIndex = 15;
            // 
            // dUpDownTeamNumber
            // 
            this.dUpDownTeamNumber.Items.Add("100");
            this.dUpDownTeamNumber.Items.Add("99");
            this.dUpDownTeamNumber.Items.Add("98");
            this.dUpDownTeamNumber.Items.Add("97");
            this.dUpDownTeamNumber.Items.Add("96");
            this.dUpDownTeamNumber.Items.Add("95");
            this.dUpDownTeamNumber.Items.Add("94");
            this.dUpDownTeamNumber.Items.Add("93");
            this.dUpDownTeamNumber.Items.Add("92");
            this.dUpDownTeamNumber.Items.Add("91");
            this.dUpDownTeamNumber.Items.Add("90");
            this.dUpDownTeamNumber.Items.Add("89");
            this.dUpDownTeamNumber.Items.Add("88");
            this.dUpDownTeamNumber.Items.Add("87");
            this.dUpDownTeamNumber.Items.Add("86");
            this.dUpDownTeamNumber.Items.Add("85");
            this.dUpDownTeamNumber.Items.Add("84");
            this.dUpDownTeamNumber.Items.Add("83");
            this.dUpDownTeamNumber.Items.Add("82");
            this.dUpDownTeamNumber.Items.Add("81");
            this.dUpDownTeamNumber.Items.Add("80");
            this.dUpDownTeamNumber.Items.Add("79");
            this.dUpDownTeamNumber.Items.Add("78");
            this.dUpDownTeamNumber.Items.Add("77");
            this.dUpDownTeamNumber.Items.Add("76");
            this.dUpDownTeamNumber.Items.Add("75");
            this.dUpDownTeamNumber.Items.Add("74");
            this.dUpDownTeamNumber.Items.Add("73");
            this.dUpDownTeamNumber.Items.Add("72");
            this.dUpDownTeamNumber.Items.Add("71");
            this.dUpDownTeamNumber.Items.Add("70");
            this.dUpDownTeamNumber.Items.Add("69");
            this.dUpDownTeamNumber.Items.Add("68");
            this.dUpDownTeamNumber.Items.Add("67");
            this.dUpDownTeamNumber.Items.Add("66");
            this.dUpDownTeamNumber.Items.Add("65");
            this.dUpDownTeamNumber.Items.Add("64");
            this.dUpDownTeamNumber.Items.Add("63");
            this.dUpDownTeamNumber.Items.Add("62");
            this.dUpDownTeamNumber.Items.Add("61");
            this.dUpDownTeamNumber.Items.Add("60");
            this.dUpDownTeamNumber.Items.Add("59");
            this.dUpDownTeamNumber.Items.Add("58");
            this.dUpDownTeamNumber.Items.Add("57");
            this.dUpDownTeamNumber.Items.Add("56");
            this.dUpDownTeamNumber.Items.Add("55");
            this.dUpDownTeamNumber.Items.Add("54");
            this.dUpDownTeamNumber.Items.Add("53");
            this.dUpDownTeamNumber.Items.Add("52");
            this.dUpDownTeamNumber.Items.Add("51");
            this.dUpDownTeamNumber.Items.Add("50");
            this.dUpDownTeamNumber.Items.Add("49");
            this.dUpDownTeamNumber.Items.Add("48");
            this.dUpDownTeamNumber.Items.Add("47");
            this.dUpDownTeamNumber.Items.Add("46");
            this.dUpDownTeamNumber.Items.Add("45");
            this.dUpDownTeamNumber.Items.Add("44");
            this.dUpDownTeamNumber.Items.Add("43");
            this.dUpDownTeamNumber.Items.Add("42");
            this.dUpDownTeamNumber.Items.Add("41");
            this.dUpDownTeamNumber.Items.Add("40");
            this.dUpDownTeamNumber.Items.Add("39");
            this.dUpDownTeamNumber.Items.Add("38");
            this.dUpDownTeamNumber.Items.Add("37");
            this.dUpDownTeamNumber.Items.Add("36");
            this.dUpDownTeamNumber.Items.Add("35");
            this.dUpDownTeamNumber.Items.Add("34");
            this.dUpDownTeamNumber.Items.Add("33");
            this.dUpDownTeamNumber.Items.Add("32");
            this.dUpDownTeamNumber.Items.Add("31");
            this.dUpDownTeamNumber.Items.Add("30");
            this.dUpDownTeamNumber.Items.Add("29");
            this.dUpDownTeamNumber.Items.Add("28");
            this.dUpDownTeamNumber.Items.Add("27");
            this.dUpDownTeamNumber.Items.Add("26");
            this.dUpDownTeamNumber.Items.Add("25");
            this.dUpDownTeamNumber.Items.Add("24");
            this.dUpDownTeamNumber.Items.Add("23");
            this.dUpDownTeamNumber.Items.Add("22");
            this.dUpDownTeamNumber.Items.Add("21");
            this.dUpDownTeamNumber.Items.Add("20");
            this.dUpDownTeamNumber.Items.Add("19");
            this.dUpDownTeamNumber.Items.Add("18");
            this.dUpDownTeamNumber.Items.Add("17");
            this.dUpDownTeamNumber.Items.Add("16");
            this.dUpDownTeamNumber.Items.Add("15");
            this.dUpDownTeamNumber.Items.Add("14");
            this.dUpDownTeamNumber.Items.Add("13");
            this.dUpDownTeamNumber.Items.Add("12");
            this.dUpDownTeamNumber.Items.Add("11");
            this.dUpDownTeamNumber.Items.Add("10");
            this.dUpDownTeamNumber.Items.Add("9");
            this.dUpDownTeamNumber.Items.Add("8");
            this.dUpDownTeamNumber.Items.Add("7");
            this.dUpDownTeamNumber.Items.Add("6");
            this.dUpDownTeamNumber.Items.Add("5");
            this.dUpDownTeamNumber.Items.Add("4");
            this.dUpDownTeamNumber.Items.Add("3");
            this.dUpDownTeamNumber.Items.Add("2");
            this.dUpDownTeamNumber.Items.Add("1");
            this.dUpDownTeamNumber.Location = new System.Drawing.Point(300, 318);
            this.dUpDownTeamNumber.Name = "dUpDownTeamNumber";
            this.dUpDownTeamNumber.Size = new System.Drawing.Size(120, 22);
            this.dUpDownTeamNumber.TabIndex = 16;
            this.dUpDownTeamNumber.SelectedItemChanged += new System.EventHandler(this.dUpDownTeamNumber_SelectedItemChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(163, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 25);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 25);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cBoxNationality
            // 
            this.cBoxNationality.FormattingEnabled = true;
            this.cBoxNationality.Items.AddRange(new object[] {
            "Algeria",
            "Argentina",
            "Australia",
            "Austria",
            "Belgium",
            "Benin",
            "Bosnia and Herzegovina",
            "Brazil",
            "Burkina Faso",
            "Cameroon",
            "Canada",
            "Chile",
            "Colombia",
            "Congo",
            "Costa Rica",
            "Croatia",
            "Curaçao",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "DR Congo",
            "Ecuador",
            "Egypt",
            "England",
            "Finland",
            "France",
            "Gambia",
            "Germany",
            "Ghana",
            "Greece",
            "Hungary",
            "Iceland",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Kenya",
            "Lithuania",
            "Macedonia",
            "Mali",
            "Mexico",
            "Morocco",
            "Netherlands",
            "New Zealand",
            "Nigeria",
            "Northern Ireland",
            "Norway",
            "Poland",
            "Portugal",
            "Republic of Ireland",
            "Romania",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Scotland",
            "Senegal",
            "Serbia",
            "Slovakia",
            "Slovenia",
            "South Africa",
            "South Korea",
            "Spain",
            "Sweden",
            "Switzerland",
            "Togo",
            "Tunisia",
            "Turkey",
            "United States",
            "Uruguay",
            "Venezuela",
            "Wales",
            "Yugoslavia",
            "Zimbabwe"});
            this.cBoxNationality.Location = new System.Drawing.Point(300, 240);
            this.cBoxNationality.Name = "cBoxNationality";
            this.cBoxNationality.Size = new System.Drawing.Size(181, 24);
            this.cBoxNationality.TabIndex = 19;
            // 
            // lblIDLama
            // 
            this.lblIDLama.AutoSize = true;
            this.lblIDLama.Location = new System.Drawing.Point(1155, 734);
            this.lblIDLama.Name = "lblIDLama";
            this.lblIDLama.Size = new System.Drawing.Size(65, 17);
            this.lblIDLama.TabIndex = 20;
            this.lblIDLama.Text = "Player ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.lblIDLama);
            this.Controls.Add(this.cBoxNationality);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dUpDownTeamNumber);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.cBoxTeam);
            this.Controls.Add(this.dTimeBirthdate);
            this.Controls.Add(this.tBoxPlayerName);
            this.Controls.Add(this.tBoxPlayerID);
            this.Controls.Add(this.lblTeamNumber);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.btnNextAll);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBackAll);
            this.Controls.Add(this.btnBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBackAll;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNextAll;
        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblTeamNumber;
        private System.Windows.Forms.TextBox tBoxPlayerID;
        private System.Windows.Forms.TextBox tBoxPlayerName;
        private System.Windows.Forms.DateTimePicker dTimeBirthdate;
        private System.Windows.Forms.ComboBox cBoxTeam;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.DomainUpDown dUpDownTeamNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cBoxNationality;
        private System.Windows.Forms.Label lblIDLama;
    }
}

