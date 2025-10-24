namespace ADVG
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
            this.titleLable = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.rulesButton = new System.Windows.Forms.Button();
            this.nameLable = new System.Windows.Forms.Label();
            this.titalLable2 = new System.Windows.Forms.Label();
            this.textLable = new System.Windows.Forms.Label();
            this.fireChoice = new System.Windows.Forms.Button();
            this.waterChoice = new System.Windows.Forms.Button();
            this.earthChoice = new System.Windows.Forms.Button();
            this.fireball = new System.Windows.Forms.Button();
            this.ignite = new System.Windows.Forms.Button();
            this.healthText = new System.Windows.Forms.Label();
            this.healthLable = new System.Windows.Forms.Label();
            this.manaText = new System.Windows.Forms.Label();
            this.manaLable = new System.Windows.Forms.Label();
            this.staminaText = new System.Windows.Forms.Label();
            this.staminaLable = new System.Windows.Forms.Label();
            this.storm = new System.Windows.Forms.Button();
            this.tide = new System.Windows.Forms.Button();
            this.tremour = new System.Windows.Forms.Button();
            this.rock = new System.Windows.Forms.Button();
            this.firePathButton = new System.Windows.Forms.Button();
            this.icePathButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.kingButton = new System.Windows.Forms.Button();
            this.s1 = new System.Windows.Forms.Label();
            this.replayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.BackColor = System.Drawing.SystemColors.Control;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(12, 9);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(871, 69);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "The Wizards journey";
            this.titleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(376, 249);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(143, 103);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(376, 221);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(143, 22);
            this.nameInput.TabIndex = 2;
            // 
            // rulesButton
            // 
            this.rulesButton.Location = new System.Drawing.Point(12, 494);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(81, 65);
            this.rulesButton.TabIndex = 3;
            this.rulesButton.Text = "Rules";
            this.rulesButton.UseVisualStyleBackColor = true;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // nameLable
            // 
            this.nameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLable.Location = new System.Drawing.Point(361, 183);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(185, 35);
            this.nameLable.TabIndex = 4;
            this.nameLable.Text = "Enter player name";
            this.nameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titalLable2
            // 
            this.titalLable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titalLable2.Location = new System.Drawing.Point(277, 78);
            this.titalLable2.Name = "titalLable2";
            this.titalLable2.Size = new System.Drawing.Size(358, 105);
            this.titalLable2.TabIndex = 5;
            this.titalLable2.Text = "Begin your jouney to become the king";
            this.titalLable2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textLable
            // 
            this.textLable.BackColor = System.Drawing.Color.Transparent;
            this.textLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLable.Location = new System.Drawing.Point(100, 191);
            this.textLable.Name = "textLable";
            this.textLable.Size = new System.Drawing.Size(732, 164);
            this.textLable.TabIndex = 6;
            this.textLable.Text = "label1";
            this.textLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textLable.Visible = false;
            this.textLable.Click += new System.EventHandler(this.textLable_Click);
            // 
            // fireChoice
            // 
            this.fireChoice.Location = new System.Drawing.Point(264, 358);
            this.fireChoice.Name = "fireChoice";
            this.fireChoice.Size = new System.Drawing.Size(106, 97);
            this.fireChoice.TabIndex = 7;
            this.fireChoice.Text = "Book of fire";
            this.fireChoice.UseVisualStyleBackColor = true;
            this.fireChoice.Visible = false;
            this.fireChoice.Click += new System.EventHandler(this.fireChoice_Click);
            // 
            // waterChoice
            // 
            this.waterChoice.Location = new System.Drawing.Point(542, 358);
            this.waterChoice.Name = "waterChoice";
            this.waterChoice.Size = new System.Drawing.Size(106, 97);
            this.waterChoice.TabIndex = 8;
            this.waterChoice.Text = "Book of water";
            this.waterChoice.UseVisualStyleBackColor = true;
            this.waterChoice.Visible = false;
            this.waterChoice.Click += new System.EventHandler(this.waterChoice_Click);
            // 
            // earthChoice
            // 
            this.earthChoice.Location = new System.Drawing.Point(413, 358);
            this.earthChoice.Name = "earthChoice";
            this.earthChoice.Size = new System.Drawing.Size(106, 97);
            this.earthChoice.TabIndex = 9;
            this.earthChoice.Text = "Book of earth";
            this.earthChoice.UseVisualStyleBackColor = true;
            this.earthChoice.Visible = false;
            this.earthChoice.Click += new System.EventHandler(this.earthChoice_Click);
            // 
            // fireball
            // 
            this.fireball.Location = new System.Drawing.Point(329, 358);
            this.fireball.Name = "fireball";
            this.fireball.Size = new System.Drawing.Size(106, 97);
            this.fireball.TabIndex = 10;
            this.fireball.Text = "Fireball costs (10 mana)";
            this.fireball.UseVisualStyleBackColor = true;
            this.fireball.Visible = false;
            this.fireball.Click += new System.EventHandler(this.fireball_Click);
            // 
            // ignite
            // 
            this.ignite.Location = new System.Drawing.Point(467, 358);
            this.ignite.Name = "ignite";
            this.ignite.Size = new System.Drawing.Size(106, 97);
            this.ignite.TabIndex = 11;
            this.ignite.Text = "Ignite costs      (5 mana)";
            this.ignite.UseVisualStyleBackColor = true;
            this.ignite.Visible = false;
            this.ignite.Click += new System.EventHandler(this.ignite_Click);
            // 
            // healthText
            // 
            this.healthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthText.Location = new System.Drawing.Point(711, 9);
            this.healthText.Name = "healthText";
            this.healthText.Size = new System.Drawing.Size(83, 50);
            this.healthText.TabIndex = 12;
            this.healthText.Text = "Health";
            this.healthText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.healthText.Visible = false;
            // 
            // healthLable
            // 
            this.healthLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLable.Location = new System.Drawing.Point(800, 9);
            this.healthLable.Name = "healthLable";
            this.healthLable.Size = new System.Drawing.Size(83, 50);
            this.healthLable.TabIndex = 13;
            this.healthLable.Text = "100";
            this.healthLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.healthLable.Visible = false;
            // 
            // manaText
            // 
            this.manaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaText.Location = new System.Drawing.Point(706, 54);
            this.manaText.Name = "manaText";
            this.manaText.Size = new System.Drawing.Size(88, 50);
            this.manaText.TabIndex = 14;
            this.manaText.Text = "Mana";
            this.manaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manaText.Visible = false;
            // 
            // manaLable
            // 
            this.manaLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaLable.Location = new System.Drawing.Point(800, 54);
            this.manaLable.Name = "manaLable";
            this.manaLable.Size = new System.Drawing.Size(83, 50);
            this.manaLable.TabIndex = 15;
            this.manaLable.Text = "100";
            this.manaLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manaLable.Visible = false;
            // 
            // staminaText
            // 
            this.staminaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staminaText.Location = new System.Drawing.Point(707, 96);
            this.staminaText.Name = "staminaText";
            this.staminaText.Size = new System.Drawing.Size(87, 50);
            this.staminaText.TabIndex = 16;
            this.staminaText.Text = "stamina";
            this.staminaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.staminaText.Visible = false;
            // 
            // staminaLable
            // 
            this.staminaLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staminaLable.Location = new System.Drawing.Point(800, 96);
            this.staminaLable.Name = "staminaLable";
            this.staminaLable.Size = new System.Drawing.Size(83, 50);
            this.staminaLable.TabIndex = 17;
            this.staminaLable.Text = "100";
            this.staminaLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.staminaLable.Visible = false;
            // 
            // storm
            // 
            this.storm.Location = new System.Drawing.Point(329, 358);
            this.storm.Name = "storm";
            this.storm.Size = new System.Drawing.Size(106, 97);
            this.storm.TabIndex = 18;
            this.storm.Text = "Storm costs (10 mana)";
            this.storm.UseVisualStyleBackColor = true;
            this.storm.Visible = false;
            this.storm.Click += new System.EventHandler(this.storm_Click);
            // 
            // tide
            // 
            this.tide.Location = new System.Drawing.Point(467, 355);
            this.tide.Name = "tide";
            this.tide.Size = new System.Drawing.Size(106, 97);
            this.tide.TabIndex = 19;
            this.tide.Text = "Tide costs (5 mana)";
            this.tide.UseVisualStyleBackColor = true;
            this.tide.Visible = false;
            this.tide.Click += new System.EventHandler(this.tide_Click);
            // 
            // tremour
            // 
            this.tremour.Location = new System.Drawing.Point(467, 355);
            this.tremour.Name = "tremour";
            this.tremour.Size = new System.Drawing.Size(106, 97);
            this.tremour.TabIndex = 20;
            this.tremour.Text = "Tremour costs (5 mana)";
            this.tremour.UseVisualStyleBackColor = true;
            this.tremour.Visible = false;
            this.tremour.Click += new System.EventHandler(this.tremour_Click);
            // 
            // rock
            // 
            this.rock.Location = new System.Drawing.Point(329, 358);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(106, 97);
            this.rock.TabIndex = 21;
            this.rock.Text = "Rock costs (10 mana)";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Visible = false;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // firePathButton
            // 
            this.firePathButton.Location = new System.Drawing.Point(329, 358);
            this.firePathButton.Name = "firePathButton";
            this.firePathButton.Size = new System.Drawing.Size(106, 97);
            this.firePathButton.TabIndex = 22;
            this.firePathButton.Text = "Fire path";
            this.firePathButton.UseVisualStyleBackColor = true;
            this.firePathButton.Visible = false;
            this.firePathButton.Click += new System.EventHandler(this.firePathButton_Click);
            // 
            // icePathButton
            // 
            this.icePathButton.Location = new System.Drawing.Point(467, 355);
            this.icePathButton.Name = "icePathButton";
            this.icePathButton.Size = new System.Drawing.Size(106, 97);
            this.icePathButton.TabIndex = 23;
            this.icePathButton.Text = "Ice path";
            this.icePathButton.UseVisualStyleBackColor = true;
            this.icePathButton.Visible = false;
            this.icePathButton.Click += new System.EventHandler(this.icePathButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(329, 358);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 97);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Save the Kingdome";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // kingButton
            // 
            this.kingButton.Location = new System.Drawing.Point(467, 358);
            this.kingButton.Name = "kingButton";
            this.kingButton.Size = new System.Drawing.Size(106, 97);
            this.kingButton.TabIndex = 25;
            this.kingButton.Text = "Become the king";
            this.kingButton.UseVisualStyleBackColor = true;
            this.kingButton.Visible = false;
            this.kingButton.Click += new System.EventHandler(this.kingButton_Click);
            // 
            // s1
            // 
            this.s1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.s1.Location = new System.Drawing.Point(9, 9);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(874, 553);
            this.s1.TabIndex = 26;
            this.s1.Visible = false;
            // 
            // replayButton
            // 
            this.replayButton.Location = new System.Drawing.Point(399, 358);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(106, 97);
            this.replayButton.TabIndex = 27;
            this.replayButton.Text = "Restart";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Visible = false;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(895, 571);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.kingButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.icePathButton);
            this.Controls.Add(this.firePathButton);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.tremour);
            this.Controls.Add(this.tide);
            this.Controls.Add(this.storm);
            this.Controls.Add(this.staminaLable);
            this.Controls.Add(this.staminaText);
            this.Controls.Add(this.manaLable);
            this.Controls.Add(this.manaText);
            this.Controls.Add(this.healthLable);
            this.Controls.Add(this.healthText);
            this.Controls.Add(this.ignite);
            this.Controls.Add(this.fireball);
            this.Controls.Add(this.earthChoice);
            this.Controls.Add(this.waterChoice);
            this.Controls.Add(this.fireChoice);
            this.Controls.Add(this.textLable);
            this.Controls.Add(this.titalLable2);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.s1);
            this.Name = "Form1";
            this.Text = "the wizz journey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label titalLable2;
        private System.Windows.Forms.Label textLable;
        private System.Windows.Forms.Button fireChoice;
        private System.Windows.Forms.Button waterChoice;
        private System.Windows.Forms.Button earthChoice;
        private System.Windows.Forms.Button fireball;
        private System.Windows.Forms.Button ignite;
        private System.Windows.Forms.Label healthText;
        private System.Windows.Forms.Label healthLable;
        private System.Windows.Forms.Label manaText;
        private System.Windows.Forms.Label manaLable;
        private System.Windows.Forms.Label staminaText;
        private System.Windows.Forms.Label staminaLable;
        private System.Windows.Forms.Button storm;
        private System.Windows.Forms.Button tide;
        private System.Windows.Forms.Button tremour;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button firePathButton;
        private System.Windows.Forms.Button icePathButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button kingButton;
        private System.Windows.Forms.Label s1;
        private System.Windows.Forms.Button replayButton;
    }
}

