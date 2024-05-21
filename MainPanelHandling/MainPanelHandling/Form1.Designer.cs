namespace MainPanelHandling
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
            panel1 = new Panel();
            btnHome = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            panelContainer = new Panel();
            btnEatin = new Button();
            btnCollection = new Button();
            btnDelivery = new Button();
            btnTakeAway = new Button();
            btnDriverPayment = new Button();
            btnCustomers = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnDriverPayment);
            panel1.Controls.Add(btnTakeAway);
            panel1.Controls.Add(btnDelivery);
            panel1.Controls.Add(btnCollection);
            panel1.Controls.Add(btnEatin);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ActiveCaptionText;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.Cornsilk;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(3, 57);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(163, 38);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnDashBoard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlText;
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(163, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(637, 41);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ActiveCaptionText;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Cornsilk;
            btnClose.Location = new Point(608, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(26, 38);
            btnClose.TabIndex = 5;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(163, 41);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(637, 409);
            panelContainer.TabIndex = 2;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // btnEatin
            // 
            btnEatin.BackColor = SystemColors.ActiveCaptionText;
            btnEatin.FlatStyle = FlatStyle.Popup;
            btnEatin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEatin.ForeColor = Color.Cornsilk;
            btnEatin.Location = new Point(3, 101);
            btnEatin.Name = "btnEatin";
            btnEatin.Size = new Size(163, 38);
            btnEatin.TabIndex = 3;
            btnEatin.Text = "Eat-in";
            btnEatin.UseVisualStyleBackColor = false;
            // 
            // btnCollection
            // 
            btnCollection.BackColor = SystemColors.ActiveCaptionText;
            btnCollection.FlatStyle = FlatStyle.Popup;
            btnCollection.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCollection.ForeColor = Color.Cornsilk;
            btnCollection.Location = new Point(3, 145);
            btnCollection.Name = "btnCollection";
            btnCollection.Size = new Size(163, 38);
            btnCollection.TabIndex = 4;
            btnCollection.Text = "Collection";
            btnCollection.UseVisualStyleBackColor = false;
            // 
            // btnDelivery
            // 
            btnDelivery.BackColor = SystemColors.ActiveCaptionText;
            btnDelivery.FlatStyle = FlatStyle.Popup;
            btnDelivery.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelivery.ForeColor = Color.Cornsilk;
            btnDelivery.Location = new Point(3, 189);
            btnDelivery.Name = "btnDelivery";
            btnDelivery.Size = new Size(163, 38);
            btnDelivery.TabIndex = 5;
            btnDelivery.Text = "Delivery";
            btnDelivery.UseVisualStyleBackColor = false;
            // 
            // btnTakeAway
            // 
            btnTakeAway.BackColor = SystemColors.ActiveCaptionText;
            btnTakeAway.FlatStyle = FlatStyle.Popup;
            btnTakeAway.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTakeAway.ForeColor = Color.Cornsilk;
            btnTakeAway.Location = new Point(3, 233);
            btnTakeAway.Name = "btnTakeAway";
            btnTakeAway.Size = new Size(163, 38);
            btnTakeAway.TabIndex = 6;
            btnTakeAway.Text = "Take Away";
            btnTakeAway.UseVisualStyleBackColor = false;
            // 
            // btnDriverPayment
            // 
            btnDriverPayment.BackColor = SystemColors.ActiveCaptionText;
            btnDriverPayment.FlatStyle = FlatStyle.Popup;
            btnDriverPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDriverPayment.ForeColor = Color.Cornsilk;
            btnDriverPayment.Location = new Point(3, 277);
            btnDriverPayment.Name = "btnDriverPayment";
            btnDriverPayment.Size = new Size(163, 38);
            btnDriverPayment.TabIndex = 7;
            btnDriverPayment.Text = "Driver Payment";
            btnDriverPayment.UseVisualStyleBackColor = false;
            btnDriverPayment.Click += button5_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = SystemColors.ActiveCaptionText;
            btnCustomers.FlatStyle = FlatStyle.Popup;
            btnCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.Cornsilk;
            btnCustomers.Location = new Point(3, 321);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(163, 38);
            btnCustomers.TabIndex = 8;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnHome;
        private Button btnClose;
        private Panel panelContainer;
        private Button btnDriverPayment;
        private Button btnTakeAway;
        private Button btnDelivery;
        private Button btnCollection;
        private Button btnEatin;
        private Button btnCustomers;
    }
}
