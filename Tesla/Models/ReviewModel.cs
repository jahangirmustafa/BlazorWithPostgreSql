using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tesla.Models
{
    public class ReviewModel
    {
        [Required]
        public string Content { get; set; }
    }
}
