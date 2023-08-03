
using System;

namespace LinqPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqContext _context = new LinqContext();
            var students = _context.Students.ToList<Student>();

            //find()
            Console.WriteLine("**** Find() method *****");
            var student = _context.Students.Find(1);
            student = _context.Students.Find(100);
            Console.WriteLine(student.Name);

            //firstOrDefault()
            Console.WriteLine("**** FirstOrDefault() method *****");
            student = _context.Students.FirstOrDefault(s => s.Name == "John");
            Console.WriteLine(student.Name);

            //singleOrDefault()
            Console.WriteLine("**** SingleOrDefault() method *****");
            student = _context.Students.SingleOrDefault(s => s.Name == "John");
            Console.WriteLine(student.Name);

            //ToList()
            Console.WriteLine("**** ToList() method *****");
            var studentList = _context.Students.Where(s => s.Name == "John").ToList();
            foreach (var item in studentList)
            {
                Console.WriteLine(item.Name);
            }

            //OrderBy()
            Console.WriteLine("**** OrderBy() method *****");
            studentList = _context.Students.OrderBy(s => s.Name).ToList();
            foreach (var item in studentList)
            {
                Console.WriteLine(item.Name);
            }

            //OrderByDescending()
            Console.WriteLine("**** OrderByDescending() method *****");
            studentList = _context.Students.OrderByDescending(s => s.Name).ToList();
            foreach (var item in studentList)
            {
                Console.WriteLine(item.Name);
            }

            //Anonymous Object Result
            Console.WriteLine("**** Anonymous Object Result *****");
            var anonymousObjectResult = _context.Students.Select(s => new
            {
                FullName = s.Name + " " + s.Surname,
                Class = s.ClassId
            }).ToList();

            foreach (var item in anonymousObjectResult)
            {
                Console.WriteLine(item.FullName + " " + item.Class);
            }

        





        }
    }
}