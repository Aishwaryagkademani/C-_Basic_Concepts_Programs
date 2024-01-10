using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace GenericCollections
{
    internal class SampleExamplesOnDataAnotations
    {
        [StringLength(25,MinimumLength =3)]
        public string fname { get; set; }

        [Range(1,5)]
        public int EvaluationOnScore { get; set; }

        [Required,MaxLength(10),MinLength(3)]
        public string FavoriteWorkday { get; set; }

        [RegularExpression("^[0-9]{5}$")]
        public string zipcode { get; set; }

        public static void DataValidation()
        {
            SampleExamplesOnDataAnotations obj = new SampleExamplesOnDataAnotations();
            obj.fname = "Rama";
            obj.EvaluationOnScore = 100;
            obj.FavoriteWorkday = "monday";
            obj.zipcode = "95854";
            var context =new ValidationContext(obj, null, null);

            List<ValidationResult> results = new List<ValidationResult>(); 
            bool valid = Validator.TryValidateObject(obj, context, results, true);
            if(!valid )
            {
                Console.WriteLine("Data assigned are wrong");
                foreach(ValidationResult result in results )
                {
                    Console.WriteLine(result.ErrorMessage);
                }
            }
        }
    }
}
