using BlazorAPI_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAPI_UI.Contracts
{
    public interface IBookRepository : IBaseRepository<Book>
    {
    }
}
