


namespace LinqPractices.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            using (var context  = new LinqDbContext())
            {
                if (context.Students.Any())
                {
                    return;
                }

                context.Student.AddRange(
                    new Student
                    {
                        Name = "John",
                        Surname = "Doe",
                        ClassId = 1
                    },
                    new Student
                    {
                        Name = "Jane",
                        Surname = "Doe",
                        ClassId = 2
                    },
                    new Student
                    {
                        Name = "John",
                        Surname = "Smith",
                        ClassId = 1
                    },
                    new Student
                    {
                        Name = "Jane",
                        Surname = "Smith",
                        ClassId = 2
                    },
                    new Student
                    {
                        Name = "Johnny",
                        Surname = "Depp",
                        ClassId = 1
                    }
                
                );
                context.SaveChanges();
                    
                        
            }
        }
    }

}