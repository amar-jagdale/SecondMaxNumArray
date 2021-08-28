using System;

namespace SecondMaxNumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            TestArray obj = new TestArray();
            obj.PrintArray();
        }
    }
    public class TestArray
    {
        public void PrintArray()
        { 
            //Single Dimentional Array
            string[] IPLTeams ={ "asads","SASD","HDHH","JYFJF","HCHHCHGH"};
            
            for (int i = 0; i <IPLTeams.Length; i++)
            {
                Console.WriteLine(IPLTeams[i]);
            }

            //Two Dimentional Array --Row---Column
            int[,] win = new int[3,3];

            //multidimentional Array
            int[,,] mult = new int[3, 3, 3];

            ///jagged Array
            int[][] jagArr = new int[3][];


        }
    }
}
