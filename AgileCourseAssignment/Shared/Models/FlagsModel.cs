using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCourseAssignment.Shared.Models
{
    public class FlagsModel
    {
        [Key]

        public int Id { get; set; }

        public string CountryName { get; set; } = null!;
        public string Description { get; set; }
        public string Image { get; set; }

        public bool IsUsed { get; set; }
    }
}
