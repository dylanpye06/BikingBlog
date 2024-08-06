using BikingBlog.Web.Models.Domain;

namespace BikingBlog.Web.Repositories
{
    public interface ITagRepository
    {
        Task<IEnumerable<Tag>> GetAllAsync();

        Task<Tag?> GetAsync(Guid id);

        Task<Tag>AddAsync(Tag tag);

        Task<Tag?> UpdateAsync(Tag tag);

        Task<Tag?> DeleteAsync(Guid id);

        // questions mark - if it doesnt find an account to delete / find orupdtate it will return a null
    }
}
