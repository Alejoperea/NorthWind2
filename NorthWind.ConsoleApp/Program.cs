HostApplicationBuilder Builder = Host.CreateApplicationBuilder();
Builder.Services.AddSingleton<IUserActionWriter, DebugWriter>();
Builder.Services.AddSingleton<IUserActionWriter, ConsoleWriter>();
Builder.Services.AddSingleton<IUserActionWriter, FileWriter>();
Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();
using IHost AppHost = Builder.Build();


//IUserActionWriter Writer = new ConsoleWriter();
//IUserActionWriter Writer = new DebugWriter();
//IUserActionWriter Writer = new FileWriter();

AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();
Logger.WriteLog("Application started.");

ProductService Service = AppHost.Services.GetRequiredService<ProductService>();
Service.Add("Demo", "Azucar refinada");

/*
 * AppLoger y los Writers:Responsabilidad Unica
 * AppLogger: Abierto pero cerrado
 * AppLogger: Inversion de depencias. Los modulos de alto nivel son independiente de los detalles de implementacion
 * 
 * 
 */