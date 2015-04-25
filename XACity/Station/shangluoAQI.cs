﻿using System;
using AQI.Abstract;
using SX.Abstract;

namespace SX.Station
{
    public class shangluoAQI : SXSrcUrl
    {

        #region 静态变量

        private static string Tag = "shangluoAQI";
        private static string Name = "商洛市站点1小时AQI";
        private static string Url = "http://113.140.66.226:8024/sxAQIWeb/swfPage/shangluoAQI.xml";
        private static AQI.AqiConstant.SourceUpdataInterval Sui = AQI.AqiConstant.SourceUpdataInterval.HOUR;

        #endregion

        #region 属性

        public override string TAG
        {
            get
            {
                return Tag;
            }
        }
        public override string NAME
        {
            get
            {
                return Name;
            }
        }
        public override string URL
        {
            get
            {
                return Url;
            }
        }
        public override AQI.AqiConstant.SourceUpdataInterval SUI
        {
            get
            {
                return Sui;
            }
        }

        #endregion

    }
}
