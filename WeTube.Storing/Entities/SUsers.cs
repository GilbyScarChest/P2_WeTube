using System.Collections.Generic;

namespace WeTube.Storing.Entities
{
  public class SUsers
  {
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    
    public ICollection<SComments> SComments { get; set; }
  }
}