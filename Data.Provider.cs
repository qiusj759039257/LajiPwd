/*
 * Created by SharpDevelop.
 * User: qiusj
 * Date: 2019/3/13
 * Time: 22:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;

namespace LajiPwd
{
	/// <summary>
	/// Description of Data_Provider.
	/// </summary>
	partial class Data
	{
		private static SQLiteConnection connection;
		private static string TABLE_DDL = Resource.table_ddl;
		private static string INIT_MAGIC = Resource.init_magic;
				
		public static void InitDatabase(bool create = false)
		{
			
			if (create)
			{
				SQLiteConnection.CreateFile("password.db");
				
				connection = new SQLiteConnection("Data Source=password.db");
				connection.Open();
				
				using (var t = connection.BeginTransaction()) {
					
					using (var command = new SQLiteCommand(connection)) {
						
						command.CommandText = TABLE_DDL;
						command.ExecuteNonQuery();
						
						command.CommandText = INIT_MAGIC;
						command.Parameters.Add(new SQLiteParameter(DbType.Int32) { Value = 0 });
						command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = "MAGIC_CODE" });
						command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = "Magic Code" });
						command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = MAGIC_CODE });
						command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = Encrypt(MAGIC_CODE) });
						command.Parameters.Add(new SQLiteParameter(DbType.DateTime) { Value = DateTime.Now });
						command.Parameters.Add(new SQLiteParameter(DbType.DateTime) { Value = DateTime.Now });
						command.Parameters.Add(new SQLiteParameter(DbType.DateTime) { Value = DateTime.Now });
						command.ExecuteNonQuery();
					}
					
					t.Commit();
				}
				
			}
			else
			{
				connection = new SQLiteConnection("Data Source=password.db");
				connection.Open();
			}
			
		}
		
		public static bool ValidateKey()
		{
			var data = GetById(0);
			return data.password.Equals(MAGIC_CODE);
		}
		
		public static void Insert(DataEntity data)
		{
			var command = new SQLiteCommand(connection);

			command.CommandText = 
				@"INSERT INTO `password` (`title`, `remark`, `account`, `password`, `create`, `update`) VALUES (?, ?, ?, ?, ?, ?)";
			command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = data.title });
			command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = data.remark });
			command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = data.account });
			command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = Data.Encrypt(data.password) });
			command.Parameters.Add(new SQLiteParameter(DbType.DateTime) { Value = DateTime.Now });
			command.Parameters.Add(new SQLiteParameter(DbType.DateTime) { Value = DateTime.Now });
			
			command.ExecuteNonQuery();
		}
		
		public static DataEntity GetById(int id)
		{
			var command = new SQLiteCommand(connection);

			command.CommandText = "SELECT * FROM `password` WHERE `id` = ?";
			command.Parameters.Add(new SQLiteParameter(DbType.Int32) { Value = id });
			
			var reader = command.ExecuteReader();
			reader.Read();
			
			var data = new DataEntity(reader);
			data.password = Decrypt(data.password);
			
			reader.Close();
			
			return data;
		}

		public static List<DataEntity> GetAll()
		{
			var command = new SQLiteCommand(connection);

			command.CommandText = "SELECT * FROM `password` WHERE `delete` = 0";
			var reader = command.ExecuteReader();
			
			var ret = new List<DataEntity>();
			
			while (reader.Read())
			{
				ret.Add(new DataEntity(reader));
			}
			
			reader.Close();
			
			return ret;
		}
		
		public static List<DataEntity> GetByKeyword(string keyword)
		{
			var command = new SQLiteCommand(connection);

			command.CommandText = "SELECT * FROM `password` WHERE `title` LIKE ? AND `delete` = 0";
			command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = String.Format("%%{0}%%", keyword) });
			
			var reader = command.ExecuteReader();
			
			var ret = new List<DataEntity>();
			
			while (reader.Read())
			{
				ret.Add(new DataEntity(reader));
			}
			
			reader.Close();
			
			return ret;
		}
		
		private static List<DataEntity> GetEverything()
		{
			var command = new SQLiteCommand(connection);

			
			command.CommandText = "SELECT * FROM `password`";
			var reader = command.ExecuteReader();
			
			var ret = new List<DataEntity>();
			
			while (reader.Read())
			{
				var data = new DataEntity(reader);
				data.password = Decrypt(data.password);
				ret.Add(data);
			}
			
			reader.Close();
			
			return ret;
		}
		
		public static void Update(DataEntity data)
		{
			var command = new SQLiteCommand(connection);
			
			command.CommandText = 
				"UPDATE `password` SET `title` = ?, `remark` = ?, `account` = ?, `password` = ?, `update` = ? WHERE `id` = ?";
			command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = data.title });
			command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = data.remark });
			command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = data.account });
			command.Parameters.Add(new SQLiteParameter(DbType.String) { Value = Data.Encrypt(data.password) });
			command.Parameters.Add(new SQLiteParameter(DbType.DateTime) { Value = DateTime.Now });
			command.Parameters.Add(new SQLiteParameter(DbType.Int32) { Value = data.id });
			
			command.ExecuteNonQuery();
		}
		
		public static void Delete(int id)
		{
			var command = new SQLiteCommand(connection);

			command.CommandText = "UPDATE `password` SET `delete` = ? WHERE `id` = ?";
			command.Parameters.Add(new SQLiteParameter(DbType.DateTime) { Value = DateTime.Now });
			command.Parameters.Add(new SQLiteParameter(DbType.Int32) { Value = id });
			
			command.ExecuteNonQuery();
		}
	}
}
