using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_monster_exercises.Backtracking.AllLetterCombinationsFromAPhoneNumber
{
	public class Solution
	{
		private readonly Dictionary<char, string> _digitsToLettersMapping = new()
		{
			{ '1', " " },
			{ '2', "abc" },
			{ '3', "def" },
			{ '4', "ghi" },
			{ '5', "jkl" },
			{ '6', "mno" },
			{ '7', "pqrs" },
			{ '8', "tuv" },
			{ '9', "wxyz" },
			{ '0', "*" },
		};

		public List<string> FindLetterCombinationsOfPhoneNumber(string digits)
		{
			var result = new List<string>();
			if (digits != null && digits.Length > 0)
			{
				var pathForRoot = "";
				DepthFirstSearch(pathForRoot, digits, result);
			}
			return result;
		}

		private void DepthFirstSearch(string path, string digits, List<string> result)
		{
			if(digits.Length == path.Length)
			{
				result.Add(path);
			}
			else
			{
				var nextDigit = digits[path.Length];
				var nextPossibleLetters = _digitsToLettersMapping[nextDigit];

				foreach(var nextLetter in nextPossibleLetters)
				{
					path += nextLetter;
					DepthFirstSearch(path, digits,result);
					path = path.Remove(path.Length - 1);
				}
			}
		}
	}
}
