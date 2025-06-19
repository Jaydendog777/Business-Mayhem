namespace Business_Mayhem
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cashLabel = new System.Windows.Forms.Label();
            this.lemonadeStandButton = new System.Windows.Forms.Button();
            this.lemonadeUpgradeButton = new System.Windows.Forms.Button();
            this.lemonadeMoneyLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lemonadeStandLevelLabel = new System.Windows.Forms.Label();
            this.upgradesButton = new System.Windows.Forms.Button();
            this.fastFoodLevelLabel = new System.Windows.Forms.Label();
            this.fastFoodMoneyLabel = new System.Windows.Forms.Label();
            this.fastFoodUpgradeButton = new System.Windows.Forms.Button();
            this.fastFoodButton = new System.Windows.Forms.Button();
            this.rugbyTeamButton = new System.Windows.Forms.Button();
            this.rugbyTeamMoneyLabel = new System.Windows.Forms.Label();
            this.rugbyTeamUpgradeButton = new System.Windows.Forms.Button();
            this.rugbyTeamLevelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cashLabel
            // 
            this.cashLabel.BackColor = System.Drawing.Color.Transparent;
            this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.Location = new System.Drawing.Point(6, 39);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(926, 64);
            this.cashLabel.TabIndex = 0;
            this.cashLabel.Text = "Money";
            this.cashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lemonadeStandButton
            // 
            this.lemonadeStandButton.Location = new System.Drawing.Point(237, 143);
            this.lemonadeStandButton.Name = "lemonadeStandButton";
            this.lemonadeStandButton.Size = new System.Drawing.Size(102, 56);
            this.lemonadeStandButton.TabIndex = 1;
            this.lemonadeStandButton.Text = "Lemonade Stand";
            this.lemonadeStandButton.UseVisualStyleBackColor = true;
            this.lemonadeStandButton.Click += new System.EventHandler(this.lemonadeStandButton_Click);
            // 
            // lemonadeUpgradeButton
            // 
            this.lemonadeUpgradeButton.Location = new System.Drawing.Point(359, 202);
            this.lemonadeUpgradeButton.Name = "lemonadeUpgradeButton";
            this.lemonadeUpgradeButton.Size = new System.Drawing.Size(234, 35);
            this.lemonadeUpgradeButton.TabIndex = 2;
            this.lemonadeUpgradeButton.Text = "Upgrade";
            this.lemonadeUpgradeButton.UseVisualStyleBackColor = true;
            this.lemonadeUpgradeButton.Click += new System.EventHandler(this.lemonadeUpgradeButton_Click);
            // 
            // lemonadeMoneyLabel
            // 
            this.lemonadeMoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.lemonadeMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemonadeMoneyLabel.Location = new System.Drawing.Point(353, 143);
            this.lemonadeMoneyLabel.Name = "lemonadeMoneyLabel";
            this.lemonadeMoneyLabel.Size = new System.Drawing.Size(232, 52);
            this.lemonadeMoneyLabel.TabIndex = 3;
            this.lemonadeMoneyLabel.Text = "Money";
            this.lemonadeMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // lemonadeStandLevelLabel
            // 
            this.lemonadeStandLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.lemonadeStandLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemonadeStandLevelLabel.Location = new System.Drawing.Point(237, 202);
            this.lemonadeStandLevelLabel.Name = "lemonadeStandLevelLabel";
            this.lemonadeStandLevelLabel.Size = new System.Drawing.Size(102, 42);
            this.lemonadeStandLevelLabel.TabIndex = 4;
            this.lemonadeStandLevelLabel.Text = "lvl";
            this.lemonadeStandLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upgradesButton
            // 
            this.upgradesButton.Location = new System.Drawing.Point(25, 177);
            this.upgradesButton.Name = "upgradesButton";
            this.upgradesButton.Size = new System.Drawing.Size(124, 46);
            this.upgradesButton.TabIndex = 5;
            this.upgradesButton.Text = "upgrades";
            this.upgradesButton.UseVisualStyleBackColor = true;
            this.upgradesButton.Click += new System.EventHandler(this.upgradesButton_Click);
            // 
            // fastFoodLevelLabel
            // 
            this.fastFoodLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.fastFoodLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastFoodLevelLabel.Location = new System.Drawing.Point(237, 313);
            this.fastFoodLevelLabel.Name = "fastFoodLevelLabel";
            this.fastFoodLevelLabel.Size = new System.Drawing.Size(102, 42);
            this.fastFoodLevelLabel.TabIndex = 9;
            this.fastFoodLevelLabel.Text = "lvl";
            this.fastFoodLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fastFoodMoneyLabel
            // 
            this.fastFoodMoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.fastFoodMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastFoodMoneyLabel.Location = new System.Drawing.Point(353, 254);
            this.fastFoodMoneyLabel.Name = "fastFoodMoneyLabel";
            this.fastFoodMoneyLabel.Size = new System.Drawing.Size(232, 52);
            this.fastFoodMoneyLabel.TabIndex = 8;
            this.fastFoodMoneyLabel.Text = "Purchase";
            this.fastFoodMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fastFoodUpgradeButton
            // 
            this.fastFoodUpgradeButton.Location = new System.Drawing.Point(359, 313);
            this.fastFoodUpgradeButton.Name = "fastFoodUpgradeButton";
            this.fastFoodUpgradeButton.Size = new System.Drawing.Size(234, 35);
            this.fastFoodUpgradeButton.TabIndex = 7;
            this.fastFoodUpgradeButton.Text = "($5,000) Purchase";
            this.fastFoodUpgradeButton.UseVisualStyleBackColor = true;
            this.fastFoodUpgradeButton.Click += new System.EventHandler(this.fastFoodUpgradeButton_Click);
            // 
            // fastFoodButton
            // 
            this.fastFoodButton.Enabled = false;
            this.fastFoodButton.Location = new System.Drawing.Point(237, 254);
            this.fastFoodButton.Name = "fastFoodButton";
            this.fastFoodButton.Size = new System.Drawing.Size(102, 56);
            this.fastFoodButton.TabIndex = 6;
            this.fastFoodButton.Text = "Fast Food Resturant";
            this.fastFoodButton.UseVisualStyleBackColor = true;
            this.fastFoodButton.Click += new System.EventHandler(this.fastFoodButton_Click);
            // 
            // rugbyTeamButton
            // 
            this.rugbyTeamButton.Enabled = false;
            this.rugbyTeamButton.Location = new System.Drawing.Point(242, 393);
            this.rugbyTeamButton.Name = "rugbyTeamButton";
            this.rugbyTeamButton.Size = new System.Drawing.Size(102, 56);
            this.rugbyTeamButton.TabIndex = 10;
            this.rugbyTeamButton.Text = "Rugby Team";
            this.rugbyTeamButton.UseVisualStyleBackColor = true;
            // 
            // rugbyTeamMoneyLabel
            // 
            this.rugbyTeamMoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.rugbyTeamMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rugbyTeamMoneyLabel.Location = new System.Drawing.Point(361, 389);
            this.rugbyTeamMoneyLabel.Name = "rugbyTeamMoneyLabel";
            this.rugbyTeamMoneyLabel.Size = new System.Drawing.Size(232, 52);
            this.rugbyTeamMoneyLabel.TabIndex = 11;
            this.rugbyTeamMoneyLabel.Text = "Purchase";
            this.rugbyTeamMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rugbyTeamUpgradeButton
            // 
            this.rugbyTeamUpgradeButton.Location = new System.Drawing.Point(359, 460);
            this.rugbyTeamUpgradeButton.Name = "rugbyTeamUpgradeButton";
            this.rugbyTeamUpgradeButton.Size = new System.Drawing.Size(234, 35);
            this.rugbyTeamUpgradeButton.TabIndex = 12;
            this.rugbyTeamUpgradeButton.Text = "($5,000) Purchase";
            this.rugbyTeamUpgradeButton.UseVisualStyleBackColor = true;
            this.rugbyTeamUpgradeButton.Click += new System.EventHandler(this.rugbyTeamUpgradeButton_Click);
            // 
            // rugbyTeamLevelLabel
            // 
            this.rugbyTeamLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.rugbyTeamLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rugbyTeamLevelLabel.Location = new System.Drawing.Point(242, 453);
            this.rugbyTeamLevelLabel.Name = "rugbyTeamLevelLabel";
            this.rugbyTeamLevelLabel.Size = new System.Drawing.Size(102, 42);
            this.rugbyTeamLevelLabel.TabIndex = 13;
            this.rugbyTeamLevelLabel.Text = "lvl";
            this.rugbyTeamLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Business_Mayhem.Properties.Resources.Business_Mayhem_Main_Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.rugbyTeamLevelLabel);
            this.Controls.Add(this.rugbyTeamUpgradeButton);
            this.Controls.Add(this.rugbyTeamMoneyLabel);
            this.Controls.Add(this.rugbyTeamButton);
            this.Controls.Add(this.fastFoodLevelLabel);
            this.Controls.Add(this.fastFoodMoneyLabel);
            this.Controls.Add(this.fastFoodUpgradeButton);
            this.Controls.Add(this.fastFoodButton);
            this.Controls.Add(this.upgradesButton);
            this.Controls.Add(this.lemonadeStandLevelLabel);
            this.Controls.Add(this.lemonadeMoneyLabel);
            this.Controls.Add(this.lemonadeUpgradeButton);
            this.Controls.Add(this.lemonadeStandButton);
            this.Controls.Add(this.cashLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(932, 563);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Button lemonadeStandButton;
        private System.Windows.Forms.Button lemonadeUpgradeButton;
        private System.Windows.Forms.Label lemonadeMoneyLabel;
        private System.Windows.Forms.Label lemonadeStandLevelLabel;
        private System.Windows.Forms.Button upgradesButton;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label fastFoodLevelLabel;
        private System.Windows.Forms.Label fastFoodMoneyLabel;
        private System.Windows.Forms.Button fastFoodUpgradeButton;
        private System.Windows.Forms.Button fastFoodButton;
        private System.Windows.Forms.Button rugbyTeamButton;
        private System.Windows.Forms.Label rugbyTeamMoneyLabel;
        private System.Windows.Forms.Button rugbyTeamUpgradeButton;
        private System.Windows.Forms.Label rugbyTeamLevelLabel;
    }
}
