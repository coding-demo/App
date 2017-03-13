using System.ComponentModel.DataAnnotations;

namespace App.DataModels
{


    public class Vehicle
    {
        public int Id { get; set; }

        [Range(1950, 2050)]
        public int Year { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }
    }
}
