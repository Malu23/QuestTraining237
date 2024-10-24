using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Types; 

namespace Test2
{
    public class Patient
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string MedicalCondition { get; set; }
    }
}