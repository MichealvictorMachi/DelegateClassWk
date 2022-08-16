using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classworkDel
{

    /// <summary>
    /// Main program
    /// </summary>
    public class Delegate
    {
            //predicate
        public delegate bool Predicate(XClass x); 
        
          //method that takes in the delegate
        public bool WhereOne(Predicate y)       
        {
            return true;
        }
        static void Main(string[] args)
        {
            var repoUser = new Delegate();
            var t = new XClass();
            var likelyUsername = t.FirstName + "." + t.LastName;
            var dUserCount = repoUser.WhereOne(x => x.UserName == likelyUsername);
        }

    }
    /// <summary>
    /// Public class with the properties
    /// </summary>
    public class XClass
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string UserName { get; set; }
    }
}
