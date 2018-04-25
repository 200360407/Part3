using System;
using System.Collections.Generic;
using Assignment.Models;
using Assignment2.Models;

namespace Assignment.Controllers
{
    public class MockchildrenRepository
    {
        internal List<child> children;
        internal List<child> childrenList;


        public static implicit operator MockchildrenRepository(EFChildrenRepository v)
        {
            throw new NotImplementedException();
        }

        internal void Save(child child)
        {
            throw new NotImplementedException();
        }

        //internal  Entry(child child)
        //{

        //    throw new NotImplementedException();
        //}

        //find children

    }
}