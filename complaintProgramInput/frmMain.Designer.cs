namespace complaintProgramInput
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSlimline = new System.Windows.Forms.CheckBox();
            this.chkTraditonal = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAttention = new System.Windows.Forms.TextBox();
            this.cmbCustSupplier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAccRef = new System.Windows.Forms.Label();
            this.cmbAccRef = new System.Windows.Forms.ComboBox();
            this.grpCustSupplier = new System.Windows.Forms.GroupBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.panelCust = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoorNum = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.btn_attachments = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpCustSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(118, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Log New Complaint";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSlimline);
            this.groupBox1.Controls.Add(this.chkTraditonal);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(98, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Traditional/Slimline";
            // 
            // chkSlimline
            // 
            this.chkSlimline.AutoSize = true;
            this.chkSlimline.Location = new System.Drawing.Point(98, 30);
            this.chkSlimline.Name = "chkSlimline";
            this.chkSlimline.Size = new System.Drawing.Size(61, 17);
            this.chkSlimline.TabIndex = 1;
            this.chkSlimline.Text = "Slimline";
            this.chkSlimline.UseVisualStyleBackColor = true;
            this.chkSlimline.CheckedChanged += new System.EventHandler(this.chkSlimline_CheckedChanged);
            // 
            // chkTraditonal
            // 
            this.chkTraditonal.AutoSize = true;
            this.chkTraditonal.Location = new System.Drawing.Point(6, 30);
            this.chkTraditonal.Name = "chkTraditonal";
            this.chkTraditonal.Size = new System.Drawing.Size(75, 17);
            this.chkTraditonal.TabIndex = 0;
            this.chkTraditonal.Text = "Traditional";
            this.chkTraditonal.UseVisualStyleBackColor = true;
            this.chkTraditonal.CheckedChanged += new System.EventHandler(this.chkTraditonal_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.ForeColor = System.Drawing.Color.DarkSalmon;
            this.panel3.Location = new System.Drawing.Point(5, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(77, 19);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkRed;
            this.panel4.ForeColor = System.Drawing.Color.DarkSalmon;
            this.panel4.Location = new System.Drawing.Point(97, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(63, 19);
            this.panel4.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "For attention of:";
            // 
            // txtAttention
            // 
            this.txtAttention.Enabled = false;
            this.txtAttention.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttention.Location = new System.Drawing.Point(122, 49);
            this.txtAttention.Name = "txtAttention";
            this.txtAttention.Size = new System.Drawing.Size(149, 22);
            this.txtAttention.TabIndex = 4;
            // 
            // cmbCustSupplier
            // 
            this.cmbCustSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCustSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustSupplier.FormattingEnabled = true;
            this.cmbCustSupplier.Location = new System.Drawing.Point(130, 28);
            this.cmbCustSupplier.Name = "cmbCustSupplier";
            this.cmbCustSupplier.Size = new System.Drawing.Size(149, 21);
            this.cmbCustSupplier.TabIndex = 2;
            this.cmbCustSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbCustSupplier_SelectedIndexChanged);
            this.cmbCustSupplier.TextChanged += new System.EventHandler(this.cmbCustSupplier_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer/Supplier";
            // 
            // lblAccRef
            // 
            this.lblAccRef.AutoSize = true;
            this.lblAccRef.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccRef.Location = new System.Drawing.Point(9, 67);
            this.lblAccRef.Name = "lblAccRef";
            this.lblAccRef.Size = new System.Drawing.Size(58, 14);
            this.lblAccRef.TabIndex = 9;
            this.lblAccRef.Text = "Customer";
            this.lblAccRef.Visible = false;
            // 
            // cmbAccRef
            // 
            this.cmbAccRef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAccRef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccRef.FormattingEnabled = true;
            this.cmbAccRef.Location = new System.Drawing.Point(68, 67);
            this.cmbAccRef.Name = "cmbAccRef";
            this.cmbAccRef.Size = new System.Drawing.Size(235, 21);
            this.cmbAccRef.TabIndex = 3;
            this.cmbAccRef.Visible = false;
            // 
            // grpCustSupplier
            // 
            this.grpCustSupplier.Controls.Add(this.lblTel);
            this.grpCustSupplier.Controls.Add(this.txtTel);
            this.grpCustSupplier.Controls.Add(this.lblContact);
            this.grpCustSupplier.Controls.Add(this.txtContact);
            this.grpCustSupplier.Controls.Add(this.label2);
            this.grpCustSupplier.Controls.Add(this.lblAccRef);
            this.grpCustSupplier.Controls.Add(this.cmbCustSupplier);
            this.grpCustSupplier.Controls.Add(this.cmbAccRef);
            this.grpCustSupplier.Controls.Add(this.panelCust);
            this.grpCustSupplier.Location = new System.Drawing.Point(29, 198);
            this.grpCustSupplier.Name = "grpCustSupplier";
            this.grpCustSupplier.Size = new System.Drawing.Size(309, 173);
            this.grpCustSupplier.TabIndex = 2;
            this.grpCustSupplier.TabStop = false;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(42, 136);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(80, 14);
            this.lblTel.TabIndex = 15;
            this.lblTel.Text = "Customer Tel:";
            this.lblTel.Visible = false;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(130, 133);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(149, 22);
            this.txtTel.TabIndex = 5;
            this.txtTel.Visible = false;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(26, 108);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(101, 14);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Customer Contact";
            this.lblContact.Visible = false;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(130, 105);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(149, 22);
            this.txtContact.TabIndex = 4;
            this.txtContact.Visible = false;
            // 
            // panelCust
            // 
            this.panelCust.BackColor = System.Drawing.Color.DarkRed;
            this.panelCust.ForeColor = System.Drawing.Color.DarkSalmon;
            this.panelCust.Location = new System.Drawing.Point(67, 66);
            this.panelCust.Name = "panelCust";
            this.panelCust.Size = new System.Drawing.Size(237, 23);
            this.panelCust.TabIndex = 21;
            this.panelCust.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Door Number";
            // 
            // txtDoorNum
            // 
            this.txtDoorNum.Enabled = false;
            this.txtDoorNum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoorNum.Location = new System.Drawing.Point(122, 164);
            this.txtDoorNum.Name = "txtDoorNum";
            this.txtDoorNum.Size = new System.Drawing.Size(149, 22);
            this.txtDoorNum.TabIndex = 1;
            this.txtDoorNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoorNum_KeyPress);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(14, 385);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(128, 14);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Complaint Description";
            this.lblDescription.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(16, 402);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(335, 111);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Text = "";
            this.txtDescription.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(121, 528);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(122, 34);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create Complaint";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panelDescription
            // 
            this.panelDescription.BackColor = System.Drawing.Color.DarkRed;
            this.panelDescription.ForeColor = System.Drawing.Color.DarkRed;
            this.panelDescription.Location = new System.Drawing.Point(15, 401);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(337, 113);
            this.panelDescription.TabIndex = 20;
            this.panelDescription.Visible = false;
            // 
            // btn_attachments
            // 
            this.btn_attachments.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attachments.Location = new System.Drawing.Point(34, 528);
            this.btn_attachments.Name = "btn_attachments";
            this.btn_attachments.Size = new System.Drawing.Size(122, 34);
            this.btn_attachments.TabIndex = 21;
            this.btn_attachments.Text = "Add Attachments";
            this.btn_attachments.UseVisualStyleBackColor = true;
            this.btn_attachments.Visible = false;
            this.btn_attachments.Click += new System.EventHandler(this.btn_attachments_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 579);
            this.Controls.Add(this.btn_attachments);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.panelDescription);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDoorNum);
            this.Controls.Add(this.grpCustSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAttention);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a Complaint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCustSupplier.ResumeLayout(false);
            this.grpCustSupplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSlimline;
        private System.Windows.Forms.CheckBox chkTraditonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAttention;
        private System.Windows.Forms.ComboBox cmbCustSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccRef;
        private System.Windows.Forms.ComboBox cmbAccRef;
        private System.Windows.Forms.GroupBox grpCustSupplier;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoorNum;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelCust;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Button btn_attachments;
    }
}