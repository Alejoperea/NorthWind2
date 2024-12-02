HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();


using IHost AppHost = Builder.Build();


//IUserActionWriter Writer = new ConsoleWriter();
//IUserActionWriter Writer = new DebugWriter();
//IUserActionWriter Writer = new FileWriter();

IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Application started.");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azucar refinada");

/*
 * AppLoger y los Writers:Responsabilidad Unica
 * AppLogger: Abierto pero cerrado
 * AppLogger: Inversion de depencias. Los modulos de alto nivel son independiente de los detalles de implementacion
 * 
 * 
 */