using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsForm
{
    public partial class QuestionForm : Form
    {
        private MainForm _mainForm;
        private int QuestionCount;
        private bool IsEditing;
        private int CurrentSelectionId;

        public QuestionForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
            QuestionCount = 1;
            IsEditing = false;
            CurrentSelectionId = -1;
        }

        public void ToggleEdit(bool newState)
        {
            IsEditing = newState;
        }

        private void CreateQuestion()
        {

            
            Question question = new Question
            {
                questionsId = QuestionCount,
                favGame = txtGame.Text,
                favFood = txtHobby.Text,
                favHobby = txtFood.Text,
            };

            // send that data to the AddCustomer function on the parent form
            _mainForm.AddQuestion(question);
            QuestionCount++;
        }

     

        private void EditQuestion()
        {
            // validators here, exit early if invalid


            MessageBox.Show("Form is being edited.");

            // tell the main form what our customer looks like
            _mainForm.EditQuestion(CurrentSelectionId, new Question
            {
                questionsId = CurrentSelectionId,
                favGame = txtGame.Text,
                favFood = txtHobby.Text,
                favHobby = txtFood.Text,
            });

            CurrentSelectionId = -1;
            ToggleEdit(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                // edit the item in place
                EditQuestion();
            } 
            else
            {
                // create a new customer
                CreateQuestion();
            }



            // clear the new customer form
            ClearForm();

            // close the form if we want to
            Hide();
        }

        private void ClearForm()
        {
            txtGame.Text = "";
            txtFood.Text = "";
            txtHobby.Text = "";
        }

        public void LoadQuestion(Question question)
        {
            CurrentSelectionId = question.questionsId;
            txtGame.Text = question.favGame;
            txtFood.Text = question.favHobby;
            txtHobby.Text = question.favFood;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
