using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
   public interface MocKchildrenRepository
    {
        IQueryable<child> children { get; }
        child Save(child child);
        void Delete(child child);
    }

}
