// class Student
// {
//     private string name;
//     private int age;
//     private double marks;
//     private string password;

//     private int registrationNo{get; private set;}

//     public student(int regNo)
//     {
//         this.registrationNo = regNo;
//     }
//     public string Name
//     {
//         get { return name; }
//         set
//         {
//             if (!string.IsNullOrEmpty(value))
//                 name = value;
//         }
//     }

//     public int Age
//     {
//         get { return age; }
//         set
//         {
//             if (value > 0)
//                 age = value;
//         }
//     }

//     public double Marks
//     {
//         get { return marks; }
//         set
//         {
//             if (value >= 0 && value <= 100)
//                 marks = value;
//         }
//     }

//     public int Student_Id { get; set; }

//     public string Result
//     {
//         get
//         {
//             return marks >= 40 ? "Pass" : "Fail";
//         }
//     }
//     public string Password
//     {
//         set
//         {
//             if (!string.IsNullOrEmpty(value) && value.Length == 6)
//                 password = value;
//         }
//     }
// }
