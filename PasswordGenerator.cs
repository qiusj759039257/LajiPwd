/*
 * Created by SharpDevelop.
 * User: qiusj
 * Date: 2019/3/12
 * Time: 21:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace LajiPwd
{
	/// <summary>
	/// Description of PasswordGenerator.
	/// </summary>
	public class PasswordGenerator
	{
		private char [][] __word = new [] {
			new char [] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'},

			new char [] {
				'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
				'W', 'X', 'Y', 'Z'
			},
	
			new char [] {
				'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
				'w', 'x', 'y', 'z'
			},
			
			new char [] {
				'!', '\'', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@',
				'[', '\\', ']', '^', '_', '`', '{', '|', '}', '~'
			},
		};
		
		private readonly List<char> symbol = new List<char>();
		
		public const int NUMERIC = 1;
		public const int ALPHABET_UPPER = 2;
		public const int ALPHABET_LOWER = 4;
		public const int SPECIAL_CHAR = 8;
		
		public PasswordGenerator(int flag)
		{
			for (int i = 0; i < 4; i++)
			{
				if ((flag & 1 << i) != 0)
				{
					symbol.AddRange(__word[i]);
				}
			}
		}
		
		public string generate(int digit)
		{
			string ret = "";
			byte [] seed = new byte[4];
			
			var csp = new RNGCryptoServiceProvider();
			csp.GetBytes(seed);
			
			var rnd = new Random(BitConverter.ToInt32(seed, 0));
			
			for (int i = 0; i < digit; i++)
			{
				ret += symbol[rnd.Next(symbol.Count)];
			}
			
			return ret;
		}
	}
}
