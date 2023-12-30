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
   
    public class MoneyCaseManager : IMoneyCaseService
    {
        private readonly IMoneyCaseDal _moneyCaseDal;

        public MoneyCaseManager(IMoneyCaseDal moneyCaseDal)
        {
            _moneyCaseDal = moneyCaseDal;
        }

        public void Add(MoneyCase entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MoneyCase entity)
        {
            throw new NotImplementedException();
        }

        public MoneyCase GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MoneyCase> GetListAll()
        {
            throw new NotImplementedException();
        }

        public decimal TotalMoneyCaseAmount()
        {
            return _moneyCaseDal.TotalMoneyCaseAmount();
        }

        public void Update(MoneyCase entity)
        {
            throw new NotImplementedException();
        }
    }
}
