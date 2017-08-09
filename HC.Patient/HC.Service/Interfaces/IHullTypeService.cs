using HC.Common.Enums;
using HC.Patient.Model.HullType;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.Patient.Service.Interfaces
{
   public interface IHullTypeService
    {
        StatusEnum.Status CreateHullType(HullTypeModel model);
        StatusEnum.Status UpdateHullType(HullTypeModel model);
        StatusEnum.Status DeleteHullType(Guid hulltypeId);

        dynamic GetAllHullTypes();
        dynamic GetHullTypeByID(Guid hulltypeId);

    }
}
