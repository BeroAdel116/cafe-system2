namespace cafe_system
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PlaceOrder = new System.Windows.Forms.Button();
            this.UpdateIteams = new System.Windows.Forms.Button();
            this.AddIteams = new System.Windows.Forms.Button();
            this.RemoveIteams = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.RemoveIteams);
            this.panel1.Controls.Add(this.AddIteams);
            this.panel1.Controls.Add(this.UpdateIteams);
            this.panel1.Controls.Add(this.PlaceOrder);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(208, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 1;
            // 
            // PlaceOrder
            // 
            this.PlaceOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.PlaceOrder.BackColor = System.Drawing.Color.DodgerBlue;
            this.PlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaceOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlaceOrder.Location = new System.Drawing.Point(33, 47);
            this.PlaceOrder.Name = "PlaceOrder";
            this.PlaceOrder.Size = new System.Drawing.Size(202, 41);
            this.PlaceOrder.TabIndex = 0;
            this.PlaceOrder.Text = "Place Order";
            this.PlaceOrder.UseVisualStyleBackColor = false;
            this.PlaceOrder.Click += new System.EventHandler(this.PlaceOrder_Click);
            // 
            // UpdateIteams
            // 
            this.UpdateIteams.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.UpdateIteams.BackColor = System.Drawing.Color.DodgerBlue;
            this.UpdateIteams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateIteams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateIteams.Location = new System.Drawing.Point(33, 176);
            this.UpdateIteams.Name = "UpdateIteams";
            this.UpdateIteams.Size = new System.Drawing.Size(202, 41);
            this.UpdateIteams.TabIndex = 1;
            this.UpdateIteams.Text = "Update Iteams";
            this.UpdateIteams.UseVisualStyleBackColor = false;
            this.UpdateIteams.Click += new System.EventHandler(this.UpdateIteams_Click);
            // 
            // AddIteams
            // 
            this.AddIteams.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.AddIteams.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddIteams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIteams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddIteams.Location = new System.Drawing.Point(33, 113);
            this.AddIteams.Name = "AddIteams";
            this.AddIteams.Size = new System.Drawing.Size(202, 41);
            this.AddIteams.TabIndex = 2;
            this.AddIteams.Text = "Add Iteams";
            this.AddIteams.UseVisualStyleBackColor = false;
            this.AddIteams.Click += new System.EventHandler(this.AddIteams_Click);
            // 
            // RemoveIteams
            // 
            this.RemoveIteams.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.RemoveIteams.BackColor = System.Drawing.Color.DodgerBlue;
            this.RemoveIteams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveIteams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveIteams.Location = new System.Drawing.Point(33, 243);
            this.RemoveIteams.Name = "RemoveIteams";
            this.RemoveIteams.Size = new System.Drawing.Size(202, 41);
            this.RemoveIteams.TabIndex = 3;
            this.RemoveIteams.Text = "Remove Iteams";
            this.RemoveIteams.UseVisualStyleBackColor = false;
            this.RemoveIteams.Click += new System.EventHandler(this.RemoveIteams_Click);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Red;
            this.X.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.X.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.X.Location = new System.Drawing.Point(0, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(40, 41);
            this.X.TabIndex = 4;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button X;
        private Button RemoveIteams;
        private Button AddIteams;
        private Button UpdateIteams;
        private Button PlaceOrder;
        private Panel panel2;
    }
}