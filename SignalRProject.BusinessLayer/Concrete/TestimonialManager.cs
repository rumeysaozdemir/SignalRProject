﻿using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DataAccessLayer.Abstract;
using SignalRProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial entity)
        {
            _testimonialDal.Add(entity);
        }

        public void Delete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public List<Testimonial> GetListAll()
        {
            return _testimonialDal.GetListAll();
        }

        public void Update(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
