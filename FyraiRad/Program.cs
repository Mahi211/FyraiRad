// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;



List<Triangle> listOfTriangles = new();
int triangleCount = 0;

bool IsTriangle(Triangle triangleInput)
{
    if ((triangleInput.FirstSide + triangleInput.SecondSide > triangleInput.ThirdSide)
       && (triangleInput.SecondSide + triangleInput.ThirdSide > triangleInput.FirstSide)
       && (triangleInput.ThirdSide + triangleInput.FirstSide > triangleInput.SecondSide))
    {
        return true;
    }
    return false;
}

string[] lines = File.ReadAllLines("input.txt");



foreach (string line in lines)
{
    
    var lineArray = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

  
    listOfTriangles.Add(new Triangle { FirstSide = Convert.ToInt32(lineArray[0]),
        SecondSide = Convert.ToInt32(lineArray[1]),
    ThirdSide = Convert.ToInt32(lineArray[2])});
}

foreach (var triangle1 in listOfTriangles)
{
    var isValidTriangle = IsTriangle(triangle1);
    if (isValidTriangle)
    {
        triangleCount++;
    }
}

Console.WriteLine(triangleCount);

public class Triangle
{
    public int FirstSide { get; set; }
    public int SecondSide { get; set; }
    public int ThirdSide { get; set; }


}