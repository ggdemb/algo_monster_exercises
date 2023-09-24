namespace algo_monster_exercises.Backtracking.GenerateAllValidParentheses
{
	public class Solution
	{
		//private  void DepthFirstSearch(int startIndex, List<char> path, int openCount, int closeCount, List<string> res, int n)
		//{
		//	if (path.Count == 2 * n)
		//	{
		//		res.Add(string.Concat(path));
		//		return;
		//	}
		//	if (openCount < n)
		//	{
		//		path.Add('(');
		//		DepthFirstSearch(startIndex + 1, path, openCount + 1, closeCount, res, n);
		//		path.RemoveAt(path.Count - 1);
		//	}
		//	if (closeCount < openCount)
		//	{
		//		path.Add(')');
		//		DepthFirstSearch(startIndex + 1, path, openCount, closeCount + 1, res, n);
		//		path.RemoveAt(path.Count - 1);
		//	}
		//}

		public  List<string> GenerateParentheses(int matchingParethesesCount)
		{
			List<string> result = new List<string>();
			DepthFirstSearch(localState:new List<char>(), openCount: 0, closeCount:0, result, matchingParethesesCount);
			return result;
		}

		private void DepthFirstSearch(List<char> localState, int openCount, int closeCount, List<string> result, int matchingParethesesCount)
		{
			if (localState.Count == matchingParethesesCount * 2)
			{
				result.Add(string.Join("", localState));
				return;
			}else if (openCount < matchingParethesesCount)
            {
				localState.Add('(');
				DepthFirstSearch(localState, openCount + 1 ,closeCount, result, matchingParethesesCount);
				localState.RemoveAt(localState.Count - 1);
            } 
			if (closeCount < openCount)
			{
				localState.Add(')');
				DepthFirstSearch(localState, openCount, closeCount + 1, result, matchingParethesesCount);
				localState.RemoveAt(localState.Count - 1);
			}
        }
	}
}
