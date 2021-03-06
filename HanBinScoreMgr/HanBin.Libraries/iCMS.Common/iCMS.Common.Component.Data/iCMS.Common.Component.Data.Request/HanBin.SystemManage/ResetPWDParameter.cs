﻿using HanBin.Common.Component.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanBin.Common.Component.Data.Request.HanBin.SystemManage
{
    public class ResetPWDParameter : BaseRequest
    {
        public int UserID { get; set; }
    }

    public class UpdatePWDParameter : BaseRequest
    {
        public int CurrentUserID { get; set; }

        public string OriginPWD { get; set; }

        public string NewPWD { get; set; }
    }
}
