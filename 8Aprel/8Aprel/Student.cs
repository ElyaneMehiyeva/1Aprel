using System;
using System.Collections.Generic;
using System.Text;

namespace _8Aprel
{
    internal class Student
    {
        private static int _no;
        public Student()
        {

            _no++;
            this.No = _no;
        }
        public int No { get;  }
        public string FullName { get; set; }
        public Dictionary<string,double> Exams = new Dictionary<string,double>();
        public void AddExam(string examName, double point)
        {
            Exams.Add(examName, point);
        }
        public double GetExamResult(string examName)
        {
            return Exams[examName];
        }
        public double GetExamAvg()
        {
            double sum = 0;
            foreach (var exam in Exams)
            {
                sum += exam.Value;
            }
            return sum;
        }
    }
}

