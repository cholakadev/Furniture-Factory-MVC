namespace FurnitureFactory_MVC_Project.Models.Services.Article_Services
{
    using FurnitureFactory_MVC_Project.Models.DataAccess;
    using System.Collections.Generic;

    public class SQLArticleRepository : IArticleRepository
    {
        private readonly FurnitureFactoryDbContext _context;

        public SQLArticleRepository(FurnitureFactoryDbContext context)
        {
            this._context = context;
        }

        public Article Add(Article newArticle)
        {
            this._context.Articles.Add(newArticle);
            this._context.SaveChanges();

            return newArticle;
        }

        public Article Delete(int id)
        {
            Article article = this._context.Articles.Find(id);

            if (article != null)
            {
                this._context.Articles.Remove(article);
            }

            return article;
        }

        public IEnumerable<Article> GetAllArticles()
        {
            return this._context.Articles;
        }

        public Article GetArticle(int id)
        {
            Article article = this._context.Articles.Find(id);

            return article;
        }

        public Article Update(Article updatedArticle)
        {
            this._context.Update(updatedArticle);
            this._context.SaveChanges();

            return updatedArticle;
        }
    }
}
