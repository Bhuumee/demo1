using System;
using System.Text;

namespace Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] a = { 'a', 'e', 'i', 'o', 'u' };
			String s1 = new String(a);
			Console.WriteLine(s1);
			String s2 = "welcome home";
			Console.WriteLine(s2);
			Console.ReadLine();

			StringBuilder addWord = new StringBuilder("word1");
			addWord.Append("word2");
			addWord.Append("word3");
			Console.WriteLine(addWord);
			Console.ReadLine();

			StringBuilder s3 = new StringBuilder("word1");
			s3.Append("words2");
			s3.Remove(0, 4);
			Console.WriteLine(s3);
			Console.ReadLine();
		}
	}
}
