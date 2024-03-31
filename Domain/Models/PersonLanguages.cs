using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume1.Models;  
    public class PersonLanguages
{                     
    public int PersonId { get; set; }
    public Person Person { get; set; }

    public int LanguageId { get; set; }
    public Languages? Languages { get; set; }

}
