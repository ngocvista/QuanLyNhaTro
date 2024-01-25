using MotelManagement.Core.IRepository;
using MotelManagement.Data.Models;

namespace MotelManagement.Core.Repository
{
    public class ArticlelRespository : BaseRepository<ArticleRoom>, IArticleRespository
    {
        public ArticlelRespository(MotelManagementContext context) : base(context)
        {
        }

        public Task CreateArticle(ArticleRoom room)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteArticle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArticleRoom>> GetArticleRooms()
        {
            throw new NotImplementedException();
        }
    }
}
