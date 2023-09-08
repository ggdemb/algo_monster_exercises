using Xunit;

namespace algo_monster_exercises.Backtracking.PartitioningAStringIntoPalindromes.Tests
{
	public class SolutionTests
	{
		[Theory()]
		[InlineData("")]
		[InlineData(null)]
		public void GetAllPalindromesTestWhenThereIsNoText(string textToCheck)
		{
			var sut = new Solution();
			var result = sut.GetAllPalindromes(textToCheck);
			Assert.Empty(result);
		}
		[Fact()]
		public void GetAllPalindromesTestForRegularText()
		{
			var sut = new Solution();
			var result = sut.GetAllPalindromes(textToCheck: "aab");
			Assert.Equal("a", result[0][0]);
			Assert.Equal("a", result[0][1]);
			Assert.Equal("b", result[0][2]);
			Assert.Equal("aa", result[1][0]);
			Assert.Equal("b", result[1][1]);
		}

		[Fact()]
		public void GetAllPalindromesTestWhenThereAreOnlyOneLetterPalindromes()
		{
			var sut = new Solution();
			var result = sut.GetAllPalindromes(textToCheck: "abcdef");
			Assert.Equal("a", result[0][0]);
			Assert.Equal("b", result[0][1]);
			Assert.Equal("c", result[0][2]);
			Assert.Equal("d", result[0][3]);
			Assert.Equal("e", result[0][4]);
			Assert.Equal("f", result[0][5]);
		}
	}
}