using HC.Patient.Repositories.Interfaces;
using HC.Repositories;
using HC.Patient.Entity;
using HC.Patient.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.Patient.Repositories
{
   public class HullTypeRepository: Repository<PASCore_HullType>, IHullTypeRepository
    {
        private readonly HCPatientContext _context;
        public HullTypeRepository(HCPatientContext context) : base(context) {
            this._context = context;
        }

    }

}
