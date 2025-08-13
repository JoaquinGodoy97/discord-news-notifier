using NewsServiceApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<INewsService, NewsService>();

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.Run();

// class Program
// {
//     static async Task Main(string[] args)
//     {
//         using HttpClient client = new HttpClient();
//         var response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
//         Console.WriteLine(response);
//     }
// }