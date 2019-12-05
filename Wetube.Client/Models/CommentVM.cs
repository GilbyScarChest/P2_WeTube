using System;
using System.Collections;

namespace Wetube.Client.Models
{
    public class CommentVM
    {
        public int CommentId { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentText { get; set; }
    }
}