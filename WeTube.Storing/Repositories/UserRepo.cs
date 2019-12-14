using System.Collections.Generic;
using WeTube.Storing.Entities;
using WeTube.Domain.DModels;

namespace WeTube.Storing.Repositories
{
  public class UserRepo
  {
    private List<DUser> _userLibrary = new List<DUser>();
    public WeTubeContext wTContext = new WeTubeContext();

    public List<DUser> UserLibrary 
    { 
      get
      {
        return _userLibrary;
      }
    }

    public UserRepo()
    {
      Initialize();
    }

    public List<DUser> Initialize()
    {
      if(_userLibrary == null)
      {
        _userLibrary = new List<DUser>();

        //populate from database
      }

      return _userLibrary;
    }

    public List<DUser> AddUser(DUser newUser)
    {
      _userLibrary.Add(newUser);

      //map and add to database

      return _userLibrary;
    }
  }
}