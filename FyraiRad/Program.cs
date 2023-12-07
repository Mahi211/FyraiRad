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



    for(int i = 0;  i < (lines.Length - 2); i += 3) 
    {
        var lineArray = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var nextLine = lines[i + 1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var thirdLine = lines[i + 2].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int j = 0; j < 3; j++)
        {
            listOfTriangles.Add(new Triangle
            {
                FirstSide = Convert.ToInt32(lineArray[j]),
                SecondSide = Convert.ToInt32(nextLine[j]),
                ThirdSide = Convert.ToInt32(thirdLine[j])
            });
        }
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