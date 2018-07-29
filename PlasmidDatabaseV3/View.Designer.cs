namespace PlasmidDatabaseV3
{
    partial class View
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
            this.CmdSaveInput = new System.Windows.Forms.Button();
            this.LblPlasmidName = new System.Windows.Forms.Label();
            this.TxtbxPlasmidName = new System.Windows.Forms.TextBox();
            this.LblPlasmidSequence = new System.Windows.Forms.Label();
            this.TxtbxPlasmidSequence = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdSaveInput
            // 
            this.CmdSaveInput.Location = new System.Drawing.Point(50, 186);
            this.CmdSaveInput.Name = "CmdSaveInput";
            this.CmdSaveInput.Size = new System.Drawing.Size(94, 61);
            this.CmdSaveInput.TabIndex = 0;
            this.CmdSaveInput.Text = "Plasmiddaten Speichern";
            this.CmdSaveInput.UseVisualStyleBackColor = true;
            this.CmdSaveInput.Click += new System.EventHandler(this.CmdSaveInput_Click);
            // 
            // LblPlasmidName
            // 
            this.LblPlasmidName.AutoSize = true;
            this.LblPlasmidName.Location = new System.Drawing.Point(47, 67);
            this.LblPlasmidName.Name = "LblPlasmidName";
            this.LblPlasmidName.Size = new System.Drawing.Size(74, 13);
            this.LblPlasmidName.TabIndex = 1;
            this.LblPlasmidName.Text = "Plasmid-Name";
            // 
            // TxtbxPlasmidName
            // 
            this.TxtbxPlasmidName.Location = new System.Drawing.Point(49, 83);
            this.TxtbxPlasmidName.Name = "TxtbxPlasmidName";
            this.TxtbxPlasmidName.Size = new System.Drawing.Size(131, 20);
            this.TxtbxPlasmidName.TabIndex = 2;
            this.TxtbxPlasmidName.TextChanged += new System.EventHandler(this.TxtbxPlasmidName_TextChanged);
            // 
            // LblPlasmidSequence
            // 
            this.LblPlasmidSequence.AutoSize = true;
            this.LblPlasmidSequence.Location = new System.Drawing.Point(46, 123);
            this.LblPlasmidSequence.Name = "LblPlasmidSequence";
            this.LblPlasmidSequence.Size = new System.Drawing.Size(88, 13);
            this.LblPlasmidSequence.TabIndex = 1;
            this.LblPlasmidSequence.Text = "Plasmid-Sequenz";
            // 
            // TxtbxPlasmidSequence
            // 
            this.TxtbxPlasmidSequence.Location = new System.Drawing.Point(49, 139);
            this.TxtbxPlasmidSequence.Name = "TxtbxPlasmidSequence";
            this.TxtbxPlasmidSequence.Size = new System.Drawing.Size(131, 20);
            this.TxtbxPlasmidSequence.TabIndex = 2;
            this.TxtbxPlasmidSequence.TextChanged += new System.EventHandler(this.TxtbxPlasmidSequence_TextChanged);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 266);
            this.Controls.Add(this.TxtbxPlasmidSequence);
            this.Controls.Add(this.TxtbxPlasmidName);
            this.Controls.Add(this.LblPlasmidSequence);
            this.Controls.Add(this.LblPlasmidName);
            this.Controls.Add(this.CmdSaveInput);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSaveInput;
        private System.Windows.Forms.Label LblPlasmidName;
        private System.Windows.Forms.TextBox TxtbxPlasmidName;
        private System.Windows.Forms.Label LblPlasmidSequence;
        private System.Windows.Forms.TextBox TxtbxPlasmidSequence;
    }
}