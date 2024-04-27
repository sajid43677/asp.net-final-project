using dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Repos
{
    internal class Repo
    {
        internal SMContext db;

        internal Repo()
        { 
            db = new SMContext(); 
        }
    }
}
