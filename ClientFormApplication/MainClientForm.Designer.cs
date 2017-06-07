namespace ClientFormApplication
{
    partial class MainClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainClientForm));
            this.btnSuccessfulConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnCoal = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuccessfulConnect
            // 
            this.btnSuccessfulConnect.Enabled = false;
            this.btnSuccessfulConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccessfulConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSuccessfulConnect.Location = new System.Drawing.Point(432, 12);
            this.btnSuccessfulConnect.Name = "btnSuccessfulConnect";
            this.btnSuccessfulConnect.Size = new System.Drawing.Size(128, 36);
            this.btnSuccessfulConnect.TabIndex = 0;
            this.btnSuccessfulConnect.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(32, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 36);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = global::ClientFormApplication.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenu.Location = new System.Drawing.Point(123, 227);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(170, 153);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnMouseHover);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.btnMaintenance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaintenance.BackgroundImage")));
            this.btnMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaintenance.Location = new System.Drawing.Point(390, 68);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(170, 153);
            this.btnMaintenance.TabIndex = 8;
            this.btnMaintenance.Text = "Maintainence";
            this.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            this.btnMaintenance.MouseEnter += new System.EventHandler(this.btnMouseHover);
            this.btnMaintenance.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.BackgroundImage = global::ClientFormApplication.Properties.Resources.bill;
            this.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBill.Location = new System.Drawing.Point(299, 227);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(170, 153);
            this.btnBill.TabIndex = 7;
            this.btnBill.Text = "Bill";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            this.btnBill.MouseEnter += new System.EventHandler(this.btnMouseHover);
            this.btnBill.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnCall
            // 
            this.btnCall.BackColor = System.Drawing.Color.Transparent;
            this.btnCall.BackgroundImage = global::ClientFormApplication.Properties.Resources.call;
            this.btnCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCall.Location = new System.Drawing.Point(32, 68);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(170, 153);
            this.btnCall.TabIndex = 6;
            this.btnCall.Text = "Call";
            this.btnCall.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCall.UseVisualStyleBackColor = false;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            this.btnCall.MouseEnter += new System.EventHandler(this.btnMouseHover);
            this.btnCall.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnCoal
            // 
            this.btnCoal.BackColor = System.Drawing.Color.Transparent;
            this.btnCoal.BackgroundImage = global::ClientFormApplication.Properties.Resources.coal;
            this.btnCoal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCoal.Location = new System.Drawing.Point(214, 68);
            this.btnCoal.Name = "btnCoal";
            this.btnCoal.Size = new System.Drawing.Size(170, 153);
            this.btnCoal.TabIndex = 12;
            this.btnCoal.Text = "Coal";
            this.btnCoal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCoal.UseVisualStyleBackColor = false;
            this.btnCoal.Click += new System.EventHandler(this.btnCoal_Click);
            this.btnCoal.MouseEnter += new System.EventHandler(this.btnMouseHover);
            this.btnCoal.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::ClientFormApplication.Properties.Resources.logo;
            this.pbxLogo.Location = new System.Drawing.Point(250, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(100, 50);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 13;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainClientForm_MouseDown);
            // 
            // MainClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 399);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnCoal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnSuccessfulConnect);
            this.Controls.Add(this.btnCall);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(593, 399);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(593, 399);
            this.Name = "MainClientForm";
            this.Text = "OptiShisha Client Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainClientForm_FormClosing);
            this.Load += new System.EventHandler(this.MainClientForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainClientForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuccessfulConnect;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCoal;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}

