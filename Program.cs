using System;
public class Program
{
    static void Main(string[] args)
    {
        bool isEnd;
        isEnd = false;
        while (isEnd == false)
        {
            string operation = Console.ReadLine();
            if (operation == "+" || operation == "-")
            {
                int m = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                double[,] matrix1 = new double[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix1[i, j] = double.Parse(Console.ReadLine());
                    }
                }
                double[,] matrix2 = new double[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix2[i, j] = double.Parse(Console.ReadLine());
                    }
                }
                if(operation== "+"){
                    double[,] matrixANS = new double[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrixANS[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0}  ", matrixANS[i, j]);
                    }
                    Console.WriteLine();
                }
                }
                else if(operation == "-"){
                    double[,] matrixANS = new double[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrixANS[i, j] = matrix1[i, j] - matrix2[i, j];
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0}  ", matrixANS[i, j]);
                    }
                    Console.WriteLine();
                }
                }  
            }
            else{
                isEnd = true;
            }
        }
  
    }
}
