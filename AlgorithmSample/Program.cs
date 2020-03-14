using System;
using System.Collections;
using System.IO;


namespace AlgorithmSample
{
    class sampleProgram
    {
        static private int _MinRandomValue = 0;
        static private int _MaxRandomValue = 100;
        static private int _SampleDataSize = 200;


        static ArrayList GetRandomSampleDate(int sampleDataSize, int numberRangeMin, int numberRangeMax)
        {
            ArrayList SampleList = new ArrayList();
            Random createRandomNumber = new Random();

            if (sampleDataSize > 0)
            {
                for (int x = 0; x < sampleDataSize; x++)
                {
                    SampleList.Add(createRandomNumber.Next(numberRangeMin, numberRangeMax));
                }
            }

            return (SampleList);
        }

        private static bool IsDuplicate(int SearchValue, ArrayList SourceList)
        {
            bool isFound = false;

            foreach (int sourceValue in SourceList)
            {
                if (sourceValue == SearchValue)
                {
                    isFound = true;
                    break;
                }
            }

            return (isFound);
        }

        private static ArrayList RemoveDuplicates(ArrayList SampleData)
        {
            ArrayList cleanedList = new ArrayList();

            for (int x = 0; x < SampleData.Count; x++)
            {
                if (!IsDuplicate((int)SampleData[x], cleanedList))
                {
                    cleanedList.Add(SampleData[x]);

                    Console.WriteLine("Added [" + SampleData[x].ToString() + "]");
                }
            }

            return (cleanedList);
        }

        private static int FindMaxNumber (ArrayList SampleData)
        {
            int maxValue = int.MinValue;

            foreach (int x in SampleData)
            {   
                if (x > maxValue)
                {
                    maxValue = x;
                }
                //Console.WriteLine(x.ToString() + "    current max value is " + maxValue.ToString());
            }
            return int.MinValue;
        }

        static void Main(string[] args)
        {
            ArrayList sampleData = GetRandomSampleDate(_SampleDataSize, _MinRandomValue, _MaxRandomValue);

            int maxNumber = FindMaxNumber(sampleData);

            ArrayList duplicatesRemoved = RemoveDuplicates(sampleData);

            Console.WriteLine("OG Size [" + sampleData.Count.ToString() + "] Cleaned array size [" + duplicatesRemoved.Count.ToString() + "]");

                          DriveInfo[] systemInfo = DriveInfo.GetDrives();
            
            //Making a difference
        }
    }
}
