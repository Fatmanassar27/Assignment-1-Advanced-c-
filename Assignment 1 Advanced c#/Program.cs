using Assignment_1_Advanced_c_.Genaric;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non Genaric
            //int A = 1, B = 2;
            //Console.WriteLine($"A = {A} ");
            //Console.WriteLine($"B = {B} ");
            //Helper.Swap (ref A,ref B);
            //Console.WriteLine($"A = {A} ");
            //Console.WriteLine($"B = {B} ");

            //double A = 1.5, B = 2.2;
            //Console.WriteLine($"A = {A} ");
            //Console.WriteLine($"B = {B} ");
            //Helper.Swap(ref A, ref B);
            //Console.WriteLine($"A = {A} ");
            //Console.WriteLine($"B = {B} ");

            //Point p1 = new Point(4, 9);
            //Point p2 = new Point(40, 90);
            //Console.WriteLine( p1.ToString() );
            //Console.WriteLine( p2.ToString() );
            //Helper.Swap(ref p1, ref p2);
            //Console.WriteLine( p1.ToString() );
            //Console.WriteLine( p2.ToString() );
            #endregion

            #region Genaric
            //int A = 1, B = 2;
            //Console.WriteLine($"A = {A} ");
            //Console.WriteLine($"B = {B} ");
            //Helper.Swap(ref A, ref B);
            //Console.WriteLine($"A = {A} ");
            //Console.WriteLine($"B = {B} ");

            //double X = 1.5, Y = 2.2;
            //Console.WriteLine($"X = {X} ");
            //Console.WriteLine($"Y = {Y} ");
            //Helper.Swap(ref X, ref Y);
            //Console.WriteLine($"X = {X} ");
            //Console.WriteLine($"Y = {Y} ");

            //Point p1 = new Point(4, 9);
            //Point p2 = new Point(40, 90);
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p2.ToString());
            //Helper.Swap(ref p1, ref p2);
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p2.ToString());
            #endregion

            #region Equals in struct employee
            //Employee E01 = new Employee(10,"AHmed",5000);
            //Employee E02 = new Employee(20,"fatma",1000);
            //Employee E03 = new Employee(30,"Aly",2000);
            //Employee E04 = new Employee(10,"AHmed",9000);

            //Employee[] employees = new Employee[3]
            //{
            //    E01,E02,E03
            //};
            //if (E01.Equals(E02))
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");
            //if (E01.Equals(E04))
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");

            //int Index = Helper<Employee>.SearchArray(employees,E04);
            //Console.WriteLine($"E03 in index {Index}");

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int index = Helper<int>.SearchArray(Numbers,4);
            //Console.WriteLine($"4 in index {index}");
            #endregion

            #region equals in class employee
            //Employee E01 = new Employee(10, "AHmed", 5000);
            //Employee E02 = new Employee(20, "fatma", 1000);
            //Employee E03 = new Employee(30, "Aly", 2000);
            //Employee E04 = new Employee(10, "AHmed", 5000);

            //if (E01.Equals(E04))
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");

            //Console.WriteLine($"E01 = {E01.GetHashCode()}");
            //Console.WriteLine($"E04 = {E04.GetHashCode()}");
            #endregion

            #region genaric Compare to
            //int[] Numbers = { 52, 5, 2, 9, 81, 100, 2, 0, 3, 7, 25, 74 };
            //foreach (int num in Numbers)
            //    Console.Write($" {num}");
            //Helper<int>.BubbleSort(ref Numbers);
            //Console.WriteLine();
            //foreach (int num in Numbers)
            //    Console.Write($" {num}");

            //Employee E01 = new Employee(10, "AHmed", 5000);
            //Employee E02 = new Employee(20, "fatma", 1000);
            //Employee E03 = new Employee(30, "Aly", 2000);
            //Employee E04 = new Employee(40, "Amr", 12000);

            //Employee[] employees = new Employee[4]
            //    { 
            //        E01, E02, E03, E04 
            //    };
            //Helper<Employee>.BubbleSort(employees);

            //foreach (Employee employee in employees) 
            //    Console.WriteLine(employee);

            //Point [] points =
            //{
            //    new Point (2,5) ,
            //    new Point (8,3) ,
            //    new Point (1,9) ,
            //    new Point (7,5) ,
            //    new Point (7,4) ,
            //};
            //Helper<Point>.BubbleSort (points);

            //foreach (Point point in points) 
            //    Console.WriteLine (point);
            #endregion

        }
    }
}
