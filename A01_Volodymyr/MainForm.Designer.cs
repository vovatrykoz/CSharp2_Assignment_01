namespace A01_Volodymyr
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAnimals = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkEndangered = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSpec3 = new System.Windows.Forms.TextBox();
            this.lblSpec3 = new System.Windows.Forms.Label();
            this.txtSpec2 = new System.Windows.Forms.TextBox();
            this.txtSpec1 = new System.Windows.Forms.TextBox();
            this.lblSpec2 = new System.Windows.Forms.Label();
            this.lblSpec1 = new System.Windows.Forms.Label();
            this.lstObjects = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.lstGender = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBox);
            this.groupBox1.Controls.Add(this.btnImage);
            this.groupBox1.Controls.Add(this.lblImage);
            this.groupBox1.Controls.Add(this.chkAnimals);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.chkEndangered);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lstObjects);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lstCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grpGender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Specification";
            // 
            // chkAnimals
            // 
            this.chkAnimals.AutoSize = true;
            this.chkAnimals.Location = new System.Drawing.Point(356, 237);
            this.chkAnimals.Name = "chkAnimals";
            this.chkAnimals.Size = new System.Drawing.Size(93, 17);
            this.chkAnimals.TabIndex = 12;
            this.chkAnimals.Text = "List all animals";
            this.chkAnimals.UseVisualStyleBackColor = true;
            this.chkAnimals.CheckedChanged += new System.EventHandler(this.chkAnimals_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(356, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 50);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkEndangered
            // 
            this.chkEndangered.AutoSize = true;
            this.chkEndangered.Location = new System.Drawing.Point(15, 236);
            this.chkEndangered.Name = "chkEndangered";
            this.chkEndangered.Size = new System.Drawing.Size(84, 17);
            this.chkEndangered.TabIndex = 10;
            this.chkEndangered.Text = "Endangered";
            this.chkEndangered.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSpec3);
            this.groupBox2.Controls.Add(this.lblSpec3);
            this.groupBox2.Controls.Add(this.txtSpec2);
            this.groupBox2.Controls.Add(this.txtSpec1);
            this.groupBox2.Controls.Add(this.lblSpec2);
            this.groupBox2.Controls.Add(this.lblSpec1);
            this.groupBox2.Location = new System.Drawing.Point(9, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 152);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chosen Animal Specifications";
            // 
            // txtSpec3
            // 
            this.txtSpec3.Location = new System.Drawing.Point(209, 112);
            this.txtSpec3.Name = "txtSpec3";
            this.txtSpec3.Size = new System.Drawing.Size(114, 20);
            this.txtSpec3.TabIndex = 5;
            // 
            // lblSpec3
            // 
            this.lblSpec3.AutoSize = true;
            this.lblSpec3.Location = new System.Drawing.Point(6, 112);
            this.lblSpec3.Name = "lblSpec3";
            this.lblSpec3.Size = new System.Drawing.Size(77, 13);
            this.lblSpec3.TabIndex = 4;
            this.lblSpec3.Text = "Specification 3";
            // 
            // txtSpec2
            // 
            this.txtSpec2.Location = new System.Drawing.Point(210, 71);
            this.txtSpec2.Name = "txtSpec2";
            this.txtSpec2.Size = new System.Drawing.Size(114, 20);
            this.txtSpec2.TabIndex = 3;
            // 
            // txtSpec1
            // 
            this.txtSpec1.Location = new System.Drawing.Point(210, 30);
            this.txtSpec1.Name = "txtSpec1";
            this.txtSpec1.Size = new System.Drawing.Size(114, 20);
            this.txtSpec1.TabIndex = 2;
            // 
            // lblSpec2
            // 
            this.lblSpec2.AutoSize = true;
            this.lblSpec2.Location = new System.Drawing.Point(7, 71);
            this.lblSpec2.Name = "lblSpec2";
            this.lblSpec2.Size = new System.Drawing.Size(77, 13);
            this.lblSpec2.TabIndex = 1;
            this.lblSpec2.Text = "Specification 2";
            // 
            // lblSpec1
            // 
            this.lblSpec1.AutoSize = true;
            this.lblSpec1.Location = new System.Drawing.Point(7, 30);
            this.lblSpec1.Name = "lblSpec1";
            this.lblSpec1.Size = new System.Drawing.Size(77, 13);
            this.lblSpec1.TabIndex = 0;
            this.lblSpec1.Text = "Specification 1";
            // 
            // lstObjects
            // 
            this.lstObjects.FormattingEnabled = true;
            this.lstObjects.Location = new System.Drawing.Point(356, 57);
            this.lstObjects.Name = "lstObjects";
            this.lstObjects.Size = new System.Drawing.Size(120, 173);
            this.lstObjects.TabIndex = 8;
            this.lstObjects.SelectedIndexChanged += new System.EventHandler(this.lstObjects_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Animal Objects";
            // 
            // lstCategory
            // 
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.Location = new System.Drawing.Point(219, 57);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(120, 173);
            this.lstCategory.TabIndex = 6;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Animal Category";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.lstGender);
            this.grpGender.Location = new System.Drawing.Point(9, 130);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(156, 100);
            this.grpGender.TabIndex = 4;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // lstGender
            // 
            this.lstGender.FormattingEnabled = true;
            this.lstGender.Location = new System.Drawing.Point(6, 19);
            this.lstGender.Name = "lstGender";
            this.lstGender.Size = new System.Drawing.Size(144, 69);
            this.lstGender.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(47, 90);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(118, 20);
            this.txtAge.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(47, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(22, 454);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(144, 15);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "Output will be displayed here";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(503, 60);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(211, 13);
            this.lblImage.TabIndex = 13;
            this.lblImage.Text = "Picture of your animal will be displayed here";
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(496, 269);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(218, 50);
            this.btnImage.TabIndex = 14;
            this.btnImage.Text = "Load an image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(506, 93);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(208, 137);
            this.picBox.TabIndex = 15;
            this.picBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 629);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpGender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.ListBox lstGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstObjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEndangered;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtSpec2;
        private System.Windows.Forms.TextBox txtSpec1;
        private System.Windows.Forms.Label lblSpec2;
        private System.Windows.Forms.Label lblSpec1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkAnimals;
        private System.Windows.Forms.TextBox txtSpec3;
        private System.Windows.Forms.Label lblSpec3;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox picBox;
    }
}

