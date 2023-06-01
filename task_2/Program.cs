internal class Program_2
{
    private static void Main(string[] args)
    {
        double[] LineData(double k, double b)
        {
            return new double[2] { k, b };
        }

        bool isIntersectionPoint(double[] lineData1, double[] lineData2)
        {
            if (lineData1[0] == lineData2[0])
            {
                if (lineData1[1] == lineData2[1])
                    return false;
                else
                    return false;
            }
            return true;
        }

        double Prompt(string message)
        {
            Console.Write(message);
            double coeff = Convert.ToDouble(Console.ReadLine()!);
            return coeff;
        }

        double[] GetLineData(string numberLine)
        {
            double k = Prompt($"Введите b {numberLine}: ");
            double b = Prompt($"Введите k {numberLine}: ");
            return LineData(b, k);
        }

        double[] PointSearch(double[] lineData1, double[] lineData2)
        {
            double[] point = new double[2];
            point[0] = (lineData1[1] - lineData2[1]) / (lineData2[0] - lineData1[0]);
            point[1] = lineData1[0] * point[0] + lineData1[1];
            return point;
        }
        
        double[] lineData1 = GetLineData("1");
        double[] lineData2 = GetLineData("2");
        if (isIntersectionPoint(lineData1, lineData2))
        {
            double[] point = PointSearch(lineData1, lineData2);
            Console.WriteLine($"b1 = {lineData1[0]}, k1 = {lineData1[1]}, b2 = {lineData2[0]}, k2 = {lineData1[1]} -> ({point[0]}, {point[1]})");
        }
    }
}