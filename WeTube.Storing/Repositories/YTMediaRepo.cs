using System.Collections.Generic;
using WeTube.Domain.Models;
using WeTube.Storing.Entities;

namespace WeTube.Storing.Repositories
{
  public class YTMediaRepo
  {
    private List<DVideo> _YTMediaLibrary = new List<DVideo>();
    public WeTubeContext wTContext = new WeTubeContext();

    public List<DVideo> YTMediaLibrary
    {
      get
      {
        return _YTMediaLibrary;
      }
    }

    public YTMediaRepo()
    {
      Initialize();
    }

    public List<DVideo> Initialize()
    {
      if(_YTMediaLibrary == null)
      {
        _YTMediaLibrary = new List<DVideo>();

        //populate from database
      }

      return _YTMediaLibrary;
    }

    public List<DVideo> AddVideo(DVideo newVideo)
    {
      _YTMediaLibrary.Add(newVideo);

      //push to database

      return _YTMediaLibrary;
    }
  }
}