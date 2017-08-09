using HC.Common.Enums;
using HC.Patient.Repositories.Interfaces;
using HC.Patient.Entity;
using HC.Patient.Model.Entity;
using HC.Patient.Service.Interfaces;
using System;
using HC.Service;

namespace HC.Patient.Service.Services
{
    public class EntityService : BaseService, IEntityService
    {
        #region Global Variables
        private readonly IEntityRepository _entityRepository;
        private PASCore_Entity _entity;
        #endregion
        public EntityService(IEntityRepository entityRepository)
        {
            this._entityRepository = entityRepository;
        }

        public dynamic GetAllEntities()
        {
            dynamic AllEntities = _entityRepository.GetAll(x => x.IsDeleted == false);
            return AllEntities;
        }

        public StatusEnum.Status CreateEntity(EntityModel model)
        {
            StatusEnum.Status status = StatusEnum.Status.Success;
            try
            {
                _entity = new PASCore_Entity();
                _entity.BankDetails = model.BankDetails;
                _entity.Code = model.Code;
                _entity.Description = model.Description;
                _entity.Email = model.Email;
                _entity.IsDeleted = false;
                _entity.Line1 = model.Line1;
                _entity.Line2 = model.Line2;
                _entity.Name = model.Name;
                _entity.PhoneNumber = model.PhoneNumber;
                _entity.CreatedDateTime = DateTime.UtcNow;
                _entityRepository.Create(_entity);
                _entityRepository.SaveChanges();
            }
            catch (Exception)
            {
                status = StatusEnum.Status.Fail;
                throw;
            }

            return status;
        }

        public StatusEnum.Status UpdateEntity(EntityModel model)
        {
            StatusEnum.Status status = StatusEnum.Status.Success;
            try
            {
                PASCore_Entity entityUpdate = _entityRepository.GetByID(model.EntityId);
                entityUpdate.BankDetails = model.BankDetails;
                entityUpdate.Code = model.Code;
                entityUpdate.Description = model.Description;
                entityUpdate.Email = model.Email;
                entityUpdate.IsDeleted = false;
                entityUpdate.Line1 = model.Line1;
                entityUpdate.Line2 = model.Line2;
                entityUpdate.Name = model.Name;
                entityUpdate.PhoneNumber = model.PhoneNumber;
                entityUpdate.ModifiedDateTime = DateTime.UtcNow;
                _entityRepository.Update(entityUpdate);
                _entityRepository.SaveChanges();

            }
            catch (Exception)
            {
                status = StatusEnum.Status.Fail;
                throw;
            }
            return status;
        }

        public StatusEnum.Status DeleteEntity(int id)
        {
            StatusEnum.Status status = StatusEnum.Status.Success;
            try
            {
                PASCore_Entity entityDelete = _entityRepository.GetByID(id);
                entityDelete.IsDeleted = true;
                _entityRepository.Update(entityDelete);
                _entityRepository.SaveChanges();
            }
            catch (Exception)
            {
                status = StatusEnum.Status.Fail;
                throw;
            }
            return status;
        }

        public dynamic GetEntity(Guid id)
        {
            dynamic EntityByID = null;
            try
            {
                EntityByID = _entityRepository.GetByID(id);
            }
            catch (Exception)
            {
                EntityByID = null;
                throw;
            }
            return EntityByID;
        }
    }
}
