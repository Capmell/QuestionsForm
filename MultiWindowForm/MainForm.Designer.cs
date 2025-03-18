namespace QuestionsForm
{
    partial class MainForm
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
            btnNew = new Button();
            dgvQuestions = new DataGridView();
            customerBindingSource = new BindingSource(components);
            btnEdit = new Button();
            questionsIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            favGameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            favFoodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            favHobbyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Location = new Point(679, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(109, 23);
            btnNew.TabIndex = 0;
            btnNew.Text = "New questions";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dgvQuestions
            // 
            dgvQuestions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvQuestions.AutoGenerateColumns = false;
            dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestions.Columns.AddRange(new DataGridViewColumn[] { questionsIdDataGridViewTextBoxColumn, favGameDataGridViewTextBoxColumn, favFoodDataGridViewTextBoxColumn, favHobbyDataGridViewTextBoxColumn });
            dgvQuestions.DataSource = customerBindingSource;
            dgvQuestions.Location = new Point(12, 48);
            dgvQuestions.MultiSelect = false;
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuestions.Size = new Size(776, 390);
            dgvQuestions.TabIndex = 1;
            dgvQuestions.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Question);
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(575, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "edit questions";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // questionsIdDataGridViewTextBoxColumn
            // 
            questionsIdDataGridViewTextBoxColumn.DataPropertyName = "questionsId";
            questionsIdDataGridViewTextBoxColumn.HeaderText = "questionsId";
            questionsIdDataGridViewTextBoxColumn.Name = "questionsIdDataGridViewTextBoxColumn";
            // 
            // favGameDataGridViewTextBoxColumn
            // 
            favGameDataGridViewTextBoxColumn.DataPropertyName = "favGame";
            favGameDataGridViewTextBoxColumn.HeaderText = "favGame";
            favGameDataGridViewTextBoxColumn.Name = "favGameDataGridViewTextBoxColumn";
            // 
            // favFoodDataGridViewTextBoxColumn
            // 
            favFoodDataGridViewTextBoxColumn.DataPropertyName = "favFood";
            favFoodDataGridViewTextBoxColumn.HeaderText = "favFood";
            favFoodDataGridViewTextBoxColumn.Name = "favFoodDataGridViewTextBoxColumn";
            // 
            // favHobbyDataGridViewTextBoxColumn
            // 
            favHobbyDataGridViewTextBoxColumn.DataPropertyName = "favHobby";
            favHobbyDataGridViewTextBoxColumn.HeaderText = "favHobby";
            favHobbyDataGridViewTextBoxColumn.Name = "favHobbyDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(dgvQuestions);
            Controls.Add(btnNew);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNew;
        private DataGridView dgvQuestions;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
        private Button btnEdit;
        private DataGridViewTextBoxColumn questionsIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn favGameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn favFoodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn favHobbyDataGridViewTextBoxColumn;
    }
}
