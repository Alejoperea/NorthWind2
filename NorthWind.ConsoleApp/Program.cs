
using NorthWind.ConsoleApp.Services;
using NorthWindd.Entities.Interfaces;

IUserActionWriter Writer = default;
AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started.");