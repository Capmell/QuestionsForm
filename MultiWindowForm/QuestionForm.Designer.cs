namespace QuestionsForm
{
    partial class QuestionForm
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
            gbCustomer = new GroupBox();
            btnClear = new Button();
            btnSave = new Button();
            txtHobby = new TextBox();
            lblPhoneHeading = new Label();
            txtFood = new TextBox();
            lblEmailHeading = new Label();
            txtGame = new TextBox();
            lblNameHeading = new Label();
            gbCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // gbCustomer
            // 
            gbCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbCustomer.AutoSize = true;
            gbCustomer.Controls.Add(btnClear);
            gbCustomer.Controls.Add(btnSave);
            gbCustomer.Controls.Add(txtHobby);
            gbCustomer.Controls.Add(lblPhoneHeading);
            gbCustomer.Controls.Add(txtFood);
            gbCustomer.Controls.Add(lblEmailHeading);
            gbCustomer.Controls.Add(txtGame);
            gbCustomer.Controls.Add(lblNameHeading);
            gbCustomer.Location = new Point(12, 12);
            gbCustomer.Name = "gbCustomer";
            gbCustomer.Size = new Size(452, 161);
            gbCustomer.TabIndex = 0;
            gbCustomer.TabStop = false;
            gbCustomer.Text = "questions";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(341, 116);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(6, 116);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtHobby
            // 
            txtHobby.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHobby.Location = new Point(103, 82);
            txtHobby.Name = "txtHobby";
            txtHobby.Size = new Size(343, 23);
            txtHobby.TabIndex = 5;
            // 
            // lblPhoneHeading
            // 
            lblPhoneHeading.AutoSize = true;
            lblPhoneHeading.Location = new Point(6, 85);
            lblPhoneHeading.Name = "lblPhoneHeading";
            lblPhoneHeading.Size = new Size(60, 15);
            lblPhoneHeading.TabIndex = 4;
            lblPhoneHeading.Text = "fav hobby";
            // 
            // txtFood
            // 
            txtFood.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFood.Location = new Point(103, 53);
            txtFood.Name = "txtFood";
            txtFood.Size = new Size(343, 23);
            txtFood.TabIndex = 3;
            // 
            // lblEmailHeading
            // 
            lblEmailHeading.AutoSize = true;
            lblEmailHeading.Location = new Point(6, 56);
            lblEmailHeading.Name = "lblEmailHeading";
            lblEmailHeading.Size = new Size(51, 15);
            lblEmailHeading.TabIndex = 2;
            lblEmailHeading.Text = "fav food";
            // 
            // txtGame
            // 
            txtGame.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGame.Location = new Point(103, 24);
            txtGame.Name = "txtGame";
            txtGame.Size = new Size(343, 23);
            txtGame.TabIndex = 1;
            // 
            // lblNameHeading
            // 
            lblNameHeading.AutoSize = true;
            lblNameHeading.Location = new Point(6, 27);
            lblNameHeading.Name = "lblNameHeading";
            lblNameHeading.Size = new Size(56, 15);
            lblNameHeading.TabIndex = 0;
            lblNameHeading.Text = "fav game";
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 184);
            Controls.Add(gbCustomer);
            Name = "NewCustomerForm";
            Text = "questions form";
            gbCustomer.ResumeLayout(false);
            gbCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbCustomer;
        private TextBox txtGame;
        private Label lblNameHeading;
        private TextBox txtFood;
        private Label lblEmailHeading;
        private Button btnSave;
        private TextBox txtHobby;
        private Label lblPhoneHeading;
        private Button btnClear;
    }
}