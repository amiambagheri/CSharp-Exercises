using System.Linq;

var studentList = StudentDatabase.GetStudentsFromDb();
/*

// use of LINQ with Query syntax
// var studentsScoreMoreThan80 = from student in studentList
//                               where student.Score > 80
//                               select student.StudentName;


// use of LINQ with method syntax
// finding and sorting and projection in fake DB  


var studentsScoreMoreThan80 = studentList.Where(s => s.Score > 80).Select(s => s.StudentName);
foreach (var item in studentsScoreMoreThan80)
{
    Console.WriteLine(item);
}


var studentSoretdByScore = studentList.OrderByDescending(s => s.Score)
                                    .Select(s => new MinimalStudent()
                                    {
                                        StudentName = s.StudentName,
                                        Score = s.Score
                                    });

foreach (var item in studentSoretdByScore)
{
    Console.WriteLine(item.StudentName);
}
// groping by and use of data
var groupedByCity = studentList.GroupBy(s => s.City);
foreach (var student in groupedByCity)
{
    foreach (var item in student)
    {
        Console.WriteLine(student.Key + " : " + item.StudentName);
    }
    Console.WriteLine("--------------");
}

// use all, any and contains

var hasAllStudentsPass = studentList.All(s => s.Score > 80);
Console.WriteLine(hasAllStudentsPass);
var hasAnyStudentFailed = studentList.Any(s => s.Score < 50);
Console.WriteLine(hasAnyStudentFailed);

var hasStdPassInCaWithNo = studentList.Where(s => s.Score > 80
                                                && s.City == "CA"
                                                && s.StudentName.Contains("No"))
                                                .Select(s => s.StudentName);

foreach (var item in hasStdPassInCaWithNo)
{
    Console.WriteLine(item);
}
int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
var skiped3 = numbers.Skip(3);

foreach (var item in skiped3)
{
    Console.WriteLine(item);
}
var take3ToEnd = numbers.Take(-3);
foreach (var item in take3ToEnd)
{
    Console.WriteLine(item);
}
Console.WriteLine("_____________");
var numbersCount = numbers.Count();
Console.WriteLine(numbersCount);
var numbersMax = numbers.Max();
Console.WriteLine(numbersMax);
var numbersMin = numbers.Min();
Console.WriteLine(numbersMin);
var numbersAvg = numbers.Average();
Console.WriteLine(numbersAvg);
var numbersSum = numbers.Sum();
Console.WriteLine(numbersSum);
string[] numberList = [];
// Console.WriteLine(numberList.First());
Console.WriteLine(numberList.FirstOrDefault());
Console.WriteLine(numberList.SingleOrDefault());
*/
// chalenge of chapter LINQ


var activeStudentPassInNyc = studentList.Where(s => s.IsActive &&
                                                    s.Score > 80 &&
                                                    s.City == "NYC")
                                        .Select(s => s.StudentName);

foreach (var item in activeStudentPassInNyc)
{
    Console.WriteLine(item);
}
var studentPassInCa = studentList.Where(s => s.Score > 80 ||
                                             s.City == "CA")
                                 .Select(s => s.StudentName);

foreach (var item in studentPassInCa)
{
    Console.WriteLine(item);
}

var studentWithNameB = studentList.Where(s => s.StudentName.ToUpper()
                                                           .StartsWith('B'))
                                  .Select(s => new MinimalStudent()
                                  {
                                      StudentName = s.StudentName,
                                      Score = s.Score
                                  });

foreach (var item in studentWithNameB)
{
    Console.WriteLine(item.StudentName);
}

var noActiveStudentSortedByDesendScore = studentList.Where(s => !s.IsActive)
                                                    .OrderByDescending(s => s.Score);

foreach (var item in noActiveStudentSortedByDesendScore)
{
    Console.WriteLine(item.StudentName + " " + item.Score);
}

var studentsAvg = studentList.Average(s => s.Score);

var ActiveStudentAvgInCA = studentList.Where(s => s.IsActive &&
                                                  s.City == "CA" &&
                                                 (s.StudentName.Contains('R') ||
                                                  s.StudentName.Contains('R')))
                                      .Average(s => s.Score);


Console.WriteLine(ActiveStudentAvgInCA);

class StudentDatabase
{
    public static IQueryable<Student> GetStudentsFromDb()
    {
        return new[] {
            new Student(){StudentId = 1, IsActive = true, StudentName = "John Nigel", Score = 73, City = "NYC"},
            new Student(){StudentId = 2, IsActive = false, StudentName = "Alex Roma", Score = 51, City = "CA"},
            new Student(){StudentId = 3, IsActive = true, StudentName = "Noha Shamil", Score = 88, City = "CA"},
            new Student(){StudentId = 4, IsActive = false, StudentName = "James Palatte", Score = 60, City = "NYC"},
            new Student(){StudentId = 5, IsActive = true, StudentName = "Ron Jenova", Score = 85, City = "NYC"},
        }.AsQueryable();
    }
}


class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string City { get; set; }
    public int Score { get; set; }
    public bool IsActive { get; set; }
}
class MinimalStudent
{
    public string StudentName { get; set; }
    public int Score { get; set; }
}