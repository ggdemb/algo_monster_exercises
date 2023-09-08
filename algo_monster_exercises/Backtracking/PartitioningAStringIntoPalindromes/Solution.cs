namespace algo_monster_exercises.Backtracking.PartitioningAStringIntoPalindromes
{
	public class Solution
	{
		public List<List<string>> GetAllPalindromes(string textToCheck)
		{
			var finalResult = new List<List<string>>();
			if (!string.IsNullOrEmpty(textToCheck))
				DepthFirstSearch(finalResult, localState: new List<string>(), textToCheck, startIndex: 0);
			return finalResult;
		}

		private void DepthFirstSearch(List<List<string>> finalResult, List<string> localState, string textToCheck, int startIndex)
		{
			if (startIndex == textToCheck.Length)
			{
				finalResult.Add(new List<string>(localState));
				return;
			}

			for (int currentIndex = startIndex; currentIndex < textToCheck.Length; currentIndex++)
			{
				var stringToCheck = textToCheck.Substring(startIndex, currentIndex - startIndex + 1);
				if (IsPalindrome(stringToCheck))
				{
					localState.Add(stringToCheck);
					DepthFirstSearch(finalResult, localState, textToCheck, currentIndex + 1);
					localState.RemoveAt(localState.Count - 1);
				}
			}
		}

		private bool IsPalindrome(string textToCheck)
		{
			var l = 0;
			var r = textToCheck.Length - 1;

			while (l < r)
			{
				if (textToCheck[l] != textToCheck[r])
					return false;
				l++;
				r--;
			}
			return true;
		}
	}
}
