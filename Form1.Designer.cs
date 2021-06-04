
namespace ContactTracing_Bondad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lage = new System.Windows.Forms.Label();
            this.tbage = new System.Windows.Forms.TextBox();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.laddress = new System.Windows.Forms.Label();
            this.lnumber = new System.Windows.Forms.Label();
            this.tbnumber = new System.Windows.Forms.TextBox();
            this.lgender = new System.Windows.Forms.Label();
            this.cbmale = new System.Windows.Forms.CheckBox();
            this.cbfemale = new System.Windows.Forms.CheckBox();
            this.cbpref = new System.Windows.Forms.CheckBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.lblast = new System.Windows.Forms.Label();
            this.cbyes = new System.Windows.Forms.CheckBox();
            this.cbno = new System.Windows.Forms.CheckBox();
            this.bopen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bsave
            // 
            this.bsave.Location = new System.Drawing.Point(19, 441);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(185, 55);
            this.bsave.TabIndex = 0;
            this.bsave.Text = "Save to File";
            this.bsave.UseVisualStyleBackColor = true;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Candara", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "  Contact Tracing Form";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(19, 104);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(55, 20);
            this.lname.TabIndex = 2;
            this.lname.Text = "Name:";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(99, 101);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(299, 28);
            this.tbname.TabIndex = 3;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // lage
            // 
            this.lage.AutoSize = true;
            this.lage.Location = new System.Drawing.Point(19, 142);
            this.lage.Name = "lage";
            this.lage.Size = new System.Drawing.Size(40, 20);
            this.lage.TabIndex = 4;
            this.lage.Text = "Age:";
            // 
            // tbage
            // 
            this.tbage.Location = new System.Drawing.Point(99, 139);
            this.tbage.Name = "tbage";
            this.tbage.Size = new System.Drawing.Size(299, 28);
            this.tbage.TabIndex = 5;
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(99, 180);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(299, 28);
            this.tbaddress.TabIndex = 6;
            // 
            // laddress
            // 
            this.laddress.AutoSize = true;
            this.laddress.Location = new System.Drawing.Point(19, 183);
            this.laddress.Name = "laddress";
            this.laddress.Size = new System.Drawing.Size(67, 20);
            this.laddress.TabIndex = 7;
            this.laddress.Text = "Address:";
            // 
            // lnumber
            // 
            this.lnumber.AutoSize = true;
            this.lnumber.Location = new System.Drawing.Point(19, 222);
            this.lnumber.Name = "lnumber";
            this.lnumber.Size = new System.Drawing.Size(70, 20);
            this.lnumber.TabIndex = 8;
            this.lnumber.Text = "Number:";
            // 
            // tbnumber
            // 
            this.tbnumber.Location = new System.Drawing.Point(99, 219);
            this.tbnumber.Name = "tbnumber";
            this.tbnumber.Size = new System.Drawing.Size(299, 28);
            this.tbnumber.TabIndex = 9;
            // 
            // lgender
            // 
            this.lgender.AutoSize = true;
            this.lgender.Location = new System.Drawing.Point(19, 260);
            this.lgender.Name = "lgender";
            this.lgender.Size = new System.Drawing.Size(63, 20);
            this.lgender.TabIndex = 10;
            this.lgender.Text = "Gender:";
            // 
            // cbmale
            // 
            this.cbmale.AutoSize = true;
            this.cbmale.Location = new System.Drawing.Point(99, 260);
            this.cbmale.Name = "cbmale";
            this.cbmale.Size = new System.Drawing.Size(65, 24);
            this.cbmale.TabIndex = 11;
            this.cbmale.Text = "Male";
            this.cbmale.UseVisualStyleBackColor = true;
            // 
            // cbfemale
            // 
            this.cbfemale.AutoSize = true;
            this.cbfemale.Location = new System.Drawing.Point(180, 260);
            this.cbfemale.Name = "cbfemale";
            this.cbfemale.Size = new System.Drawing.Size(81, 24);
            this.cbfemale.TabIndex = 12;
            this.cbfemale.Text = "Female";
            this.cbfemale.UseVisualStyleBackColor = true;
            // 
            // cbpref
            // 
            this.cbpref.AutoSize = true;
            this.cbpref.Location = new System.Drawing.Point(267, 259);
            this.cbpref.Name = "cbpref";
            this.cbpref.Size = new System.Drawing.Size(151, 24);
            this.cbpref.TabIndex = 13;
            this.cbpref.Text = "Prefer Not To Say";
            this.cbpref.UseVisualStyleBackColor = true;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(19, 297);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(51, 20);
            this.lbemail.TabIndex = 14;
            this.lbemail.Text = "Email:";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(99, 294);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(299, 28);
            this.tbemail.TabIndex = 15;
            // 
            // lblast
            // 
            this.lblast.Location = new System.Drawing.Point(19, 349);
            this.lblast.Name = "lblast";
            this.lblast.Size = new System.Drawing.Size(220, 45);
            this.lblast.TabIndex = 16;
            this.lblast.Text = "Had COVID 19 symptoms for the past 14 days?";
            // 
            // cbyes
            // 
            this.cbyes.AutoSize = true;
            this.cbyes.Location = new System.Drawing.Point(234, 370);
            this.cbyes.Name = "cbyes";
            this.cbyes.Size = new System.Drawing.Size(54, 24);
            this.cbyes.TabIndex = 17;
            this.cbyes.Text = "Yes";
            this.cbyes.UseVisualStyleBackColor = true;
            // 
            // cbno
            // 
            this.cbno.AutoSize = true;
            this.cbno.Location = new System.Drawing.Point(320, 370);
            this.cbno.Name = "cbno";
            this.cbno.Size = new System.Drawing.Size(51, 24);
            this.cbno.TabIndex = 18;
            this.cbno.Text = "No";
            this.cbno.UseVisualStyleBackColor = true;
            // 
            // bopen
            // 
            this.bopen.Location = new System.Drawing.Point(213, 441);
            this.bopen.Name = "bopen";
            this.bopen.Size = new System.Drawing.Size(185, 55);
            this.bopen.TabIndex = 19;
            this.bopen.Text = "Open File";
            this.bopen.UseVisualStyleBackColor = true;
            this.bopen.Click += new System.EventHandler(this.bopen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 508);
            this.Controls.Add(this.bopen);
            this.Controls.Add(this.cbno);
            this.Controls.Add(this.cbyes);
            this.Controls.Add(this.lblast);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.cbpref);
            this.Controls.Add(this.cbfemale);
            this.Controls.Add(this.cbmale);
            this.Controls.Add(this.lgender);
            this.Controls.Add(this.tbnumber);
            this.Controls.Add(this.lnumber);
            this.Controls.Add(this.laddress);
            this.Controls.Add(this.tbaddress);
            this.Controls.Add(this.tbage);
            this.Controls.Add(this.lage);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bsave);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Contact Tracing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lage;
        private System.Windows.Forms.TextBox tbage;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.Label laddress;
        private System.Windows.Forms.Label lnumber;
        private System.Windows.Forms.TextBox tbnumber;
        private System.Windows.Forms.Label lgender;
        private System.Windows.Forms.CheckBox cbmale;
        private System.Windows.Forms.CheckBox cbfemale;
        private System.Windows.Forms.CheckBox cbpref;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label lblast;
        private System.Windows.Forms.CheckBox cbyes;
        private System.Windows.Forms.CheckBox cbno;
        private System.Windows.Forms.Button bopen;
    }
}

