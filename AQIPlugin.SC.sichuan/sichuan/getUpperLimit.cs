﻿using System;
using AQI;
using AQI.Abstract;

namespace sichuan.publish
{
    public class getUpperLimit : ABaseSrcUrl
    {

        #region 静态变量

        private static string tag = "getUpperLimit";
        private static string name = "四川城市列表";
        private static string url = "http://www.scnewair.cn:3389/publish/getUpperLimit";
        private static AqiConstant.SourceUpdataInterval sui = AqiConstant.SourceUpdataInterval.NONE;
        private static AqiConstant.HttpType httpType = AqiConstant.HttpType.GET;

        #endregion

        #region 属性

        public override string Tag
        {
            get
            {
                return tag;
            }
        }
        public override string Name
        {
            get
            {
                return name;
            }
        }
        public override string Url
        {
            get
            {
                return url;
            }
        }
        public override AqiConstant.SourceUpdataInterval SUI
        {
            get
            {
                return sui;
            }
        }
        public override AqiConstant.HttpType HT
        {
            get
            {
                return httpType;
            }
        }

        #endregion

    }
}
