using System.ComponentModel.DataAnnotations;

namespace CoreValidation_0.Models.Categories.PureVMs.RequestModels
{

    //Server Side Validation
    //Client Side Validation
    public class CreateCategoryRequestModel
    {
        //DataAnnotation'da yer tutucu operatorleri sayılarla verilir...0 , ilgili property neyse onun ismini alır...

        [Required(ErrorMessage ="{0} zorunlu bir alandır")]
        [MaxLength(15,ErrorMessage ="{0} en fazla {1} karakter alabilir")]
        [MinLength(5,ErrorMessage ="{0} en az {1} karakter alabilir")]
        [Display(Name = "Kategori İsmi")]
        public string CategoryName { get; set; }


        [Required(ErrorMessage ="{0} zorunlu bir alandır")]
        [MinLength(10,ErrorMessage ="{0} en az {1} karakter alabilir")]
        [Display(Name ="Acıklama")]
        public string Description { get; set; }

    }
}
