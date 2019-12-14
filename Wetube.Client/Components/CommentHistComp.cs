using Microsoft.AspNetCore.Mvc;
using Wetube.Client.Models;

namespace Wetube.Client.Components
{
  public class CommentHistComp : ViewComponent
  {
    //CommentHistory history = new CommentHistory();

    public IViewComponentResult Invoke()
    {
      CommentHistory history = new CommentHistory();

      return View("CommentLog", history);
    }
  }
}