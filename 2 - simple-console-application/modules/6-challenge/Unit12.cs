using System;

/*
    Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");
    Console.WriteLine($"{"StudentName"}\t\t{"0"}\t\t{"95.8"}\t{"A"}\t{"0"} ({5} pts)");
*/

class Unit12
{
  public static void Execute()
  {
    int examAssignments = 5;

    Dictionary<decimal, string> gradeMap = new() {
      {97, "A+"},{93,"A"},{90,"A-"},
      {87, "B+"},{83,"B"},{80,"B-"},
      {77, "C+"},{73,"C"},{70,"C-"},
      {67, "D+"},{63,"D"},{60,"D-"},
    };

    Dictionary<string, int[]> students = new() {
      {"Sophia", [90,86,87,98,100,94,90]},
      {"Andrew", [92,89,81,96,90,89]},
      {"Emma", [90,85,87,98,68,89,89,89]},
      {"Logan", [90,95,87,88,96,96]},
      {"Becky", [92,91,90,91,92,92,92]},
      {"Chris", [84,86,88,90,92,94,96,98]},
      {"Eric", [80,90,100,80,90,100,80,90]},
      {"Gregor", [91,91,91,91,91,91,91]},
    };

    Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

    foreach (var student in students)
    {
      int scoreSum = 0;
      int extraCredit = 0;
      int gradeAssignments = 0;
      int extraGradeAssigments = 0;
      foreach (var grade in student.Value)
      {
        gradeAssignments++;

        if (gradeAssignments <= examAssignments)
          // add the exam score to the sum
          scoreSum += grade;
        else
        {
          extraGradeAssigments++;
          extraCredit += grade;
        }
      }
      decimal studentScore = (decimal)scoreSum / examAssignments;
      getGrade(student.Key, studentScore, extraCredit, examAssignments, extraGradeAssigments, gradeMap);
    }

  }

  public static void getGrade(string studentName, decimal examScore, int extraCredit, int examsQuantity, int extraExamsQuantity, Dictionary<decimal, string> gradeMap)
  {
    decimal extraPoints = ((decimal)extraCredit / 10) / examsQuantity;
    extraCredit /= extraExamsQuantity;
    string grade = "F";

    foreach (var keyValuePair in gradeMap)
    {
      if ((examScore+extraPoints) >= keyValuePair.Key)
      {
        grade = keyValuePair.Value; // retorna a grade (value) da primeira nota (key) que passar na condição;
        break;
      }
    }

    Console.WriteLine($"{studentName}\t\t{examScore}\t\t{examScore + extraPoints}\t{grade}\t{extraCredit} ({extraPoints} pts)");

  }
}
