using System;
using System.Collections;

namespace WeTube.Domain.DModels
{
   public class DComment
   {
      //a comment should have a time variable that is used to keep track of the moment it was named

      //if tyler passes the comment through as a string then I'll receive it as a string:
      //string comment;
      //each comment needs to have a time associated with it, this can be the number of seconds since receiving it?
      //DateTime time = DateTime.Now;
      //string TimeReceived = DateTime.Now.ToString("h:mm:ss tt"); //this takes the time passed since midnight (would put it in a normal time stamp)
      //taking a user account name
      //string user; //the username of the person making the comment

      //create a comment and timereceived array? would also need to track the user who made the comment



      //strictly created from the database
      //public int Id { get; set; }
      public DateTime TimeReceived { get; set; }
      public string Text { get; set; }
      public DateTime TimeStamp { get; set; }

      public DComment(string CommentText, DateTime CommentDate, DateTime MediaTimeStamp)
      {
         Text = CommentText;
         TimeReceived = CommentDate;
         //Id = CommentId;
         TimeStamp = MediaTimeStamp;

      }      
   }
}