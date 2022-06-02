namespace IMDB_Lab.Models.DataAccessLayer
{
    public interface IIMDBRepository
    {
        Task<IMDBResponse> SearchMovie(string searchTerm);
    }
}
