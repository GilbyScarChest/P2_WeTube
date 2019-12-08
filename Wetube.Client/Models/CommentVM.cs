using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Wetube.Client.Models
{
    public class CommentVM
    {
        public int CommentId { get; set; }
        public DateTime CommentDate { get; set; }
        [DataType(DataType.MultilineText)]
        public string CommentText { get; set; }
        public DateTime MediaTimestamp { get; set; }
    }
}