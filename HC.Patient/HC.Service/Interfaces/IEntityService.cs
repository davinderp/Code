using HC.Common.Enums;
using HC.Patient.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.Patient.Service.Interfaces
{
    public interface IEntityService
    {
        dynamic GetAllEntities();

        StatusEnum.Status CreateEntity(EntityModel model);

        StatusEnum.Status UpdateEntity(EntityModel model);

        StatusEnum.Status DeleteEntity(int id);

        dynamic GetEntity(Guid id);
    }
}
