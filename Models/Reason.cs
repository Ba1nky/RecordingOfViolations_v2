using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RecordingOfViolations.Models
{
    public class Reason
    {
        public int ReasonId { get; set; }

        [Required(ErrorMessage = "Please enter a reason")]
        public string Name { get; set; } = String.Empty;

        public List<Violation> Violations { get; set; } = new List<Violation>();
    }
}
