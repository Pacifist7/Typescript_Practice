namespace IMDB_Lab.Models.DataAccessLayer
{
    public class IMDBRepository : IIMDBRepository
    {
        public async Task<IMDBResponse> SearchMovie(string searchTerm)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://www.omdbapi.com");

            var response = await client.GetFromJsonAsync<IMDBResponse>("?t=" + searchTerm + "&apiKey=13b1afb1");

            return response;
        }
    }
}
