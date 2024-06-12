using System.ComponentModel.DataAnnotations;

namespace HafizApi.Models
{
    public class Surah
    {
        //can consider surah number as ID
        //as the surah number will not be repated in the quran
        public int SurahNumberID { get; set; }
        public int NumberOfAyat { get; set; }
        [Required(ErrorMessage = "Surah Name is required")]
        public string SurahName { get; set; }

        //every surah have multiple ayat
        public ICollection<Ayah> Ayahs { get; set; }

    }
}

//every Ayah have only one Surah