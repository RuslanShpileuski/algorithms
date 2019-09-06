using System;
using System.Text;

/*

	We need a method that accepts a string as input, and returns it in title case as the output.

	What is Title Case?
	Title case means that the first letter of each word is capitalized.

	Examples:
	  Input: "THE LAZY DOG WALKS Home."
	  Ouput: "The Lazy Dog Walks Home."

	  Input: "the lazy dog walks 1 block home."
	  Ouput: "The Lazy Dog Walks 1 Block Home."

	  Input: "a LazY dOG waLkS homE."
	  Ouput: "A Lazy Dog Walks Home."
*/

namespace WordsToLowerUpperCase
{
	public class WordsToLowerUpperCase
	{
		public string WordsToCapitalV1(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException("value");
			}

			var sb = new StringBuilder();

			for (int i = 0; i < value.Length; i++)
			{
				char curr = value[i];
				
				if (char.IsLetter(curr))
				{
					if (i > 0)
					{
						char prev = value[i - 1];

						if (char.IsLower(curr) && char.IsWhiteSpace(prev))
						{
							curr = char.ToUpper(curr);
						}
						else if(char.IsUpper(curr) && !char.IsWhiteSpace(prev))
						{
							curr = char.ToLower(curr);
						}
					}
					else if (char.IsLower(curr))
					{
						curr = char.ToUpper(curr);
					}
				}

				sb.Append(curr);
			}

			return sb.ToString();
		}

		public string WordsToCapitalV2(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException("value");
			}

			var result = value.ToCharArray();

			int min = 0;
			int max = result.Length - 1;

			while (max > min)
			{
				char left = value[min];
				char right = value[max];
				
				if (char.IsLetter(left))
				{
					if (min > 0)
					{
						char previousLeft = value[min - 1];

						if (char.IsLower(left) && char.IsWhiteSpace(previousLeft))
						{
							result[min] = char.ToUpper(left);
						}
						else if(char.IsUpper(left) && !char.IsWhiteSpace(previousLeft))
						{
							result[min] = char.ToLower(left);
						}
					}
					else if (char.IsLower(left))
					{
						result[min] = char.ToUpper(left);
					}
				}

				if (char.IsLetter(right))
				{
					if (max < result.Length - 1)
					{
						char nextRight = value[max - 1];

						if (char.IsLower(right) && char.IsWhiteSpace(nextRight))
						{
							result[max] = char.ToUpper(right);
						}
						else if (char.IsUpper(right) && !char.IsWhiteSpace(nextRight))
						{
							result[max] = char.ToLower(right);
						}
					}
					else if (char.IsLower(left))
					{
						result[max] = char.ToUpper(left);
					}
				}

				min++;
				max--;
			}

			return new string(result);
		}
	}
}