
namespace DemoGritLogin
{
    partial class DietControl
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
            this.lblTestname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTestname
            // 
            this.lblTestname.AutoSize = true;
            this.lblTestname.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestname.Location = new System.Drawing.Point(478, 418);
            this.lblTestname.Name = "lblTestname";
            this.lblTestname.Size = new System.Drawing.Size(332, 108);
            this.lblTestname.TabIndex = 0;
            this.lblTestname.Text = "default";
            // 
            // DietControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTestname);
            this.Name = "DietControl";
            this.Size = new System.Drawing.Size(1766, 1092);
            this.Load += new System.EventHandler(this.DietControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestname;
    }
}
