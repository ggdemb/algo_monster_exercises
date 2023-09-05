using Xunit;

namespace algo_monster_exercises.Backtracking.AllLetterCombinationsFromAPhoneNumber.Tests
{
	public class SolutionTests
	{
		[Theory]
		[InlineData("")]
		[InlineData(null)]
		public void FindLetterCombinationsOfPhoneNumberTestWhenEmptyOrNull(string digits)
		{
			var sut = new Solution();
			var result = sut.FindLetterCombinationsOfPhoneNumber(digits);
			Assert.Empty(result);
		}
		[Theory]
		[InlineData("56", new string[] { "jm", "jn", "jo", "km", "kn", "ko", "lm", "ln", "lo" })]
		[InlineData("235", new string[] { "adj", "adk", "adl", "aej", "aek", "ael", "afj", "afk", "afl", "bdj", "bdk", "bdl", "bej", "bek", "bel", "bfj", "bfk", "bfl", "cdj", "cdk", "cdl", "cej", "cek", "cel", "cfj", "cfk", "cfl" })]
		public void FindLetterCombinationsOfPhoneNumberTestWhenEmpty(string digits, string[] expectedResult)
		{
			var sut = new Solution();
			var result = sut.FindLetterCombinationsOfPhoneNumber(digits);
			var resultDiff = result.Except(expectedResult);
			var expectedResultDiff = expectedResult.Except(result);
			Assert.Empty(resultDiff);
			Assert.Empty(expectedResultDiff);

		}
	}
}