using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace MovieStore.Models.Domain
{
    public class MovieGenre
    {
        public int Id { get; set; }
        
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}
