namespace Order
{
    partial class frmMenu
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.cboSide = new System.Windows.Forms.ComboBox();
            this.cboDessert = new System.Windows.Forms.ComboBox();
            this.txtCookingInstructions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstItem = new System.Windows.Forms.ListBox();
            this.rdoToGo = new System.Windows.Forms.RadioButton();
            this.rdoEatIn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(127, 288);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(208, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Location = new System.Drawing.Point(12, 264);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(111, 17);
            this.chkDefault.TabIndex = 4;
            this.chkDefault.Text = "Save Preferences";
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // cboSide
            // 
            this.cboSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSide.FormattingEnabled = true;
            this.cboSide.Location = new System.Drawing.Point(43, 223);
            this.cboSide.Name = "cboSide";
            this.cboSide.Size = new System.Drawing.Size(121, 21);
            this.cboSide.TabIndex = 2;
            // 
            // cboDessert
            // 
            this.cboDessert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDessert.FormattingEnabled = true;
            this.cboDessert.Location = new System.Drawing.Point(243, 223);
            this.cboDessert.Name = "cboDessert";
            this.cboDessert.Size = new System.Drawing.Size(121, 21);
            this.cboDessert.TabIndex = 3;
            // 
            // txtCookingInstructions
            // 
            this.txtCookingInstructions.Location = new System.Drawing.Point(127, 192);
            this.txtCookingInstructions.Name = "txtCookingInstructions";
            this.txtCookingInstructions.Size = new System.Drawing.Size(237, 20);
            this.txtCookingInstructions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Side";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dessert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item";
            // 
            // lstItem
            // 
            this.lstItem.FormattingEnabled = true;
            this.lstItem.Location = new System.Drawing.Point(98, 50);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(266, 121);
            this.lstItem.TabIndex = 0;
            // 
            // rdoToGo
            // 
            this.rdoToGo.AutoSize = true;
            this.rdoToGo.Checked = true;
            this.rdoToGo.Location = new System.Drawing.Point(127, 12);
            this.rdoToGo.Name = "rdoToGo";
            this.rdoToGo.Size = new System.Drawing.Size(55, 17);
            this.rdoToGo.TabIndex = 10;
            this.rdoToGo.TabStop = true;
            this.rdoToGo.Text = "To Go";
            this.rdoToGo.UseVisualStyleBackColor = true;
            // 
            // rdoEatIn
            // 
            this.rdoEatIn.AutoSize = true;
            this.rdoEatIn.Location = new System.Drawing.Point(208, 12);
            this.rdoEatIn.Name = "rdoEatIn";
            this.rdoEatIn.Size = new System.Drawing.Size(53, 17);
            this.rdoEatIn.TabIndex = 11;
            this.rdoEatIn.TabStop = true;
            this.rdoEatIn.Text = "Eat In";
            this.rdoEatIn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cooking Instructions:";
            // 
            // frmMenu
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(408, 348);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdoEatIn);
            this.Controls.Add(this.rdoToGo);
            this.Controls.Add(this.lstItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCookingInstructions);
            this.Controls.Add(this.cboDessert);
            this.Controls.Add(this.cboSide);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.ComboBox cboSide;
        private System.Windows.Forms.ComboBox cboDessert;
        private System.Windows.Forms.TextBox txtCookingInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstItem;
        private System.Windows.Forms.RadioButton rdoToGo;
        private System.Windows.Forms.RadioButton rdoEatIn;
        private System.Windows.Forms.Label label4;
    }
}