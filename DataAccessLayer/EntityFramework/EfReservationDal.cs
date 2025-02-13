﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationPending(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where
                    (x => x.Status == "Pending" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithtReservationAccepted(int id)
        {

            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where
                    (x => x.Status == "Approved" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithtReservationPrevious(int id)
        {

            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where
                    (x => x.Status == "Previous" && x.AppUserId == id).ToList();
            }
        }
    }
}
