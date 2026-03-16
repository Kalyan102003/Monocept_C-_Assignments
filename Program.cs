using EnumAndArrayAssignments;

public class Program
{
    public static void Main()
    {
        Enums enums = new Enums();
        enums.EnumProgram();


        int[] inputMarks = { 78, 85, 90, 88, 76 };
        ArrayOfStudentGrades s1 = new ArrayOfStudentGrades("Swapnil Kulkarni", "R102", inputMarks);
        s1.PrintReport();

    }
}