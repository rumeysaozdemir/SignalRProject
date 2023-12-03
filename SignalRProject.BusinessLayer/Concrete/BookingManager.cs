using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DataAccessLayer.Abstract;
using SignalRProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void Add(Booking entity)
        {
            _bookingDal.Add(entity);
        }

        public void Delete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }

        public Booking GetById(int id)
        {
           return _bookingDal.GetById(id);
        }

        public List<Booking> GetListAll()
        {
            return _bookingDal.GetListAll();
        }

        public void Update(Booking entity)
        {
            _bookingDal.Update(entity);
        }
    }
}
