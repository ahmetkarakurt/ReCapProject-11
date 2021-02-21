using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(car rental)
        {

            foreach (var item in _rentalDal.GetAll(r=>r.CarId==rental.CarId))
            {
                if (item.ReturnDate==null)
                {
                  
                    return new ErrorResult(Messages.TeslimEdilmedi);
                }
            }
            if (rental.RentDate<=rental.ReturnDate )
            {
              
                return new ErrorResult(Messages.deger);
            }
            _rentalDal.Add(rental);
            return new SuccessResult();
        }

        public IResult Delete(car rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<car>> GetAll()
        {
            return new SuccessDataResult<List<car>>(_rentalDal.GetAll());
        }

        public IDataResult<car> GetById(int id)
        {
            return new SuccessDataResult<car>(_rentalDal.Get(c=>c.Id==id));
        }

        public IResult Update(car rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
