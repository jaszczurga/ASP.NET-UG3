using System.ComponentModel.DataAnnotations;

namespace CompanyOG.Models
{
    public class CountryRegion
    {
        public required string Code { get; set; }
        [Required(ErrorMessage ="Please enter name")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Name must have length between 3 and 20")]
        [RegularExpression("^[A-Z]+[a-zA-Z ]*$",ErrorMessage ="Only Letter")]
        public required string Name { get; set; }
        [Display(Name="Modified date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [DataType(DataType.Date)] //dziala normalniew update
        public DateTime Date { get; set; }
    }
}
