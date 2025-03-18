using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsForm
{
    public class Question
    {
        public int questionsId { get; set; }
        public string favGame { get; set; }
        public string favFood { get; set; }
        public string favHobby { get; set; }

        public override string? ToString()
        {
            return $"{questionsId} - {favGame} - {favHobby} - {favFood}";
        }
    }
}
