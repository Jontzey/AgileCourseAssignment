using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCourseAssignment.Shared.Models
{
    public class HighScoreModel
    {

        [Key]

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Score { get; set; } 

        public int Time { get; set; }
    }
}
