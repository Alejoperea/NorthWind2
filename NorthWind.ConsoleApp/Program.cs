
using NorthWind.ConsoleApp.Services;
using NorthWindd.Entities.Interfaces;
using NorthWind.Writers;

//IUserActionWriter Writer = new ConsoleWriter();
//IUserActionWriter Writer = new DebugWriter();
IUserActionWriter Writer = new FileWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started.");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azucar refinada");

/*
 * AppLoger y los Writers:Responsabilidad Unica
 * AppLogger: Abierto pero cerrado
 * AppLogger: Inversion de depencias. Los modulos de alto nivel son independiente de los detalles de implementacion
 * 
 * 
 */