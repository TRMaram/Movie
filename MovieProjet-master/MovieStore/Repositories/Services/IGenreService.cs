using MovieStore.Models.Domain;
using MovieStore.Models.DTO;

namespace MovieStore.Repositories.Services
{
    public interface IGenreService
    {


        
        bool Add(Genre model);
        bool Update(Genre model);
        Genre GetById(int id);
        bool Delete(int id);
        IQueryable<Genre> List();
    }
}
