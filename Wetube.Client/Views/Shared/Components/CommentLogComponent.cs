using Microsoft.AspNetCore.Mvc;
using Wetube.Client.Models;

namespace Wetube.Client.Views.Shared
{
  public class CommentLogComponent : ViewComponent
  {
    public IViewComponentResult Invoke()
    {
      CommentVM comment = new CommentVM();

      return View("CommentForm", comment);
    }
  }
}