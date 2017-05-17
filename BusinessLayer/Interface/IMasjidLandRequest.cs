﻿using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IMasjidLandRequest
    {

        List<MasjidModel> MasjidList();


        //List<RequestSubmitModel> RequestSubmitList();

        List<RequestTypeModel> RequestTypeList();

        List<UserModel> UserList();

        List<MasjidLandRequestModel> MasjidLandRequestList();

        MasjidLandRequestModel GetDetails(MasjidLandRequestModel model);

        int Save(MasjidLandRequestModel model);

        MasjidLandRequestModel GetById(int id);
        MasjidLandRequestModel GetByRequestSubmitIdBoard(int id, int userid);
        MasjidLandRequestModel GetByRequestId(int id, int UserTypeId, int UserId);


        //void Delete(MasjidLandRequestModel entity);
    }
}
