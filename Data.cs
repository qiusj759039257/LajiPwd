/*
 * Created by SharpDevelop.
 * User: qiusj
 * Date: 2019/3/13
 * Time: 0:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace LajiPwd
{
	/// <summary>
	/// Description of Data.
	/// </summary>
	public partial class Data
	{
		private const string MAGIC_CODE = "LajiPwd";
		
		private static RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider();
		
		private static byte [] mkey;
		private static byte [] msalt;
		
		public static string Encrypt(string text)
		{
			byte [] key = GetKey();
			byte [] salted = SetSalt(text);
			byte [] iv = new byte[16];
			
			rnd.GetBytes(iv);
			byte [] encrypted = Cipher.encrypt(salted, key, iv);
			string b64_encrypted = Convert.ToBase64String(encrypted);
			
			return b64_encrypted;
		}
		
		public static string Decrypt(string b64_encrypted)
		{
			byte [] key = GetKey();
			byte [] encrypted = Convert.FromBase64String(b64_encrypted);
			byte [] salted = Cipher.decrypt(encrypted, key);
			string text = StripSalt(salted);
			
			return text;
		}
		
		private static byte [] SetSalt(string data)
		{
			byte [] ret = new byte[data.Length + 10];
			
			Encoding.UTF8.GetBytes("Salt_").CopyTo(ret, 0);
			rnd.GetBytes(ret, 5, 5);
			Encoding.UTF8.GetBytes(data).CopyTo(ret, 10);
			
			return ret;
		}
		
		private static string StripSalt(byte [] data)
		{
			string ret = Encoding.UTF8.GetString(data, 10, data.Length - 10);
			
			return ret;
		}
		
		private static byte [] Xor(byte [] key, byte [] salt)
		{
			byte [] ret = new byte[key.Length];
			
			for (int i = 0; i < key.Length; i++)
			{
				ret[i] = (byte)(key[i] ^ salt[i]);
			}
			
			return ret;
		}
		
		private static byte [] GetKey()
		{
			return Xor(mkey, msalt);
		}
		
		public static void SetKey(byte [] key)
		{
			msalt = new byte[key.Length];
			rnd.GetBytes(msalt);
			mkey = Xor(key, msalt);
		}
		
		public static void ReKey(byte [] key)
		{
			var everything = GetEverything();
			SetKey(key);
			foreach (var element in everything) {
				Update(element);
			}
			ReSaltKey();
		}
		
		public static void KillKey()
		{
			rnd.GetBytes(mkey);
			rnd.GetBytes(msalt);
		}
		
		private static void ReSaltKey()
		{
			SetKey(GetKey());
		}
	}
}
