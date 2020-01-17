using System.Linq;
using System.Text;

namespace Core.StreamProcessing
{
    public class StreamProcessor
    {
        public int GroupCount { get; }
        public string Cleaned { get; }
        public int Score { get; }
        public int GarbageCount { get; }

        public StreamProcessor(string input)
        {
            var removeResult = RemoveGarbage(input);
            Cleaned = removeResult.Cleaned;
            GarbageCount = removeResult.Removed;
            GroupCount = removeResult.Cleaned.Count(o => o == '}');
            Score = GetScore(removeResult.Cleaned);
        }

        private int GetScore(string cleaned)
        {
            var totalScore = 0;
            var currentScore = 0;
            foreach (var c in cleaned)
            {
                if (c == '{')
                {
                    currentScore += 1;
                }

                if (c == '}')
                {
                    totalScore += currentScore;
                    currentScore -= 1;
                }
            }

            return totalScore;
        }

        private RemoveResult RemoveGarbage(string input)
        {
            var removeCount = 0;
            input = input.Replace("!!", "");
            var cleaned = new StringBuilder();
            var isInGarbage = false;
            for (var i = 0; i < input.Length; i++)
            {
                var c = input[i];
                
                if (!isInGarbage)
                {
                    if (c == '<')  
                        isInGarbage = true;
                    else 
                        cleaned.Append(c);
                }
                else
                {
                    if (c == '>' && input[i - 1] != '!')
                        isInGarbage = false;
                    else if (c == '!')
                        removeCount -= 1;
                    else     
                        removeCount += 1;
                }
            }

            return new RemoveResult(cleaned.ToString(), removeCount);
        }

        private class RemoveResult
        {
            public string Cleaned { get; }
            public int Removed { get; }

            public RemoveResult(string cleaned, int removed)
            {
                Cleaned = cleaned;
                Removed = removed;
            }
        }
    }
}