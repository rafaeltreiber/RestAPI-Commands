using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandreadDto
    {   
        public int Id { get; set; } 
        public string HowTo { get; set; } 
        public string Line { get; set; } 
    }
}