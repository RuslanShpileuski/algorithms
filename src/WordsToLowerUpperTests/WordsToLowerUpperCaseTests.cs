namespace WordsToLowerUpperTests
{
	using System.IO;
	using WordsToLowerUpperCase;
	using Xunit;

	public class WordsToLowerUpperCaseTests
	{
		private string TestDataPath => Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "data");

		[Fact]
		public void WordsToLowerUpperCase_WordsToCapitalV1_ActualEqualExpected1()
		{
			// Arrange
			var value = "THE LAZY DOG WALKS Home.";
			var expected = "The Lazy Dog Walks Home.";
			var wtc = new WordsToLowerUpperCase();

			// Act
			var actual = wtc.WordsToCapitalV1(value);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void WordsToLowerUpperCase_WordsToCapitalV1_ActualEqualExpected2()
		{
			// Arrange
			var value = "the lazy dog walks 1 block home.";
			var expected = "The Lazy Dog Walks 1 Block Home.";
			var wtc = new WordsToLowerUpperCase();

			// Act
			var actual = wtc.WordsToCapitalV1(value);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void WordsToLowerUpperCase_WordsToCapitalV1_ActualEqualExpected3()
		{
			// Arrange
			var value = "a LazY dOG waLkS homE.";
			var expected = "A Lazy Dog Walks Home.";
			var wtc = new WordsToLowerUpperCase();

			// Act
			var actual = wtc.WordsToCapitalV1(value);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void WordsToLowerUpperCase_WordsToCapitalV2_ActualEqualExpected1()
		{
			// Arrange
			var value = "THE LAZY DOG WALKS Home.";
			var expected = "The Lazy Dog Walks Home.";
			var wtc = new WordsToLowerUpperCase();

			// Act
			var actual = wtc.WordsToCapitalV2(value);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void WordsToLowerUpperCase_WordsToCapitalV2_ActualEqualExpected2()
		{
			// Arrange
			var value = "the lazy dog walks 1 block home.";
			var expected = "The Lazy Dog Walks 1 Block Home.";
			var wtc = new WordsToLowerUpperCase();

			// Act
			var actual = wtc.WordsToCapitalV2(value);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void WordsToLowerUpperCaseWordsToCapitalV2_ActualEqualExpected3()
		{
			// Arrange
			var value = "a LazY dOG waLkS homE.";
			var expected = "A Lazy Dog Walks Home.";
			var wtc = new WordsToLowerUpperCase();

			// Act
			var actual = wtc.WordsToCapitalV2(value);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void WordsToLowerUpperCase_ReadAllTextFromFileRunWordsToCapitalV1_ActualEqualExpected1()
		{
			var path = Path.Combine(TestDataPath, "test.txt");
			var value = File.ReadAllText(path);
			var expected = "The Quick Brown Fox Jumps Over The Lazy Dog.";

			// Arrange
			var wtc = new WordsToLowerUpperCase();

			// Act
			var actual = wtc.WordsToCapitalV1(value);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void WordsToLowerUpperCase_ReadAllTextFromFileRunWordsToCapitalV2_ActualEqualExpected2()
		{
			var path = Path.Combine(TestDataPath, "test.txt");
			var value = File.ReadAllText(path);
			var expected = "The Quick Brown Fox Jumps Over The Lazy Dog.";

			// Arrange
			var wtc = new WordsToLowerUpperCase();

			// Act
			var actual = wtc.WordsToCapitalV2(value);

			// Assert
			Assert.Equal(expected, actual);
		}
	}
}