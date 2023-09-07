using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCourseAssignment.Shared.Models
{
    public class News
    {


        [Key]

        public int Id { get; set; }

        public string Titel { get; set; } = null!;

        public string BodyInformation { get; set; } = null!;
    }
}
