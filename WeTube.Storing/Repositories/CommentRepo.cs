using System.Collections.Generic;
using WeTube.Domain.DModels;
using WeTube.Storing.Entities;

namespace WeTube.Storing.Repositories
{
  public class CommentRepo
  {
    private List<DComment> _commentLibrary;
    public WeTubeContext wTContext = new WeTubeContext();

    public List<DComment> CommentLibrary 
    { 
      get
      {
        return _commentLibrary;
      }
    }

    public CommentRepo()
    {
      Initialize();
    }

    public List<DComment> Initialize()
    {
      if(_commentLibrary == null)
      {
        _commentLibrary = new List<DComment>();

        //populate from database
      }

      return _commentLibrary;
    }

    public List<DComment> AddComment(DComment newComment)
    {
      _commentLibrary.Add(newComment);

      //map and add to database
      
      return _commentLibrary;
    }

    public List<DComment> GetCommentsByVideo(string vidID)
    {
      List<DComment> videoComments = new List<DComment>();

      foreach(DComment dc in _commentLibrary)
      {
        if(vidID == dc.videoID)
        {
          videoComments.Add(dc);
        }
      }

      return videoComments;
    }

    public List<DComment> GetCommentsByUser(int userID)
    {
      List<DComment> userComments = new List<DComment>();

      foreach(DComment dc in _commentLibrary)
      {
        if(userID == dc.userID)
        {
          userComments.Add(dc);
        }
      }

      return userComments;
    }
  }
}