using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class CSharpExam : Exam
    {
        private int score;
        
        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Score must be a positive number!");
                }
                this.score = value;
            }
        }

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public override ExamResult Check()
        {
            if (this.Score < 0 || this.Score > 100)
            {
                throw new ArgumentOutOfRangeException("Score must be within range!");
            }
            else
            {
                return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
            }
        }
    }
}
