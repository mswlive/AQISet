﻿using System;
using AQI.Abstract;
using sxAQIWeb.Abstract;

namespace sxAQIWeb.Station
{
    public class yananAllAQI : sxAQIWebSrcUrl
    {

        #region 静态变量

        private static string tag = "yananAllAQI";
        private static string name = "延安市站点24小时AQI";
        private static string url = "http://113.140.66.226:8024/sxAQIWeb/swfPage/yananAllAQI.xml";
        private static AQI.AqiConstant.SourceUpdataInterval sui = AQI.AqiConstant.SourceUpdataInterval.DAY;

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
