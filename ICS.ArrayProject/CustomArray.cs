namespace ICS.ArrayProject
{
    public static class CustomArray
    {
        public static int[] СonvertArrays(int[] firstArray, int[] sercondArray)
        {
            int[] result = new int[sercondArray.Length];
            List<int> listOfSumSergents = new List<int>();
            int sumSegment = default;
            bool isFound = false;

            for (int i = 0; i < sercondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (sercondArray[i] <= firstArray[j] && isFound == false)
                    {
                        isFound = true;
                        sumSegment += firstArray[j];

                        if (j + 1 == firstArray.Length)
                        {
                            listOfSumSergents.Add(sumSegment);
                            sumSegment = default;
                            isFound = false;
                        }
                    }
                    else if (isFound == true && (sercondArray[i] <= firstArray[j]))
                    {
                        sumSegment += firstArray[j];
                    }
                    else if ((sercondArray[i] > firstArray[j] && isFound == true) || (j + 1 == firstArray.Length && isFound == true))
                    {
                        listOfSumSergents.Add(sumSegment);
                        sumSegment = default;
                        isFound = false;
                    }
                }

                result[i] = GetMaxNumberInList(listOfSumSergents);
                listOfSumSergents.Clear();
            }

            return result;
        }
        
        private static int GetMaxNumberInList(List<int> ints)
        {
            int result = ints.FirstOrDefault();

            foreach (int i in ints)
            {
                if (result < i)
                {
                    result = i;
                }
            }

            return result;
        }
    }
}
