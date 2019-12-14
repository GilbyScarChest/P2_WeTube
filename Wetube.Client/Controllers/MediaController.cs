
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Wetube.Client.Models;

namespace Wetube.Client.Controllers
{
    public class MediaController : Controller
    {
        private readonly ILogger<MediaController> _logger;

        public MediaController(ILogger<MediaController> logger)
        {
            _logger = logger;
        }

        public IActionResult WatchMedia()
        {
            return View(new CommentVM());
        }

        public IActionResult SendComment(CommentVM comment)
        {
            comment.CommentDate = DateTime.Now;
            // MediaTimestamp
            Console.WriteLine(comment.CommentDate);
            Console.WriteLine(comment.CommentText);
            return RedirectToAction("WatchMedia", "Media");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CommentLog(List<CommentVM> commentLog)
        {
          Console.WriteLine(commentLog);

          return RedirectToAction("WatchMedia", "Media");
        }
    }
}