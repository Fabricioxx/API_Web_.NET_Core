### Web Api .NET Core
Projetos de aplicativos .NET Core para serviços HTTP REST

passo a passo

* criar projeto terminal [ dotnet new web -o nomeProjeto -f net5.0 ] -f =para indicar a versão ou dotnet new webapi --name nomeProjeto -f net5.0
   >classe Startup.cs = classe de configuração
  
   >classe Program.cs = classe que starta o servidor
  
 * Instalar pacotes para trabalhar com Entity Framework ( usar banco de dados )
    > comando cli = dotnet add package Microsoft.EntityFrameworkCore.SqLite ( usar sqlite db)
   
    > comando cli = dotnet add package Microsoft.EntityFrameworkCore.Design ( para gerar migração do banco de dados )
   
 * Criar as pastas e classe mvc
   > Models = ( para os modelos )
   
    > Date = ( criar classe AppDbContext - para configurar e representar o db ORM )

    > Controllers = ( para criar a classe controller - entender a classe ControllerBase do pacote AspNetCore.Mvc para adicionar mais funcionalidades a classe ) 
   
 * Definir qual é o banco de dados e a string de conexão (
 
     > pela classe AppDbContext - com o metodo protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder) ou
    
     > pela classe Startup - dentro do metodo  ConfigureServices(IServiceCollection services) - services.AddDbContext<DataContext>
    
  *  Adicionar uma migração ef ao projeto ( sempre que alterar algo criar uma migração nova )
  
      > comando cli = dotnet ef migrations add InitialCreation
  
      > comando cli = dotnet ef database update - atualizar o banco ( primeira vez se for sqlite vai criar o arquivo do banco )
  
   * Adicionar a configuração da classe controller no metodo ConfigureServices da classe startup
  
       > services.AddControllers(); //adiciona o MVC
  
  * Adicionar o endipoint para os metodos da classe controller
  
      > endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); ou
  
      > endpoints.MapControllers();
            
  
  * Adicionar as actions do controller
  
    > listar, update, delete, create .etc
  
  
   
