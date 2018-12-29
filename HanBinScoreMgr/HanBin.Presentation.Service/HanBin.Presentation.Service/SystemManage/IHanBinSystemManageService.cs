﻿using iCMS.Common.Component.Data.Base;
using iCMS.Common.Component.Data.Request.HanBin.OfficerManager;
using iCMS.Common.Component.Data.Request.HanBin.OrganManage;
using iCMS.Common.Component.Data.Request.HanBin.SystemManage;
using iCMS.Common.Component.Data.Response.HanBin.OfficerManager;
using iCMS.Common.Component.Data.Response.HanBin.ScoreManager;
using iCMS.Common.Component.Data.Response.HanBin.SystemManager;
using iCMS.Common.Component.Data.Response.HanBinOrganManager;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace HanBin.Presentation.Service.SystemManage
{

    [ServiceContract]
    public interface IHanBinSystemManageService
    {
        #region 用户管理
        [WebInvoke(UriTemplate = "Login",
              BodyStyle = WebMessageBodyStyle.Bare,
              Method = "POST",
              RequestFormat = WebMessageFormat.Json,
              ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<LoginResult> Login(LoginParameter parameter);

        [WebInvoke(UriTemplate = "AddUser",
             BodyStyle = WebMessageBodyStyle.Bare,
             Method = "POST",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<bool> AddUser(AddUserParameter parameter);

        [WebInvoke(UriTemplate = "EditUser",
             BodyStyle = WebMessageBodyStyle.Bare,
             Method = "POST",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<bool> EditUser(EditUserParameter parameter);

        [WebInvoke(UriTemplate = "GetUserInfo",
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<GetUserInfoResult> GetUserInfo(GetUserInfoParameter parameter);
        #endregion

        #region 单位管理
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<bool> AddOrganizationRecord(AddOrganParameter param);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<GetOrganDetailInfoResult> GetOrganDetailInfo(GetOrganDetailInfoParameter parameter);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<bool> EditOrganizationRecord(EditOrganParameter parameter);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<bool> DeleteOrganRecord(DeleteOrganParameter param);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<GetOrganListResult> GetOrganList(GetOrganInfoListParameter parameter);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
         Method = "POST",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<GetOrganTypeResult> GetOrganTypeList();
        #endregion

        #region 干部管理
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<bool> AddOfficerRecord(AddOfficerParameter parameter);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
         Method = "POST",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<GetOfficerDetailInfoResult> GetOfficerDetailInfo(GetOfficerDetailInfoParameter parameter);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<GetOfficerScoreDetailInfoResult> GetOfficerScoreDetailInfo(GetOfficerScoreDetailInfoParameter parameter);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<GetApplyDetailInfoResult> GetApplyDetailInfo(GetApplyDetailInfoParameter parameter);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
             Method = "POST",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<bool> CancelScoreApply(CancelScoreApplyParameter parameter);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
             Method = "POST",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<bool> DeleteOfficerRecord(DeleteOfficerParameter parameter);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<GetOfficerListResult> GetOfficerList(GetOfficerListParameter parameter);
        #endregion

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<GetOrganSummaryResult> GetOrganSummary();

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<GetPositionListResult> GetPositionSummary();

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        BaseResponse<GetLevelListResult> GetLevelSummary();

     
    }
}
