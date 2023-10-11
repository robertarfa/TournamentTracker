namespace TrackerUI
{
    partial class CreateTournamentForm
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
            headerLabel = new Label();
            tournamentValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            TournamentPlayerListBox = new ListBox();
            tournamentPlayerslabel = new Label();
            deleteSelectedPrizebutton = new Button();
            prizeslabel = new Label();
            prizeslistBox = new ListBox();
            deleteSelectedPlayerButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.Blue;
            headerLabel.Location = new Point(27, 34);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(403, 62);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            headerLabel.Click += headerLabel_Click;
            // 
            // tournamentValue
            // 
            tournamentValue.Location = new Point(49, 188);
            tournamentValue.Name = "tournamentValue";
            tournamentValue.Size = new Size(381, 43);
            tournamentValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.Blue;
            tournamentNameLabel.Location = new Point(49, 127);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(308, 47);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(248, 255);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(125, 43);
            entryFeeValue.TabIndex = 12;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = Color.Blue;
            entryFeeLabel.Location = new Point(49, 255);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(162, 47);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(49, 393);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(381, 45);
            selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.Blue;
            selectTeamLabel.Location = new Point(49, 333);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(202, 47);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(278, 352);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(152, 38);
            createNewTeamLink.TabIndex = 15;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.BackColor = SystemColors.ButtonFace;
            addTeamButton.DialogResult = DialogResult.Yes;
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.Blue;
            addTeamButton.Location = new Point(144, 444);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(180, 53);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = false;
            // 
            // createPrizeButton
            // 
            createPrizeButton.BackColor = SystemColors.ButtonFace;
            createPrizeButton.DialogResult = DialogResult.Yes;
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.Blue;
            createPrizeButton.Location = new Point(144, 503);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(180, 53);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = false;
            // 
            // TournamentPlayerListBox
            // 
            TournamentPlayerListBox.BorderStyle = BorderStyle.FixedSingle;
            TournamentPlayerListBox.FormattingEnabled = true;
            TournamentPlayerListBox.ItemHeight = 37;
            TournamentPlayerListBox.Location = new Point(468, 188);
            TournamentPlayerListBox.Name = "TournamentPlayerListBox";
            TournamentPlayerListBox.Size = new Size(404, 187);
            TournamentPlayerListBox.TabIndex = 18;
            // 
            // tournamentPlayerslabel
            // 
            tournamentPlayerslabel.AutoSize = true;
            tournamentPlayerslabel.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayerslabel.ForeColor = Color.Blue;
            tournamentPlayerslabel.Location = new Point(468, 127);
            tournamentPlayerslabel.Name = "tournamentPlayerslabel";
            tournamentPlayerslabel.Size = new Size(243, 47);
            tournamentPlayerslabel.TabIndex = 19;
            tournamentPlayerslabel.Text = "Team / Players";
            // 
            // deleteSelectedPrizebutton
            // 
            deleteSelectedPrizebutton.BackColor = SystemColors.ButtonFace;
            deleteSelectedPrizebutton.DialogResult = DialogResult.Yes;
            deleteSelectedPrizebutton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizebutton.FlatAppearance.MouseDownBackColor = Color.Gray;
            deleteSelectedPrizebutton.FlatAppearance.MouseOverBackColor = Color.White;
            deleteSelectedPrizebutton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizebutton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPrizebutton.ForeColor = Color.Blue;
            deleteSelectedPrizebutton.Location = new Point(916, 501);
            deleteSelectedPrizebutton.Name = "deleteSelectedPrizebutton";
            deleteSelectedPrizebutton.Size = new Size(138, 100);
            deleteSelectedPrizebutton.TabIndex = 23;
            deleteSelectedPrizebutton.Text = "Delete Selected";
            deleteSelectedPrizebutton.UseVisualStyleBackColor = false;
            // 
            // prizeslabel
            // 
            prizeslabel.AutoSize = true;
            prizeslabel.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            prizeslabel.ForeColor = Color.Blue;
            prizeslabel.Location = new Point(468, 397);
            prizeslabel.Name = "prizeslabel";
            prizeslabel.Size = new Size(109, 47);
            prizeslabel.TabIndex = 22;
            prizeslabel.Text = "Prizes";
            // 
            // prizeslistBox
            // 
            prizeslistBox.BorderStyle = BorderStyle.FixedSingle;
            prizeslistBox.FormattingEnabled = true;
            prizeslistBox.ItemHeight = 37;
            prizeslistBox.Location = new Point(468, 458);
            prizeslistBox.Name = "prizeslistBox";
            prizeslistBox.Size = new Size(404, 187);
            prizeslistBox.TabIndex = 21;
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.BackColor = SystemColors.ButtonFace;
            deleteSelectedPlayerButton.DialogResult = DialogResult.Yes;
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.White;
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPlayerButton.ForeColor = Color.Blue;
            deleteSelectedPlayerButton.Location = new Point(916, 231);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(138, 100);
            deleteSelectedPlayerButton.TabIndex = 24;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            createTournamentButton.BackColor = SystemColors.ButtonFace;
            createTournamentButton.DialogResult = DialogResult.Yes;
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.Blue;
            createTournamentButton.Location = new Point(321, 668);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(319, 53);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 733);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(deleteSelectedPrizebutton);
            Controls.Add(prizeslabel);
            Controls.Add(prizeslistBox);
            Controls.Add(tournamentPlayerslabel);
            Controls.Add(TournamentPlayerListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox TournamentPlayerListBox;
        private Label tournamentPlayerslabel;
        private Button deleteSelectedPrizebutton;
        private Label prizeslabel;
        private ListBox prizeslistBox;
        private Button deleteSelectedPlayerButton;
        private Button createTournamentButton;
    }
}