
namespace PetShop
{
    partial class ManagerForm
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
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnZakaz = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.btnOrders.Location = new System.Drawing.Point(87, 287);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(137, 61);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Оформить заказ";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.btnProducts.Location = new System.Drawing.Point(87, 222);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(137, 49);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Товары";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.btnReports.Location = new System.Drawing.Point(87, 158);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(137, 49);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Отчёт";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.btnCheck.Location = new System.Drawing.Point(87, 86);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(137, 49);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Чек";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnZakaz
            // 
            this.btnZakaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnZakaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZakaz.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.btnZakaz.Location = new System.Drawing.Point(87, 23);
            this.btnZakaz.Margin = new System.Windows.Forms.Padding(2);
            this.btnZakaz.Name = "btnZakaz";
            this.btnZakaz.Size = new System.Drawing.Size(137, 49);
            this.btnZakaz.TabIndex = 4;
            this.btnZakaz.Text = "Заказы";
            this.btnZakaz.UseVisualStyleBackColor = false;
            this.btnZakaz.Click += new System.EventHandler(this.btnZakaz_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(377, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = global::PetShop.Properties.Resources.withpet_shop;
            this.ClientSize = new System.Drawing.Size(491, 359);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnZakaz);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnOrders);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnZakaz;
        private System.Windows.Forms.Button btnExit;
    }
}