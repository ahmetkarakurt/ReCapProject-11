using Core.Utilities.Results.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRentalService
    {
        IDataResult<List<car>> GetAll();
        IDataResult<car> GetById(int id);
        IResult Add(car rental);
        IResult Update(car rental);
        IResult Delete(car rental);
    }
}
