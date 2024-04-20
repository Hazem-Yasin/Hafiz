using System.ComponentModel.DataAnnotations;

namespace HafizApi.Models
{
    //base model class
    //this is the class that wil reflect  the table in the dB
    public class Ayah
    {
        //can't consider AyahNumber as ID or PK
        //as surah number will be repated in every surah
        //example surah baqra have ayah 22 and surah al imran have ayah 22

        //this is the primary key
        public int AyahID { get; set; }
        public int AyahNumber { get; set; }

        [Required(ErrorMessage ="Ayah verse is required")]
        public string AyahText { get; set; }
        //FK
        public int SurahNumberID { get; set; }

        //navigation properties -- relationships
        //every ayah have one Surah
        public Surah surah { get; set; }
    }
}
