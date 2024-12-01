﻿using NorthWindd.Entities.Interfaces;
using NorthWindd.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.ConsoleApp.Services
{
	internal class AppLogger(IUserActionWriter writer)
	{
		public void WriteLog(string message) 
		{
			UserAction Log = new UserAction("System", message);
			writer.Writer(Log);
		}
	}
}