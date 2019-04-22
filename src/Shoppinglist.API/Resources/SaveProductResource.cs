using Shoppinglist.API.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Shoppinglist.API.Resources
{
    public class SaveProductResource
    {
        [Required]
        [MaxLength(30)]      
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }    
    }
}