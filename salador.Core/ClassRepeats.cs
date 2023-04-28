namespace salador.Core
{
    public class ClassRepeats
    {
        public static List<int> FindRepeat(int[] input)
        {
            int currRepeat = 0;
            List<int> result = new List<int>();
            Array.Sort(input);
            if (input.Length < 2)
            {
                return result;
            }
            for (int i = 0; i < input.Length; i++)
            {

                if (i < input.Length - 1)
                {
                    if (input[i] == input[i + 1])
                    {
                        if (input[i] != currRepeat)
                        {
                            currRepeat = input[i];
                            result.Add(input[i]);
                        }
                    }
                }
            }

            return result;
        }
    }
}
