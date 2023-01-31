namespace Asikisi1._1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lbllName = new System.Windows.Forms.Label();
            this.lblfName = new System.Windows.Forms.Label();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtPlaceholder = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPlaceholder);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lbllName);
            this.panel1.Controls.Add(this.lblfName);
            this.panel1.Controls.Add(this.txtlName);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.txtfName);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 447);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(500, 57);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(225, 202);
            this.txtResult.TabIndex = 9;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(308, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 80);
            this.button1.TabIndex = 8;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(30, 243);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 16);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 178);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 16);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Τηλέφωνο";
            // 
            // lbllName
            // 
            this.lbllName.AutoSize = true;
            this.lbllName.Location = new System.Drawing.Point(30, 117);
            this.lbllName.Name = "lbllName";
            this.lbllName.Size = new System.Drawing.Size(61, 16);
            this.lbllName.TabIndex = 5;
            this.lbllName.Text = "Επώνυμο";
            // 
            // lblfName
            // 
            this.lblfName.AutoSize = true;
            this.lblfName.Location = new System.Drawing.Point(30, 60);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(47, 16);
            this.lblfName.TabIndex = 4;
            this.lblfName.Text = "Όνομα";
            // 
            // txtlName
            // 
            this.txtlName.Location = new System.Drawing.Point(106, 114);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(100, 22);
            this.txtlName.TabIndex = 3;
            this.txtlName.TextChanged += new System.EventHandler(this.txtlName_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(106, 175);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(106, 243);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 22);
            this.txtMail.TabIndex = 1;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(106, 57);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(100, 22);
            this.txtfName.TabIndex = 0;
            this.txtfName.TextChanged += new System.EventHandler(this.txtfName_TextChanged);
            // 
            // txtPlaceholder
            // 
            this.txtPlaceholder.Location = new System.Drawing.Point(33, 406);
            this.txtPlaceholder.Name = "txtPlaceholder";
            this.txtPlaceholder.ReadOnly = true;
            this.txtPlaceholder.Size = new System.Drawing.Size(467, 22);
            this.txtPlaceholder.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lbllName;
        private System.Windows.Forms.Label lblfName;
        private System.Windows.Forms.TextBox txtlName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtPlaceholder;
    }
}

