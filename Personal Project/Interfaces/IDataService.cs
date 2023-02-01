using Personal_Project.Models;

namespace Personal_Project.Interfaces
{
    public interface IDataService
    {
        Task Create(Post model);
        Task<List<Post>> GetAll();
    }
}
