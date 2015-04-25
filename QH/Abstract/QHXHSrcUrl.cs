﻿using System;
using System.Collections.Generic;
using AQI.Abstract;

namespace QH.Abstract
{
    /// <summary>
    /// 青海西海州数据接口
    ///     通用抽象类
    /// </summary>
    public abstract class QHXHSrcUrl : AWcfSrcUrl
    {

        #region 属性

        /// <summary>
        /// 不使用参数
        /// </summary>
        public override bool USEPARAM
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// 使用GET方式
        /// </summary>
        public override AQI.AqiConstant.ParamType PT
        {
            get
            {
                return AQI.AqiConstant.ParamType.GET;
            }
        }

        /// <summary>
        /// 无参数
        /// </summary>
        public override List<string> PL
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// 使用UTF8编码格式WCFBin
        /// </summary>
        public override Helper.WCFbin.WCFMessageUtil.WCFContentFormat CF
        {
            get
            {
                return Helper.WCFbin.WCFMessageUtil.WCFContentFormat.UTF8;
            }
        }

        #endregion

        #region 方法

        /// <summary>
        /// 不制作WCFMessage
        /// </summary>
        /// <param name="dictParam"></param>
        /// <returns></returns>
        public override string makeWCFMsg(Dictionary<string, string> dictParam)
        {
            return null;
        }

        #endregion

    }
}
