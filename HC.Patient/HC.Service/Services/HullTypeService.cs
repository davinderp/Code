using HC.Common.Enums;
using HC.Patient.Repositories.Interfaces;
using HC.Patient.Entity;
using HC.Patient.Model.HullType;
using HC.Patient.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using HC.Service;

namespace HC.Patient.Service.Services
{
   public  class HullTypeService: BaseService, IHullTypeService
    {
        #region Global Variables
        private readonly IHullTypeRepository _hulltypeRepository;
        private PASCore_HullType _hulltype;
        #endregion

        public HullTypeService(IHullTypeRepository hulltypeRepository)
        {
            this._hulltypeRepository = hulltypeRepository;
        }
        public dynamic GetAllHullTypes()
        {
            dynamic AllOffices = _hulltypeRepository.GetAll(x => x.IsDeleted == false);
            return AllOffices;
        }

        public StatusEnum.Status CreateHullType(HullTypeModel model)
        {
            StatusEnum.Status status = StatusEnum.Status.Success;
            try
            {
                _hulltype = new PASCore_HullType();
                _hulltype.Name  = model.Name;
                _hulltype.Code = model.Code;
                _hulltype.CreatedBy = model.CreatedBy;
                _hulltype.CreatedDateTime = model.CreatedDateTime;
                _hulltype.DeletedBy = model.DeletedBy;
                _hulltype.DeletedDateTime = model.DeletedDateTime;
                _hulltype.IsDeleted = false;
                _hulltype.ModifiedBy = model.ModifiedBy;
                _hulltype.ModifiedDateTime = model.ModifiedDateTime;
                _hulltypeRepository.Create(_hulltype);
                _hulltypeRepository.SaveChanges();
            }
            catch (Exception)
            {
                status = StatusEnum.Status.Fail;
                throw;
            }

            return status;
        }

        public StatusEnum.Status UpdateHullType(HullTypeModel model)
        {
            StatusEnum.Status status = StatusEnum.Status.Success;
            try
            {
                PASCore_HullType hullTypeUpdate = _hulltypeRepository.GetByID(model.HullTypeId);
                hullTypeUpdate.Name = model.Name;
                hullTypeUpdate.Code = model.Code;
                hullTypeUpdate.CreatedBy = model.CreatedBy;
                hullTypeUpdate.CreatedDateTime = model.CreatedDateTime;
                hullTypeUpdate.DeletedBy = model.DeletedBy;
                hullTypeUpdate.DeletedDateTime = model.DeletedDateTime;
                hullTypeUpdate.IsDeleted = false;
                hullTypeUpdate.ModifiedBy = model.ModifiedBy;
                hullTypeUpdate.ModifiedDateTime = model.ModifiedDateTime;
                _hulltypeRepository.Update(hullTypeUpdate);
                _hulltypeRepository.SaveChanges();

            }
            catch (Exception)
            {
                status = StatusEnum.Status.Fail;
                throw;
            }
            return status;
        }

        public StatusEnum.Status DeleteHullType(Guid id)
        {
            StatusEnum.Status status = StatusEnum.Status.Success;
            try
            {
                PASCore_HullType hullTypeDelete = _hulltypeRepository.GetByID(id);
                hullTypeDelete.IsDeleted = true;
                _hulltypeRepository.Update(hullTypeDelete);
                _hulltypeRepository.SaveChanges();
            }
            catch (Exception)
            {
                status = StatusEnum.Status.Fail;
                throw;
            }
            return status;
        }

        public dynamic GetHullTypeByID(Guid id)
        {
            dynamic HullTypeByID = null;
            try
            {
                HullTypeByID = _hulltypeRepository.GetByID(id);
            }
            catch (Exception)
            {
                HullTypeByID = null;
                throw;
            }
            return HullTypeByID;
        }



    }
}
