using System;
using System.Configuration;
using System.Globalization;

namespace DataSyncTool.Common
{
    /// <summary>
    ///     web.config操作类
    ///     Copyright (C) Maticsoft
    /// </summary>
    public sealed class ConfigHelper
    {
        /// <summary>
        ///     得到AppSettings中的配置字符串信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConfigString(string key)
        {
            var CacheKey = "AppSettings-" + key;
            var objModel = DataCache.GetCache(CacheKey);
            if (objModel == null)
                try
                {
                    objModel = ConfigurationManager.AppSettings[key];
                    if (objModel != null)
                        DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(180), TimeSpan.Zero);
                }
                catch
                {
                }
            return objModel.ToString();
        }

        /// <summary>
        ///     得到AppSettings中的配置Bool信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool GetConfigBool(string key)
        {
            var result = false;
            var cfgVal = GetConfigString(key);
            if (null != cfgVal && string.Empty != cfgVal)
                try
                {
                    result = bool.Parse(cfgVal);
                }
                catch (FormatException)
                {
                    // Ignore format exceptions.
                }
            return result;
        }

        /// <summary>
        ///     得到AppSettings中的配置Decimal信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static decimal GetConfigDecimal(string key)
        {
            decimal result = 0;
            var cfgVal = GetConfigString(key);
            if (null != cfgVal && string.Empty != cfgVal)
                try
                {
                    result = decimal.Parse(cfgVal);
                }
                catch (FormatException)
                {
                    // Ignore format exceptions.
                }

            return result;
        }

        /// <summary>
        ///     得到AppSettings中的配置int信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int GetConfigInt(string key)
        {
            var result = 0;
            var cfgVal = GetConfigString(key);
            if (null != cfgVal && string.Empty != cfgVal)
                try
                {
                    result = int.Parse(cfgVal);
                }
                catch (FormatException)
                {
                    // Ignore format exceptions.
                }

            return result;
        }

        public static DateTime GetDateTime(string sKeyName)
        {
            ConfigurationManager.RefreshSection("appSettings");
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return string.IsNullOrWhiteSpace(config.AppSettings.Settings[sKeyName].Value)
                ? DateTime.MinValue
                : DateTime.Parse(config.AppSettings.Settings[sKeyName].Value);
        }

        public static void SetDateTime(string sKeyName, DateTime dt)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[sKeyName].Value = dt.ToString(CultureInfo.InvariantCulture);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static DateTime BeginDate
        {
            get { return GetDateTime("BeginDate"); }
            set { SetDateTime("BeginDate", value); }
        }

        public static DateTime FinishDate
        {
            get { return GetDateTime("FinishDate"); }
            set { SetDateTime("FinishDate", value); }
        }

        public static DateTime NextDate => new DateTime(BeginDate.Year, BeginDate.Month, BeginDate.Day, GetDateTime("BeginTime").Hour, GetDateTime("BeginTime").Minute, 0).AddDays(GetConfigInt("Interval"));
    }
}