using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GenericCollections
{

    internal class DataAnotaionAuthorDetails
    {
        [Required (ErrorMessage ="{0} is required")]
        [StringLength (50,MinimumLength =3,ErrorMessage ="minimum length should be 3 and maximum length should be 50")]
        [DataType(DataType.Text)]
        public string Fname { get; set; }

        [Required(ErrorMessage ="{0} is requird")]
        [StringLength(50,MinimumLength =3,ErrorMessage = "minimum length should be 3 and maximum length should be 50")]
        [DataType(DataType.Text)]
        public string Lname { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Phoneno { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

       public static void validationAuthorDetails()
        {

            DataAnotaionAuthorDetails author = new DataAnotaionAuthorDetails();
            author.Fname = "Joya";
            author.Lname = "";
            author.Phoneno = "1234567890";
            author.Email = "joydipkanjilal@yahoo.com";


            ValidationContext context = new ValidationContext(author, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(author, context, result, true);
            if (!valid)
            {
                foreach(ValidationResult validationResult in result)
                {
                    Console.WriteLine(validationResult.ErrorMessage); 
                }
            }
        }

    }
}
