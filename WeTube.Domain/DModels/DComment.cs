using System;
using System.Collections;
using System.Collections.Generic;

namespace WeTube.Domain.DModels
{
   public class DComment
   {
      //strictly created from the database
      //public int Id { get; set; }
      public DateTime TimeReceived { get; set; }
      public string Text { get; set; }
      public DateTime TimeStamp { get; set; }
      public string videoID { get; set; }
      public int userID { get; set; }

      public DComment(string CommentText, DateTime CommentDate, DateTime MediaTimeStamp, string vidID, int userid)
      {
         Text = CommentText;
         TimeReceived = CommentDate;
         //Id = CommentId;
         TimeStamp = MediaTimeStamp;
         videoID = vidID;
         userID = userid;
      }

      //returns a List of Comment objects, 
      public List<DComment> DCommentLog()
      {
        List<DComment> commentsMade = new List<DComment>();
        DComment practiceComment = new DComment("hello", DateTime.Now, DateTime.Now, "fakeId", 1);
        commentsMade.Add(practiceComment);

        return commentsMade;
      }

      public List<DComment> DCommentAt(DateTime received)
      {
        List<DComment> commentsAt = new List<DComment>();
        return commentsAt;
      }
   }
}