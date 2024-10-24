using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Test2
{
    public abstract class RepositoryBase
    {
        protected string connStr = "Server=myServer; Database=myDb; Integrated Security=True;";

        public abstract void Add(object obj);
        public abstract void GetAll();
        public abstract void Update(int id, object obj);
        public abstract void Delete(int id);
    }
}