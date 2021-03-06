﻿using System;
using AQI.Abstract;
using sxAQIWeb.Abstract;

namespace sxAQIWeb.City
{
    public class yulin7Day : sxAQIWebSrcUrl
    {

        #region 静态变量

        private static string tag = "yulin7Day";
        private static string name = "榆林市7天AQI";
        private static string url = "http://113.140.66.226:8024/sxAQIWeb/swfPage/yulin7Day.xml";
        private static AQI.AqiConstant.SourceUpdataInterval sui = AQI.AqiConstant.SourceUpdataInterval.DAY7;

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
        public override AQI.AqiConstant.SourceUpdataInterval SUI
        {
            get
            {
                return sui;
            }
        }

        #endregion

    }
}
