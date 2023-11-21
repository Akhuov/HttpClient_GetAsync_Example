Console.WriteLine("Приложение начало работу");
using (var client = new HttpClient())
{
    using var result = await client.GetAsync("https://api.publicapis.org/entries");
    Console.WriteLine(result);
 }
 Console.WriteLine("Приложение завершило работу");
