namespace FurnitureFactory_MVC_Project.Models.Services.Article_Services
{
    using System.Collections.Generic;

    public interface IArticleRepository
    {
        IEnumerable<Article> GetAllArticles();

        Article GetArticle(int id);

        Article Update(Article updatedArticle);

        Article Add(Article newArticle);

        Article Delete(int id);
    }
}
