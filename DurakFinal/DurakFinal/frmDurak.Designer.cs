namespace DurakFinal
{
    partial class frmDurak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDurak));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame36CardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame52CardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTrump = new CardBox.CardBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.lblOppStatus = new System.Windows.Forms.Label();
            this.lblPlayerStatus = new System.Windows.Forms.Label();
            this.btnTake = new System.Windows.Forms.Button();
            this.lblCardsRemaining = new System.Windows.Forms.Label();
            this.cbxDeck = new CardBox.CardBox();
            this.pnlRiver = new System.Windows.Forms.Panel();
            this.cbxRiver = new CardBox.CardBox();
            this.pnlOppHand = new System.Windows.Forms.Panel();
            this.pbxOppHand = new System.Windows.Forms.PictureBox();
            this.pnlPlayerHand = new System.Windows.Forms.Panel();
            this.cbxHand = new CardBox.CardBox();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.btnStart20 = new System.Windows.Forms.Button();
            this.btnStart36 = new System.Windows.Forms.Button();
            this.btnStart52 = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msMain.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRiver.SuspendLayout();
            this.pnlOppHand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOppHand)).BeginInit();
            this.pnlPlayerHand.SuspendLayout();
            this.pnlStart.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(972, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGame20ToolStripMenuItem,
            this.newGame36CardsToolStripMenuItem,
            this.newGame52CardsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGame20ToolStripMenuItem
            // 
            this.newGame20ToolStripMenuItem.Name = "newGame20ToolStripMenuItem";
            this.newGame20ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newGame20ToolStripMenuItem.Text = "New Game (20 Cards";
            this.newGame20ToolStripMenuItem.Click += new System.EventHandler(this.newGame20ToolStripMenuItem_Click_1);
            // 
            // newGame36CardsToolStripMenuItem
            // 
            this.newGame36CardsToolStripMenuItem.Name = "newGame36CardsToolStripMenuItem";
            this.newGame36CardsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newGame36CardsToolStripMenuItem.Text = "New Game (36 Cards)";
            this.newGame36CardsToolStripMenuItem.Click += new System.EventHandler(this.newGame36CardsToolStripMenuItem_Click);
            // 
            // newGame52CardsToolStripMenuItem
            // 
            this.newGame52CardsToolStripMenuItem.Name = "newGame52CardsToolStripMenuItem";
            this.newGame52CardsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newGame52CardsToolStripMenuItem.Text = "New Game (52 Cards)";
            this.newGame52CardsToolStripMenuItem.Click += new System.EventHandler(this.newGame52CardsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGame.BackColor = System.Drawing.Color.Green;
            this.pnlGame.Controls.Add(this.panel1);
            this.pnlGame.Controls.Add(this.label1);
            this.pnlGame.Controls.Add(this.btnOkay);
            this.pnlGame.Controls.Add(this.lblOppStatus);
            this.pnlGame.Controls.Add(this.lblPlayerStatus);
            this.pnlGame.Controls.Add(this.btnTake);
            this.pnlGame.Controls.Add(this.lblCardsRemaining);
            this.pnlGame.Controls.Add(this.cbxDeck);
            this.pnlGame.Controls.Add(this.pnlRiver);
            this.pnlGame.Controls.Add(this.pnlOppHand);
            this.pnlGame.Controls.Add(this.pnlPlayerHand);
            this.pnlGame.Location = new System.Drawing.Point(0, 27);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(972, 525);
            this.pnlGame.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbxTrump);
            this.panel1.Location = new System.Drawing.Point(37, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 107);
            this.panel1.TabIndex = 11;
            // 
            // cbxTrump
            // 
            this.cbxTrump.BackColor = System.Drawing.Color.Transparent;
            this.cbxTrump.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cbxTrump.FaceUp = false;
            this.cbxTrump.Location = new System.Drawing.Point(0, 0);
            this.cbxTrump.Name = "cbxTrump";
            this.cbxTrump.Rank = JeremyCards.CardRank.Ace;
            this.cbxTrump.Size = new System.Drawing.Size(75, 107);
            this.cbxTrump.Suit = JeremyCards.CardSuit.Hearts;
            this.cbxTrump.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Trump Suit:";
            // 
            // btnOkay
            // 
            this.btnOkay.Enabled = false;
            this.btnOkay.Location = new System.Drawing.Point(806, 288);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(138, 82);
            this.btnOkay.TabIndex = 8;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // lblOppStatus
            // 
            this.lblOppStatus.AutoSize = true;
            this.lblOppStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblOppStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOppStatus.Location = new System.Drawing.Point(279, 145);
            this.lblOppStatus.Name = "lblOppStatus";
            this.lblOppStatus.Size = new System.Drawing.Size(155, 24);
            this.lblOppStatus.TabIndex = 7;
            this.lblOppStatus.Text = "Opponent Status:";
            // 
            // lblPlayerStatus
            // 
            this.lblPlayerStatus.AutoSize = true;
            this.lblPlayerStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStatus.Location = new System.Drawing.Point(279, 346);
            this.lblPlayerStatus.Name = "lblPlayerStatus";
            this.lblPlayerStatus.Size = new System.Drawing.Size(110, 24);
            this.lblPlayerStatus.TabIndex = 6;
            this.lblPlayerStatus.Text = "Your Status:";
            // 
            // btnTake
            // 
            this.btnTake.Enabled = false;
            this.btnTake.Location = new System.Drawing.Point(806, 390);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(138, 82);
            this.btnTake.TabIndex = 5;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // lblCardsRemaining
            // 
            this.lblCardsRemaining.AutoSize = true;
            this.lblCardsRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblCardsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardsRemaining.Location = new System.Drawing.Point(21, 178);
            this.lblCardsRemaining.Name = "lblCardsRemaining";
            this.lblCardsRemaining.Size = new System.Drawing.Size(165, 24);
            this.lblCardsRemaining.TabIndex = 4;
            this.lblCardsRemaining.Text = "Cards Remaining: ";
            // 
            // cbxDeck
            // 
            this.cbxDeck.BackColor = System.Drawing.Color.Transparent;
            this.cbxDeck.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cbxDeck.FaceUp = false;
            this.cbxDeck.Location = new System.Drawing.Point(37, 68);
            this.cbxDeck.Name = "cbxDeck";
            this.cbxDeck.Rank = JeremyCards.CardRank.Ace;
            this.cbxDeck.Size = new System.Drawing.Size(75, 107);
            this.cbxDeck.Suit = JeremyCards.CardSuit.Hearts;
            this.cbxDeck.TabIndex = 3;
            // 
            // pnlRiver
            // 
            this.pnlRiver.BackColor = System.Drawing.Color.Maroon;
            this.pnlRiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRiver.Controls.Add(this.cbxRiver);
            this.pnlRiver.Location = new System.Drawing.Point(221, 183);
            this.pnlRiver.Name = "pnlRiver";
            this.pnlRiver.Size = new System.Drawing.Size(546, 151);
            this.pnlRiver.TabIndex = 2;
            // 
            // cbxRiver
            // 
            this.cbxRiver.BackColor = System.Drawing.Color.Transparent;
            this.cbxRiver.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cbxRiver.FaceUp = false;
            this.cbxRiver.Location = new System.Drawing.Point(25, 20);
            this.cbxRiver.Name = "cbxRiver";
            this.cbxRiver.Rank = JeremyCards.CardRank.Ace;
            this.cbxRiver.Size = new System.Drawing.Size(75, 107);
            this.cbxRiver.Suit = JeremyCards.CardSuit.Hearts;
            this.cbxRiver.TabIndex = 12;
            this.cbxRiver.Visible = false;
            // 
            // pnlOppHand
            // 
            this.pnlOppHand.BackColor = System.Drawing.Color.Teal;
            this.pnlOppHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOppHand.Controls.Add(this.pbxOppHand);
            this.pnlOppHand.Location = new System.Drawing.Point(221, 12);
            this.pnlOppHand.Name = "pnlOppHand";
            this.pnlOppHand.Size = new System.Drawing.Size(546, 120);
            this.pnlOppHand.TabIndex = 1;
            // 
            // pbxOppHand
            // 
            this.pbxOppHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxOppHand.BackgroundImage")));
            this.pbxOppHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxOppHand.Location = new System.Drawing.Point(25, 5);
            this.pbxOppHand.Name = "pbxOppHand";
            this.pbxOppHand.Size = new System.Drawing.Size(75, 107);
            this.pbxOppHand.TabIndex = 11;
            this.pbxOppHand.TabStop = false;
            this.pbxOppHand.Visible = false;
            // 
            // pnlPlayerHand
            // 
            this.pnlPlayerHand.BackColor = System.Drawing.Color.Teal;
            this.pnlPlayerHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerHand.Controls.Add(this.cbxHand);
            this.pnlPlayerHand.Location = new System.Drawing.Point(221, 373);
            this.pnlPlayerHand.Name = "pnlPlayerHand";
            this.pnlPlayerHand.Size = new System.Drawing.Size(546, 138);
            this.pnlPlayerHand.TabIndex = 0;
            // 
            // cbxHand
            // 
            this.cbxHand.BackColor = System.Drawing.Color.Transparent;
            this.cbxHand.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cbxHand.FaceUp = false;
            this.cbxHand.Location = new System.Drawing.Point(25, 25);
            this.cbxHand.Name = "cbxHand";
            this.cbxHand.Rank = JeremyCards.CardRank.Ace;
            this.cbxHand.Size = new System.Drawing.Size(75, 107);
            this.cbxHand.Suit = JeremyCards.CardSuit.Hearts;
            this.cbxHand.TabIndex = 11;
            this.cbxHand.Visible = false;
            // 
            // pnlStart
            // 
            this.pnlStart.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlStart.Controls.Add(this.label3);
            this.pnlStart.Controls.Add(this.pnlTitle);
            this.pnlStart.Controls.Add(this.btnStart52);
            this.pnlStart.Controls.Add(this.btnStart36);
            this.pnlStart.Controls.Add(this.btnStart20);
            this.pnlStart.Location = new System.Drawing.Point(0, 27);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(969, 522);
            this.pnlStart.TabIndex = 2;
            // 
            // btnStart20
            // 
            this.btnStart20.Location = new System.Drawing.Point(328, 250);
            this.btnStart20.Name = "btnStart20";
            this.btnStart20.Size = new System.Drawing.Size(75, 23);
            this.btnStart20.TabIndex = 0;
            this.btnStart20.Text = "20";
            this.btnStart20.UseVisualStyleBackColor = true;
            this.btnStart20.Click += new System.EventHandler(this.btnStart20_Click);
            // 
            // btnStart36
            // 
            this.btnStart36.Location = new System.Drawing.Point(451, 250);
            this.btnStart36.Name = "btnStart36";
            this.btnStart36.Size = new System.Drawing.Size(75, 23);
            this.btnStart36.TabIndex = 1;
            this.btnStart36.Text = "36";
            this.btnStart36.UseVisualStyleBackColor = true;
            this.btnStart36.Click += new System.EventHandler(this.btnStart36_Click);
            // 
            // btnStart52
            // 
            this.btnStart52.Location = new System.Drawing.Point(574, 250);
            this.btnStart52.Name = "btnStart52";
            this.btnStart52.Size = new System.Drawing.Size(75, 23);
            this.btnStart52.TabIndex = 2;
            this.btnStart52.Text = "52";
            this.btnStart52.UseVisualStyleBackColor = true;
            this.btnStart52.Click += new System.EventHandler(this.btnStart52_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Silver;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(285, 35);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(420, 133);
            this.pnlTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(100, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 58);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Durak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose your deck size:";
            // 
            // frmDurak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 550);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmDurak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak Game";
            this.Load += new System.EventHandler(this.frmDurak_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlRiver.ResumeLayout(false);
            this.pnlOppHand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOppHand)).EndInit();
            this.pnlPlayerHand.ResumeLayout(false);
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGame20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlOppHand;
        private System.Windows.Forms.Panel pnlPlayerHand;
        private System.Windows.Forms.Label lblCardsRemaining;
        private CardBox.CardBox cbxDeck;
        private System.Windows.Forms.Panel pnlRiver;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Label lblOppStatus;
        private System.Windows.Forms.Label lblPlayerStatus;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Label label1;
        private CardBox.CardBox cbxTrump;
        private System.Windows.Forms.ToolStripMenuItem newGame36CardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGame52CardsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbxOppHand;
        private CardBox.CardBox cbxHand;
        private System.Windows.Forms.Panel panel1;
        private CardBox.CardBox cbxRiver;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Button btnStart52;
        private System.Windows.Forms.Button btnStart36;
        private System.Windows.Forms.Button btnStart20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}

