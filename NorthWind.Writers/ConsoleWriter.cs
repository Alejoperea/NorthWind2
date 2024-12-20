﻿using NorthWindd.Entities.Interfaces;
using NorthWindd.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writers
{
	internal class ConsoleWriter : IUserActionWriter
	{
		public void Writer(UserAction action)
		{
			Console.WriteLine("ConsoleWriter: {0}, {1}, {2}",
				action.CreateDateTime,action.User,action.Description);
		}
	}
}
