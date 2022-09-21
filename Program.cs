using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp11
{
	class Program
	{
		static void Main(string[] args)
		{
			int shift = Convert.ToInt32(Console.ReadLine());
			string ins = Console.ReadLine();
			string ous = caesarCipher(ins, shift);

			Console.WriteLine(ous);
			Console.ReadKey();
		}

		public static string caesarCipher(string s, int k)
		{
			var ous = new List<char>();

			string alphabet = "abcdefghijklmnopqrstuvwxyz";

			int shifted = 0;
			shifted = k % alphabet.Length;
			string shiftedAlphabet = alphabet.Substring(shifted, alphabet.Length - shifted) + alphabet.Substring(0, shifted);

			foreach (var c in s)
			{
				int index = alphabet.IndexOf(Char.ToLower(c));
				if(index == -1)
				{					
					ous.Add(c);
				}
				else
				{
					char shiftedC = Char.IsUpper(c) ? Char.ToUpper(shiftedAlphabet[index]) : shiftedAlphabet[index];
					ous.Add(shiftedC);
				}
				
			}

			return new string(ous.ToArray());
		}
	}
}
