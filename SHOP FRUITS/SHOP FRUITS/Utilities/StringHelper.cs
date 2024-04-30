using System.Collections.Generic;
namespace CoffeeManagement.Utilities
{
	public static class StringHelper
	{
		private static string _vnCharactersWithTones = "áàảãạâấầẩẫậăắằẳẵặđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵ";
		private static string _replaceCharacters = "aaaaaaaaaaaaaaaaadeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyy";
		public static string ToLowerVietnameseNoTones(this string input)
		{
			input = input.ToLower();
			if (!input.IsVietnameseWithTones())
			{
				return input;
			}

			int i = -1;
			while ((i = _vnCharactersWithTones.IndexOfAny(input.ToCharArray()))  != -1)
			{
				if (i != -1)
				{
					input = input.Replace(_vnCharactersWithTones[i], _replaceCharacters[i]);
				}
			}
			
			return input;
		}

		public static bool IsVietnameseWithTones(this string input)
		{
			return input.IndexOfAny(_vnCharactersWithTones.ToCharArray()) != -1;
		}

		public static string JoinList(string separator, List<string> list)
		{
			return string.Join(separator + " ", list);
		}
	}
}
