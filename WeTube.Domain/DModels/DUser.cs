using System;

namespace WeTube.Domain.DModels
{
   public class DUser
   {
      //creating the user profile, passing this information to the database?
      public long Id { get; } //this will be automatically created by the database.
      //need a username & password??
      public string Username { get; set; }
      public string Password { get; set; }
      public string Email { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }


      public DUser(string fname, string lname, string email)
      {
         FirstName = fname;
         LastName = lname;
         Email = email; 
      }
      
      //send the account to the database
   }
}