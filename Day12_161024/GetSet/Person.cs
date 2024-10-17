// namespace GetSet
// {
//     public class Student
//     {
//         public string Name { get; set; } 
//         private int age;

//         public int Age { 
//             get => age; 
//             set
//             {
//                 if((value > 0) && (value <50))
//                 {
//                     age = value;
//                 }
//             } }

//     }
// }


namespace GetSet
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();

    }

    public class Address
    {
        public string AddressType{ get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Pincode { get; set; }
    
    }
}