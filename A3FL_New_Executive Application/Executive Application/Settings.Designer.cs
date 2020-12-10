namespace Executive_Application
{
    partial class Settings
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.radExecutive = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radExecutiveTS = new System.Windows.Forms.RadioButton();
            this.radChief = new System.Windows.Forms.RadioButton();
            this.radCustom = new System.Windows.Forms.RadioButton();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.radSubDirector = new System.Windows.Forms.RadioButton();
            this.radDirector = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(17, 50);
            this.txtName.MaxLength = 32;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(392, 30);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Your Name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(152, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(257, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Crimson;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(17, 320);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 33);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // radExecutive
            // 
            this.radExecutive.AutoSize = true;
            this.radExecutive.Checked = true;
            this.radExecutive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radExecutive.ForeColor = System.Drawing.Color.White;
            this.radExecutive.Location = new System.Drawing.Point(17, 130);
            this.radExecutive.Name = "radExecutive";
            this.radExecutive.Size = new System.Drawing.Size(139, 24);
            this.radExecutive.TabIndex = 6;
            this.radExecutive.TabStop = true;
            this.radExecutive.Text = "Executive Team";
            this.radExecutive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Staff Rank";
            // 
            // radExecutiveTS
            // 
            this.radExecutiveTS.AutoSize = true;
            this.radExecutiveTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radExecutiveTS.ForeColor = System.Drawing.Color.White;
            this.radExecutiveTS.Location = new System.Drawing.Point(17, 160);
            this.radExecutiveTS.Name = "radExecutiveTS";
            this.radExecutiveTS.Size = new System.Drawing.Size(218, 24);
            this.radExecutiveTS.TabIndex = 8;
            this.radExecutiveTS.Text = "Executive Team Supervisor";
            this.radExecutiveTS.UseVisualStyleBackColor = true;
            // 
            // radChief
            // 
            this.radChief.AutoSize = true;
            this.radChief.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChief.ForeColor = System.Drawing.Color.White;
            this.radChief.Location = new System.Drawing.Point(17, 190);
            this.radChief.Name = "radChief";
            this.radChief.Size = new System.Drawing.Size(162, 24);
            this.radChief.TabIndex = 9;
            this.radChief.Text = "Chiefs Commission";
            this.radChief.UseVisualStyleBackColor = true;
            // 
            // radCustom
            // 
            this.radCustom.AutoSize = true;
            this.radCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCustom.ForeColor = System.Drawing.Color.White;
            this.radCustom.Location = new System.Drawing.Point(17, 280);
            this.radCustom.Name = "radCustom";
            this.radCustom.Size = new System.Drawing.Size(82, 24);
            this.radCustom.TabIndex = 10;
            this.radCustom.Text = "Custom";
            this.radCustom.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(105, 281);
            this.txtTitle.MaxLength = 100;
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(304, 25);
            this.txtTitle.TabIndex = 11;
            this.txtTitle.Text = "Custom Title";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitle_KeyPress);
            // 
            // radSubDirector
            // 
            this.radSubDirector.AutoSize = true;
            this.radSubDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSubDirector.ForeColor = System.Drawing.Color.White;
            this.radSubDirector.Location = new System.Drawing.Point(17, 220);
            this.radSubDirector.Name = "radSubDirector";
            this.radSubDirector.Size = new System.Drawing.Size(117, 24);
            this.radSubDirector.TabIndex = 12;
            this.radSubDirector.Text = "Sub-Director";
            this.radSubDirector.UseVisualStyleBackColor = true;
            // 
            // radDirector
            // 
            this.radDirector.AutoSize = true;
            this.radDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDirector.ForeColor = System.Drawing.Color.White;
            this.radDirector.Location = new System.Drawing.Point(17, 250);
            this.radDirector.Name = "radDirector";
            this.radDirector.Size = new System.Drawing.Size(83, 24);
            this.radDirector.TabIndex = 13;
            this.radDirector.Text = "Director";
            this.radDirector.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(418, 367);
            this.Controls.Add(this.radDirector);
            this.Controls.Add(this.radSubDirector);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.radCustom);
            this.Controls.Add(this.radChief);
            this.Controls.Add(this.radExecutiveTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radExecutive);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "ArmA 3 Fishers Life: Executive Client | Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton radExecutive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radExecutiveTS;
        private System.Windows.Forms.RadioButton radChief;
        private System.Windows.Forms.RadioButton radCustom;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RadioButton radSubDirector;
        private System.Windows.Forms.RadioButton radDirector;
    }
}