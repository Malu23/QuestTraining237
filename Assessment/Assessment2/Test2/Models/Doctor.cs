using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2
{
    public class Doctor
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
        public string Specialization { get; set; }
        public int? PatientId { get; set; }
    }
}