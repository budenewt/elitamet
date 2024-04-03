public async Task<string> GetRepositoryAsync()
{
    try
    {
        // Simulate an asynchronous operation that retrieves data.
        string repositoryData = await RetrieveDataAsync();
        return repositoryData;
    }
    catch (Exception ex)
    {
        // Log the exception details here or handle them as required.
        Console.WriteLine($"An error occurred: {ex.Message}");
        return null; // Return null or an appropriate default value in case of an error.
    }
}

private async Task<string> RetrieveDataAsync()
{
    // Simulate an async operation, e.g., fetching data from a database or an API.
    await Task.Delay(1000); // Simulating delay for the async operation.
    return "DummyRepo"; // Return the actual data from the async operation.
}
