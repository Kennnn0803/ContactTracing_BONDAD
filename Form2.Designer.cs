
namespace ContactTracing_Bondad
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bshow = new System.Windows.Forms.Button();
            this.tboxshow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bshow
            // 
            this.bshow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bshow.Location = new System.Drawing.Point(112, 26);
            this.bshow.Name = "bshow";
            this.bshow.Size = new System.Drawing.Size(120, 58);
            this.bshow.TabIndex = 0;
            this.bshow.Text = "Read File";
            this.bshow.UseVisualStyleBackColor = true;
            this.bshow.Click += new System.EventHandler(this.bshow_Click);
            // 
            // tboxshow
            // 
            this.tboxshow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tboxshow.Location = new System.Drawing.Point(12, 111);
            this.tboxshow.Multiline = true;
            this.tboxshow.Name = "tboxshow";
            this.tboxshow.Size = new System.Drawing.Size(329, 300);
            this.tboxshow.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 423);
            this.Controls.Add(this.tboxshow);
            this.Controls.Add(this.bshow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bshow;
        private System.Windows.Forms.TextBox tboxshow;
    }
}