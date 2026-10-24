using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
	public class Movie
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Видите имя фильма в поле ниже")]
		[StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
		[Range(typeof(DateOnly) ,"1888-10-14" , "2226-12-31", ErrorMessage = "Введите корректную дату выпуска фильма")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateOnly ReleaseDate { get; set; }
		public string URL { get; set; }
		public string Poster { get; set; }
	}
}
