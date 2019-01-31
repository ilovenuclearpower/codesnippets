

private readonly HttpClient _httpClient = new HttpClient();
//Establishes a new HTTPClient object, and associated methods.
[HttpGet]
[Route("DotNetCount")]
//Adds HttpGet and the Route to the attributes for the class.
public async Task<int> GetDotNetCountAsync()
{
    // Suspends GetDotNetCountAsync() to allow the caller (the web server)
    // to accept another request, rather than blocking on this one.
    var html = await _httpClient.GetStringAsync("https://dotnetfoundation.org");
    //Suspends the process, freeing up a thread and establishing a callback signal when complete.

    return Regex.Matches(html, @"\.NET").Count;
    //returns whether or not the string that was fetched matches the regular expression, in this case a string literal - and the count.
}
