﻿using System;
using System.Data.SqlClient;
using Fw.Models;

namespace Fw.Models.mapper
{
	public static class UserMapper
	{
		public static User MapToUser(SqlDataReader reader)
		{
			User user = new User();
			user.Id = reader.GetInt32(reader.GetOrdinal("id"));
			user.UserName = reader["username"] as string;
			user.Password = reader["password"] as string;
			user.Role = reader["role"] as string;
			user.Firstname = reader["firstname"] as string;
			user.Lastname = reader["lastname"] as string;
			user.Status = reader.GetByte(reader.GetOrdinal("status")) != 0;
			user.ModifiedBy = reader.GetInt32(reader.GetOrdinal("modified_by"));
			user.ModifiedDate = reader.GetDateTime(reader.GetOrdinal("modified_date"));
			return user;
		}
	}
}