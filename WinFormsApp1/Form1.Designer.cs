namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            lblResult = new Label();
            btnValidate = new Button();
            txtPostalCode = new TextBox();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            lblPostalCode = new Label();
            lblAddress = new Label();
            lblPassword = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblName = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            btnParseCV = new Button();
            rtxtCVOutput = new RichTextBox();
            rtxtCVInput = new RichTextBox();
            errorProvider1 = new ErrorProvider(components);
            btnSaveCV = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(btnValidate);
            groupBox1.Controls.Add(txtPostalCode);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lblPostalCode);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 579);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manual Entry Section";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(29, 527);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 13;
            lblResult.Text = "label7";
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(29, 484);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(151, 29);
            btnValidate.TabIndex = 12;
            btnValidate.Text = "Data Verification";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += BtnValidate_Click;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(29, 432);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(211, 27);
            txtPostalCode.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(29, 362);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(211, 27);
            txtAddress.TabIndex = 10;
            txtAddress.TextChanged += textBox5_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(29, 288);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(29, 211);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(211, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(29, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(29, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(211, 27);
            txtName.TabIndex = 6;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(29, 409);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(87, 20);
            lblPostalCode.TabIndex = 5;
            lblPostalCode.Text = "Postal Code";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(29, 339);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(29, 265);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(29, 188);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(77, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone No.";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(29, 111);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(29, 42);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSaveCV);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnParseCV);
            groupBox2.Controls.Add(rtxtCVOutput);
            groupBox2.Controls.Add(rtxtCVInput);
            groupBox2.Location = new Point(403, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(375, 579);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "CV Text Parsing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 295);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Result";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 67);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 3;
            label1.Text = "Paste CV Text";
            // 
            // btnParseCV
            // 
            btnParseCV.Location = new Point(6, 239);
            btnParseCV.Name = "btnParseCV";
            btnParseCV.Size = new Size(118, 29);
            btnParseCV.TabIndex = 2;
            btnParseCV.Text = "Parse CV";
            btnParseCV.UseVisualStyleBackColor = true;
            btnParseCV.Click += btnParseCV_Click;
            // 
            // rtxtCVOutput
            // 
            rtxtCVOutput.Location = new Point(0, 318);
            rtxtCVOutput.Name = "rtxtCVOutput";
            rtxtCVOutput.Size = new Size(363, 133);
            rtxtCVOutput.TabIndex = 1;
            rtxtCVOutput.Text = "";
            rtxtCVOutput.TextChanged += richTextBox2_TextChanged;
            // 
            // rtxtCVInput
            // 
            rtxtCVInput.Location = new Point(6, 90);
            rtxtCVInput.Name = "rtxtCVInput";
            rtxtCVInput.Size = new Size(363, 133);
            rtxtCVInput.TabIndex = 0;
            rtxtCVInput.Text = "";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSaveCV
            // 
            btnSaveCV.Location = new Point(12, 469);
            btnSaveCV.Name = "btnSaveCV";
            btnSaveCV.Size = new Size(134, 29);
            btnSaveCV.TabIndex = 5;
            btnSaveCV.Text = "Save CV Data";
            btnSaveCV.UseVisualStyleBackColor = true;
            btnSaveCV.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 603);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblResult;
        private Button btnValidate;
        private TextBox txtPostalCode;
        private TextBox txtAddress;
        private TextBox txtPassword;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label lblPostalCode;
        private Label lblAddress;
        private Label lblPassword;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblName;
        private GroupBox groupBox2;
        private ErrorProvider errorProvider1;
        private Button btnParseCV;
        private RichTextBox rtxtCVOutput;
        private RichTextBox rtxtCVInput;
        private Label label2;
        private Label label1;
        private Button btnSaveCV;
    }
}
