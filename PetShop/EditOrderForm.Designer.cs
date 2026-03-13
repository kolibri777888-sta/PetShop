
namespace PetShop
{
    partial class EditOrderForm
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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(72, 94);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(151, 21);
            this.cbStatus.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtpDate.Location = new System.Drawing.Point(72, 149);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(151, 51);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.Text = "Сохранить";
            this.dtpDate.UseVisualStyleBackColor = false;
            this.dtpDate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = global::PetShop.Properties.Resources.withpet_shop;
            this.ClientSize = new System.Drawing.Size(289, 255);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbStatus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditOrderForm";
            this.Text = "EditOrderForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button dtpDate;
    }
}