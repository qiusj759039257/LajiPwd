/*
 * Created by SharpDevelop.
 * User: qiusj
 * Date: 2019/3/13
 * Time: 23:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SQLite;

namespace LajiPwd
{
	/// <summary>
	/// Description of Data_Entity.
	/// </summary>
	public class DataEntity
	{
		public int id;
		public string title;
		public string remark;
		public string account;
		public string password;
		
		public DateTime create;
		public DateTime update;
//		public DateTime delete;
		
		public DataEntity() 
		{
			id = 0;
			title = "";
			remark = "";
			account = "";
			password = "";
			create = update = DateTime.Now;
		}
		
		public DataEntity(SQLiteDataReader reader)
		{
			id = reader.GetInt32(0);
			title = reader.GetString(1);
			remark = reader.GetString(2);
			account = reader.GetString(3);
			password = reader.GetString(4);
			try {
				create = reader.GetDateTime(5);
				update = reader.GetDateTime(6);
			} catch (Exception) {
				create = DateTime.Now;
				update = DateTime.Now;
			}
			
		}
	}
}
