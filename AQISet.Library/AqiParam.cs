﻿using System;
using System.Collections.Generic;
using AQI.Interface;
using System.IO;
using Newtonsoft.Json.Linq;
using AQI.Abstract;
using System.Text.RegularExpressions;
using AQI.Exception;

namespace AQI
{
    /// <summary>
    /// 参数
    /// </summary>
    public class AqiParam : Dictionary<string,string>
    {

        #region 常用字符串

        public const string PARAMS = "Params";
        private const string PARAM = "Param";
        private const string REFER = "Refer";
        private const string GROUP = "Group";
        private const string NAME = "Name";
        private const string ENEABLED = "Enabled";

        private const string REGEX_LOWWORLD = "^[a-z].*$";

        //ParamCycle.OnceAgain使用
        public const string ONCE = "ONCE";
        public const string AGAIN = "AGAIN";
        #endregion

        #region 字段

        private string pName;
        private string pRefer;
        private string pGroup;

        #endregion

        #region 属性

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get
            {
                return pName;
            }
        }

        /// <summary>
        /// 参照
        /// </summary>
        public string Refer
        {
            get
            {
                return pRefer;
            }
            set
            {
                pRefer = value;
            }
        }

        /// <summary>
        /// 分组
        /// </summary>
        public string Group
        {
            get
            {
                return pGroup;
            }
            set
            {
                pGroup = value;
            }
        }

        #endregion

        public AqiParam(string name) 
        {
            pName = name;
        }

        #region Factory

        /// <summary>
        /// 读取 JSON配置文件 更新时间
        /// </summary>
        /// <param name="paramSrcUrl"></param>
        /// <returns></returns>
        public static DateTime ReadWriteTimeFormJson(ISrcUrl paramSrcUrl)
        {
            try
            {
                //JSON路径
                string jsonPath = paramSrcUrl.IAW.GetJsonFile();
                FileInfo fi = new FileInfo(jsonPath);
                return fi.LastWriteTime;
            }
            catch (System.Exception ex)
            {
                throw new ParamException("读取参数文件错误", ex);
            }
        }

        /// <summary>
        /// 从 JSON配置文件 读取参数列表
        ///     自动识别Enabled、name、Param、Refer、各种小写
        /// </summary>
        /// <param name="paramSrcUrl">当前SrcUrl</param>
        /// <param name="propertyName">配置文件属性名称（paramSrcUrl.Tag + "." + propertyname）</param>
        /// <returns></returns>
        public static List<AqiParam> CreateListFormJson(ISrcUrl paramSrcUrl, string propertyName)
        {
            List<AqiParam> listParam = new List<AqiParam>();
            try 
            { 
                //JSON路径
                string jsonPath = paramSrcUrl.IAW.GetJsonFile();

                //读取JSON
                StreamReader sr = new StreamReader(jsonPath);
                string jsonText = sr.ReadToEnd();
                //转JSON Object
                JObject jo = JObject.Parse(jsonText);
                JToken jt = jo.SelectToken(paramSrcUrl.Tag + "." + propertyName);
            
                if (jt == null || !jt.HasValues)
                {
                    return null;
                }
                else if (jt is JArray)
                {
                    //读取集合(任意个参数)
                    JEnumerable<JToken> je = jt.Children();
                    foreach (JToken j in je)
                    {
                        AqiParam ap = createParamFormJsonObject(j as JObject);
                        if (ap != null)
                            listParam.Add(ap);
                    }
                }
                else if (jt is JObject)
                {
                    //读取对象(仅一个参数)
                    AqiParam ap = createParamFormJsonObject(jt as JObject);
                    if(ap != null)
                        listParam.Add(ap);
                }
            }
            catch(System.Exception ex)
            {
                throw new ParamException("参数创建错误", ex);
            }

            return listParam;
        }

        /// <summary>
        /// 从 JSONObject对象 读取参数
        /// </summary>
        /// <param name="jObject"></param>
        /// <returns></returns>
        private static AqiParam createParamFormJsonObject(JObject jObject)
        {
            //检查4个属性
            //1开启
            JToken jt = jObject.GetValue(ENEABLED);
            if(jt == null)
            {
                return null;
            }
            else if (jt.ToObject<bool>() == false)
            {
                return null;
            }
            //2名称
            jt = jObject.GetValue(NAME);
            if(jt == null)
            {
                return null;
            }
            //缓存名称
            string name = jt.ToString();
            AqiParam ap = new AqiParam(name);
            //3参数
            jt = jObject.GetValue(PARAM);
            if (jt == null)
            {
                //没有Param属性
                //将所有其他非首字母大写的属性当作参数
                foreach (KeyValuePair<string, JToken> kv in jObject)
                {
                    if (Regex.IsMatch(kv.Key, REGEX_LOWWORLD))
                    {
                        ap.Add(kv.Key, kv.Value.ToString());
                    }
                }
            }
            else
            {
                //有Param属性
                if (jt.Type == JTokenType.String)
                {
                    ap.Add("", jt.ToString());
                }
                else if (jt.Type == JTokenType.Object)
                {
                    foreach (KeyValuePair<string, JToken> kv in jt as JObject)
                    {
                        if (Regex.IsMatch(kv.Key, REGEX_LOWWORLD))
                        {
                            ap.Add(kv.Key, kv.Value.ToString());
                        }
                    }
                }
            }

            //4参数参照
            jt = jObject.GetValue(REFER);
            if (jt != null)
            {
                ap.pRefer = jt.ToString();
            }

            //5分组
            jt = jObject.GetValue(GROUP);
            if (jt != null)
            {
                ap.pGroup = jt.ToString();
            }

            //if(ap.Count == 0){
            //    ap = null;
            //}

            return ap;
        }

        /// <summary>
        /// 从 SrcUrl 读取参数列表
        /// </summary>
        /// <param name="parseParamSrcUrl">实现IParseParam的SrcUrl</param>
        /// <param name="relySrcUrl">参数来源SrcUrl</param>
        /// <returns></returns>
        public static List<AqiParam> CreateListFormSrcUrl(IParseSrcUrlParam parseParamSrcUrl, ISrcUrl relySrcUrl)
        {
            List<AqiParam> listParam = new List<AqiParam>();

            try 
            { 
                if (relySrcUrl.UseParam)
                {
                    List<AqiParam> list = (relySrcUrl as IMakeParam).EnumParams();
                    while ((list == null) || (list.Count == 0))
                    {
                        throw new ParamException("缺少参数");
                    }
                    foreach (AqiParam param2 in list)
                    {
                        byte[] data = null;
                        if (param2 != null)
                        {
                            data = relySrcUrl.GetDate(param2);
                        }
                        else
                        {
                            data = relySrcUrl.GetDate();
                        }

                        List<AqiParam> aps = parseParamSrcUrl.ParseParam(data);
                        listParam.AddRange(aps);
                    }
                }
                else
                {
                    byte[] data = relySrcUrl.GetDate();
                    List<AqiParam> aps = parseParamSrcUrl.ParseParam(data);
                    listParam.AddRange(aps);
                }
            }
            catch (System.Exception ex)
            {
                throw new ParamException("参数创建错误", ex);
            }

            return listParam;
        }

        #endregion

    }
}
