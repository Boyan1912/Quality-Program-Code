using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Grade must be greater than zero!");
                }
                this.grade = value;
            }
        }
        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("MinGrade must be greater than zero!");
                }
                this.minGrade = value;
            }
        }
        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }
            private set
            {
                if (value <= this.MinGrade)
                {
                    throw new ArgumentException("MaxGrade must be larger than MinGrade!");
                }
                this.maxGrade = value;
            }
        }
        public string Comments
        {
            get
            {
                return this.comments;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Comments must not be empty!");
                }
                this.comments = value;
            }
        }
    }

}
