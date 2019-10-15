using System.Linq;
using System.Threading.Tasks;

namespace BobzBurger.Models
{
    public interface ICommentService
    {
        Task DeleteAsync(long id);
        Recipe Find(long id);
        Task<Recipe> FindAsync(long id);
        IQueryable<Recipe> GetAll(int? count = null, int? page = null);
        Task<Recipe[]> GetAllAsync(int? count = null, int? page = null);
        Task SaveAsync(Recipe recipe);
    }
}
