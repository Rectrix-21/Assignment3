using System;

namespace Assignment_3_skeleton
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //Initializes a User object.
        public User(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        //Gets the users ID.
        public int GetId()
        {
            return Id;
        }

        //Gets the users name.
        public string GetName()
        {
            return Name;
        }

        //Gets the users email.
        public string GetEmail()
        {
            return Email;
        }

        //Checks if the passed password is correct.
        public bool IsCorrectPassword(string password)
        {
            if (Password == null && password == null)
                return true;
            else if (Password == null || password == null)
                return false;
            else
                return Password.Equals(password);
        }

        //Checks if object is equal to another object.
        public override bool Equals(object obj)
        {
            if (!(obj is User))
                return false;

            User other = (User)obj;

            return Id == other.Id && Name.Equals(other.Name) && Email.Equals(other.Email);
        }
    }
}
