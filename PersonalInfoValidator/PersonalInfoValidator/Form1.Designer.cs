namespace PersonalInfoValidator
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPersonalNumber = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuRegisterPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResult = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.PersonalNumber = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(168, 49);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 31);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(168, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 31);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Visible = false;
            // 
            // txtPersonalNumber
            // 
            this.txtPersonalNumber.Location = new System.Drawing.Point(168, 153);
            this.txtPersonalNumber.Name = "txtPersonalNumber";
            this.txtPersonalNumber.Size = new System.Drawing.Size(150, 31);
            this.txtPersonalNumber.TabIndex = 2;
            this.txtPersonalNumber.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(494, 242);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 34);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegisterPerson,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuRegisterPerson
            // 
            this.menuRegisterPerson.Name = "menuRegisterPerson";
            this.menuRegisterPerson.Size = new System.Drawing.Size(102, 29);
            this.menuRegisterPerson.Text = "Register";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(57, 29);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblResult.Location = new System.Drawing.Point(125, 235);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(222, 109);
            this.lblResult.TabIndex = 6;
            this.lblResult.Visible = false;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(16, 49);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(95, 25);
            this.FirstName.TabIndex = 7;
            this.FirstName.Text = "First Name";
            this.FirstName.Visible = false;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(16, 106);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(94, 25);
            this.LastName.TabIndex = 8;
            this.LastName.Text = "Last Name";
            this.LastName.Visible = false;
            // 
            // PersonalNumber
            // 
            this.PersonalNumber.AutoSize = true;
            this.PersonalNumber.Location = new System.Drawing.Point(16, 159);
            this.PersonalNumber.Name = "PersonalNumber";
            this.PersonalNumber.Size = new System.Drawing.Size(149, 25);
            this.PersonalNumber.TabIndex = 9;
            this.PersonalNumber.Text = "Personal Number";
            this.PersonalNumber.Visible = false;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.SystemColors.Control;
            this.Result.Location = new System.Drawing.Point(41, 235);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(70, 25);
            this.Result.TabIndex = 10;
            this.Result.Text = "Result:";
            this.Result.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.PersonalNumber);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtPersonalNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPersonalNumber;
        private Button btnCheck;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuRegisterPerson;
        private ToolStripMenuItem menuExit;
        private Label lblResult;
        private Label FirstName;
        private Label LastName;
        private Label PersonalNumber;
        private Label Result;
    }
}
