namespace WordBreakDomain.Models
{
    public static class SuperString
    {
        /// <summary>
        /// Checks if the string can be segmented into a space-separated sequence of one or more dictionary words
        /// </summary>
        /// <param name="str">Word</param>
        /// <param name="dict">Array of words</param>
        /// <returns>If is a segment returns true</returns>
        public static bool IsWordBreak(string str, string[] dict)
        {
            var result = new bool[str.Length];
            return FindRecursive(str, dict, 0, result);
        }

        /// <summary>
        /// Checks if the word at certain index is a segment
        /// </summary>
        /// <param name="str">Word</param>
        /// <param name="dict">Array of words</param>
        /// <param name="startIndex">Integer</param>
        /// <param name="result">Array of booleans</param>
        /// <returns>If is a segment returns true</returns>
        private static bool FindRecursive(string str, string[] dict, int startIndex, bool[] result)
        {
            if (startIndex >= str.Length) return true;

            if (result[startIndex] == false)
            {
                foreach (string word in dict)
                {
                    int finded = str.IndexOf(word, startIndex);

                    if (finded == startIndex)
                    {
                        if (FindRecursive(str, dict, startIndex + word.Length, result))
                        {
                            result[startIndex] = true;
                            return result[startIndex];
                        }
                    }
                }
            }

            result[startIndex] = false;
            return result[startIndex];
        }
    }
}
