// See https://aka.ms/new-console-template for more information
using cimplifi_http;

string url1 = "https://jsonplaceholder.typicode.com/todos/";
string url2 = "https://jsonplaceholder.typicode.com/users/";

HttpClient client = new ();
HttpProvider provider = new (client);

FetchData fetchData = new (provider);

string [] results = await fetchData.FetchDataConcurrently(url1,url2);

Console.WriteLine($"Length of data from {url1} is {results[0].Length}");
Console.WriteLine($"Length of data from {url2} is {results[1].Length}");