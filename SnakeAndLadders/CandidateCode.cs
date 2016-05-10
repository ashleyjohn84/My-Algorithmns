using System;
using System.Collections.Generic;

using System.Linq;

// se testMatrix.cs
namespace SnakeAndLadders
{
    public class CandidateCode
    {
        public static int[,] inputMatrix;
        public static int[,] outputMatix;
        public  static bool isvalid;
        public static int size;
        public static string operations_seq(int input1, string[] input2, string[] input3)
        {
            if ((input1 > 0) && (input2.Length == input1) && (input3.Length == input1))
            {
                size = input1;
                inputMatrix = Getmatrix(input2, input1);
                outputMatix = Getmatrix(input3, input1);
                if (isvalid)
                {
                    if (CheckIfLegal())
                        return "yes";
                    else
                    {
                        return "no";
                    }
                }
                return "invalid";
            }
            return "invalid";
        }

        private static bool CheckIfLegal()
        {
            int downColumn = -1;
            int flag = 0;
            for (int i = 0; i < size; i++)
            {
                int currentcolumnValue = inputMatrix[0, i];

                for (int j = 0; j < size; j++)
                {
                    if (outputMatix[1, j] == currentcolumnValue)
                    {
                        downColumn = i;
                        if (OtherRowValuesmatch(downColumn))
                        {
                            flag = 1;
                            break;
                        }
                        else
                        {
                           continue;
                        }
                    }
                }
                if (flag == 1)
                    break;
            }

            if (flag == 1)
            {
                return CheckAllOtherRowsMatch(downColumn);
            }

            else
                return false;
        }


        private static bool CheckAllOtherRowsMatch(int column)
        {
           
           
            for (int i = 0; i < size; i++)
            {
                List<int> inputvalues = new List<int>();
                List<int> outputvalues = new List<int>();

                for (int j = 0; j < size; j++)
                {
                    if( j!= column)
                        inputvalues.Add(inputMatrix[i,j]);
                    else
                    {
                        inputvalues.Add(inputMatrix[i>0?i-1:size-1, j]);
                    }
                }
                for (int k = 0; k < size; k++)
                {
                    outputvalues.Add(outputMatix[i, k]);
                }

                if (!(inputvalues.All(x => outputvalues.Exists(y => x == y))))
                    return false;
            }
            return true;
        }

        private static bool OtherRowValuesmatch(int column)
        {
            List<int> inputvalues = new List<int>();
            List<int> outputvalues = new List<int>();
            for (int i = 0; i < size; i++)
            {
                if(i != column)
                    inputvalues.Add(inputMatrix[1,i]);
                else
                {
                    inputvalues.Add(inputMatrix[0,column]);
                }
            }
            for (int i = 0; i < size; i++)
            {
               outputvalues.Add(outputMatix[1, i]);
            }
            return inputvalues.All(x => outputvalues.Exists(y => x == y));
        }

        public static int[,] Getmatrix(string[] input,int size)
        {
            string[] columns = null;
            int[,] matrix = new int[size,size];
            bool flag = false;
            for (int i = 0; i < input.Length; i++)
            {
                string row = input[i];
                columns = input[i].Split('#');
                if (columns.Length != size)
                {
                    flag = true;
                    break;
                }
                for (int j = 0; j < columns.Length; j++)
                {
                    matrix[i, j] = Convert.ToInt32(columns[j]);
                }
            }
            if(flag)
            {
                isvalid = false;
            }
            else
            {
                isvalid = true;
            }
            return matrix;
        }
    }
}
