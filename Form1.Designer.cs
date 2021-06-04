
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
            this.SuspendLayout();
            // 
            // bsave
            // 
            this.bsave.Location = new System.Drawing.Point(122, 376);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(427, 459);
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
    }
}

