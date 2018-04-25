using System;
using Assignment2.Models;

namespace Assignment.Controllers
{
    internal class MockchildrenRepository
    {
        internal object children;

        public static implicit operator MockchildrenRepository(EFChildrenRepository v)
        {
            throw new NotImplementedException();
        }
    }
}