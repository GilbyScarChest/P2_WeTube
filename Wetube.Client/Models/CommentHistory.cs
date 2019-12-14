using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wetube.Client.Models
{
    public class CommentHistory
    {
        public List<CommentVM> CommentLog { get; set; }
    }
}