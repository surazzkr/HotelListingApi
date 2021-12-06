using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelListingApi.Models;

//Unit Of Work : It acts like a register for every variation of the generic repository relative to the class T.

namespace HotelListingApi.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        IGenricRepository<Country> Countries { get; }
        IGenricRepository<Hotel> Hotels { get; }
        Task Save();
    }
}
