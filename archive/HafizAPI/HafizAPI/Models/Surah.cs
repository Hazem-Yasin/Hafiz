using System.ComponentModel.DataAnnotations;

namespace HafizApi.Models
{
    public class Surah
    {
        //can consider surah number as ID
        //as the surah number will not be repated in the quran
        public int SurahID { get; set; }
        ////this will not count the number of ayat in every surah it will just be a number
        public int NumberOfAyat { get; set; }
        [Required(ErrorMessage = "Surah Name is required")]
        //SurahName = title
        //the surah name will copy the title from the json db
        public string SurahName { get; set; }

        //every surah have multiple ayat
        //so we will copy it from the Ayah Model
        public ICollection<Ayah> Ayahs { get; set; }

    }
}

//every Ayah have only one Surah



//seeding process:
//SurahID = index
//SurahName = title
//NumberOfAyat = count

