using System;

namespace WeTube.Storing.Entities
{
  public class SComments
  {
    public int CommentId { get; set; }
    public string Comment { get; set; }
    public DateTime CommentDate { get; set; }
    public int Timestamp { get; set; }

    public SYTMedia MediaId { get; set; }
    public SUsers UserId { get; set; }
  }
}