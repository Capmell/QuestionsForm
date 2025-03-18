using System;

namespace QuestionsForm
{
    public partial class MainForm : Form
    {
        private QuestionForm _questionForm;
        private List<Question> _questionList;

        public MainForm()
        {
            InitializeComponent();
            _questionForm = new QuestionForm(this);
            _questionList = new List<Question>();

            _questionList.Add(new Question
            {
                favGame = "final fantasy 7",
                favHobby = "video games",
                favFood = "chicken strips"
            });

            ReloadDataGrid();
        }

        private void ReloadDataGrid()
        {
            dgvQuestions.DataSource = null;
            dgvQuestions.DataSource = _questionList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _questionForm.ShowDialog();
        }

        public void AddQuestion(Question customer)
        {
            _questionList.Add(customer);
            ReloadDataGrid();
        }

        public void EditQuestion(int id, Question updatedQuestion)
        {
            MessageBox.Show("MainForm is editing the customer now.");

            // find the customer out of the list, by id
            var idk = _questionList.Find(c => c.questionsId == id);

            // did we get a customer?
            if (idk != null)
            {
                // found one, process the customer
                idk.favGame = updatedQuestion.favGame;
                idk.favFood = updatedQuestion.favFood;
                idk.favHobby = updatedQuestion.favHobby;

                ReloadDataGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // get the row out of the data grid view
            Question idk;

            // get the position of the first selected item from the data grid view
            var index = dgvQuestions.SelectedRows[0].Index;

            // gets the exact customer out of the array
            idk = _questionList[index];

            // load the customer into the form
            _questionForm.LoadQuestion(idk);

            _questionForm.ToggleEdit(true);

            // show the form
            _questionForm.Show();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Visible = true;
        }
    }
}
