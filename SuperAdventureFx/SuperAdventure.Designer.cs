﻿namespace SuperAdventureFx {
  partial class SuperAdventure {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.lblGold = new System.Windows.Forms.Label();
      this.lblHitPoints = new System.Windows.Forms.Label();
      this.lblExperience = new System.Windows.Forms.Label();
      this.lblLevel = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.cboPotions = new System.Windows.Forms.ComboBox();
      this.choWeapons = new System.Windows.Forms.ComboBox();
      this.btnUseWeapon = new System.Windows.Forms.Button();
      this.btnUsePotion = new System.Windows.Forms.Button();
      this.btnNorth = new System.Windows.Forms.Button();
      this.btnEast = new System.Windows.Forms.Button();
      this.btnSouth = new System.Windows.Forms.Button();
      this.btnWest = new System.Windows.Forms.Button();
      this.rtbMessages = new System.Windows.Forms.RichTextBox();
      this.rtbLocation = new System.Windows.Forms.RichTextBox();
      this.dgvInventory = new System.Windows.Forms.DataGridView();
      this.dgvQuests = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Hit Points:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 37);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Gold:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 59);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 17);
      this.label3.TabIndex = 2;
      this.label3.Text = "Experience :";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(18, 80);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(46, 17);
      this.label4.TabIndex = 3;
      this.label4.Text = "Level:";
      // 
      // lblGold
      // 
      this.lblGold.AutoSize = true;
      this.lblGold.Location = new System.Drawing.Point(110, 36);
      this.lblGold.Name = "lblGold";
      this.lblGold.Size = new System.Drawing.Size(0, 17);
      this.lblGold.TabIndex = 4;
      // 
      // lblHitPoints
      // 
      this.lblHitPoints.AutoSize = true;
      this.lblHitPoints.Location = new System.Drawing.Point(110, 15);
      this.lblHitPoints.Name = "lblHitPoints";
      this.lblHitPoints.Size = new System.Drawing.Size(0, 17);
      this.lblHitPoints.TabIndex = 5;
      // 
      // lblExperience
      // 
      this.lblExperience.AutoSize = true;
      this.lblExperience.Location = new System.Drawing.Point(110, 58);
      this.lblExperience.Name = "lblExperience";
      this.lblExperience.Size = new System.Drawing.Size(0, 17);
      this.lblExperience.TabIndex = 6;
      // 
      // lblLevel
      // 
      this.lblLevel.AutoSize = true;
      this.lblLevel.Location = new System.Drawing.Point(110, 79);
      this.lblLevel.Name = "lblLevel";
      this.lblLevel.Size = new System.Drawing.Size(0, 17);
      this.lblLevel.TabIndex = 7;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(617, 425);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(89, 17);
      this.label5.TabIndex = 8;
      this.label5.Text = "Select action";
      // 
      // cboPotions
      // 
      this.cboPotions.FormattingEnabled = true;
      this.cboPotions.Location = new System.Drawing.Point(369, 474);
      this.cboPotions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cboPotions.Name = "cboPotions";
      this.cboPotions.Size = new System.Drawing.Size(151, 24);
      this.cboPotions.TabIndex = 9;
      // 
      // choWeapons
      // 
      this.choWeapons.FormattingEnabled = true;
      this.choWeapons.Location = new System.Drawing.Point(369, 447);
      this.choWeapons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.choWeapons.Name = "choWeapons";
      this.choWeapons.Size = new System.Drawing.Size(151, 24);
      this.choWeapons.TabIndex = 10;
      // 
      // btnUseWeapon
      // 
      this.btnUseWeapon.Location = new System.Drawing.Point(620, 447);
      this.btnUseWeapon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnUseWeapon.Name = "btnUseWeapon";
      this.btnUseWeapon.Size = new System.Drawing.Size(94, 23);
      this.btnUseWeapon.TabIndex = 11;
      this.btnUseWeapon.Text = "Use";
      this.btnUseWeapon.UseVisualStyleBackColor = true;
      // 
      // btnUsePotion
      // 
      this.btnUsePotion.Location = new System.Drawing.Point(620, 474);
      this.btnUsePotion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnUsePotion.Name = "btnUsePotion";
      this.btnUsePotion.Size = new System.Drawing.Size(94, 23);
      this.btnUsePotion.TabIndex = 12;
      this.btnUsePotion.Text = "Use";
      this.btnUsePotion.UseVisualStyleBackColor = true;
      // 
      // btnNorth
      // 
      this.btnNorth.Location = new System.Drawing.Point(493, 346);
      this.btnNorth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnNorth.Name = "btnNorth";
      this.btnNorth.Size = new System.Drawing.Size(94, 23);
      this.btnNorth.TabIndex = 13;
      this.btnNorth.Text = "North";
      this.btnNorth.UseVisualStyleBackColor = true;
      this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
      // 
      // btnEast
      // 
      this.btnEast.Location = new System.Drawing.Point(573, 366);
      this.btnEast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnEast.Name = "btnEast";
      this.btnEast.Size = new System.Drawing.Size(94, 23);
      this.btnEast.TabIndex = 14;
      this.btnEast.Text = "East";
      this.btnEast.UseVisualStyleBackColor = true;
      this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
      // 
      // btnSouth
      // 
      this.btnSouth.Location = new System.Drawing.Point(493, 390);
      this.btnSouth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnSouth.Name = "btnSouth";
      this.btnSouth.Size = new System.Drawing.Size(94, 23);
      this.btnSouth.TabIndex = 15;
      this.btnSouth.Text = "South";
      this.btnSouth.UseVisualStyleBackColor = true;
      // 
      // btnWest
      // 
      this.btnWest.Location = new System.Drawing.Point(412, 366);
      this.btnWest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnWest.Name = "btnWest";
      this.btnWest.Size = new System.Drawing.Size(94, 23);
      this.btnWest.TabIndex = 16;
      this.btnWest.Text = "West";
      this.btnWest.UseVisualStyleBackColor = true;
      this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
      // 
      // rtbMessages
      // 
      this.rtbMessages.Location = new System.Drawing.Point(347, 104);
      this.rtbMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rtbMessages.MinimumSize = new System.Drawing.Size(360, 152);
      this.rtbMessages.Name = "rtbMessages";
      this.rtbMessages.ReadOnly = true;
      this.rtbMessages.Size = new System.Drawing.Size(360, 152);
      this.rtbMessages.TabIndex = 17;
      this.rtbMessages.Text = "";
      // 
      // rtbLocation
      // 
      this.rtbLocation.Location = new System.Drawing.Point(347, 15);
      this.rtbLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rtbLocation.MaximumSize = new System.Drawing.Size(360, 85);
      this.rtbLocation.MinimumSize = new System.Drawing.Size(360, 85);
      this.rtbLocation.Name = "rtbLocation";
      this.rtbLocation.ReadOnly = true;
      this.rtbLocation.Size = new System.Drawing.Size(360, 85);
      this.rtbLocation.TabIndex = 18;
      this.rtbLocation.Text = "";
      // 
      // dgvInventory
      // 
      this.dgvInventory.AllowUserToAddRows = false;
      this.dgvInventory.AllowUserToDeleteRows = false;
      this.dgvInventory.AllowUserToResizeRows = false;
      this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.dgvInventory.Enabled = false;
      this.dgvInventory.Location = new System.Drawing.Point(16, 130);
      this.dgvInventory.MinimumSize = new System.Drawing.Size(312, 309);
      this.dgvInventory.MultiSelect = false;
      this.dgvInventory.Name = "dgvInventory";
      this.dgvInventory.ReadOnly = true;
      this.dgvInventory.RowHeadersVisible = false;
      this.dgvInventory.RowHeadersWidth = 51;
      this.dgvInventory.RowTemplate.Height = 24;
      this.dgvInventory.Size = new System.Drawing.Size(312, 309);
      this.dgvInventory.TabIndex = 19;
      // 
      // dgvQuests
      // 
      this.dgvQuests.AllowUserToAddRows = false;
      this.dgvQuests.AllowUserToDeleteRows = false;
      this.dgvQuests.AllowUserToResizeRows = false;
      this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.dgvQuests.Enabled = false;
      this.dgvQuests.Location = new System.Drawing.Point(16, 446);
      this.dgvQuests.MinimumSize = new System.Drawing.Size(312, 189);
      this.dgvQuests.MultiSelect = false;
      this.dgvQuests.Name = "dgvQuests";
      this.dgvQuests.ReadOnly = true;
      this.dgvQuests.RowHeadersVisible = false;
      this.dgvQuests.RowHeadersWidth = 51;
      this.dgvQuests.RowTemplate.Height = 24;
      this.dgvQuests.Size = new System.Drawing.Size(312, 189);
      this.dgvQuests.TabIndex = 20;
      // 
      // SuperAdventure
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(717, 660);
      this.Controls.Add(this.dgvQuests);
      this.Controls.Add(this.dgvInventory);
      this.Controls.Add(this.rtbLocation);
      this.Controls.Add(this.rtbMessages);
      this.Controls.Add(this.btnWest);
      this.Controls.Add(this.btnSouth);
      this.Controls.Add(this.btnEast);
      this.Controls.Add(this.btnNorth);
      this.Controls.Add(this.btnUsePotion);
      this.Controls.Add(this.btnUseWeapon);
      this.Controls.Add(this.choWeapons);
      this.Controls.Add(this.cboPotions);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lblLevel);
      this.Controls.Add(this.lblExperience);
      this.Controls.Add(this.lblHitPoints);
      this.Controls.Add(this.lblGold);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "SuperAdventure";
      this.Text = "My Game ";
      ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblGold;
    private System.Windows.Forms.Label lblHitPoints;
    private System.Windows.Forms.Label lblExperience;
    private System.Windows.Forms.Label lblLevel;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cboPotions;
    private System.Windows.Forms.ComboBox choWeapons;
    private System.Windows.Forms.Button btnUseWeapon;
    private System.Windows.Forms.Button btnUsePotion;
    private System.Windows.Forms.Button btnNorth;
    private System.Windows.Forms.Button btnEast;
    private System.Windows.Forms.Button btnSouth;
    private System.Windows.Forms.Button btnWest;
    private System.Windows.Forms.RichTextBox rtbMessages;
    private System.Windows.Forms.RichTextBox rtbLocation;
    private System.Windows.Forms.DataGridView dgvInventory;
    private System.Windows.Forms.DataGridView dgvQuests;
  }
}
