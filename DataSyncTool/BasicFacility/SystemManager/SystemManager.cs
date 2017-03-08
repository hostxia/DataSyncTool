// ############################################################
// // <CopyRight From='2000' To='2013' Company='北京彼速信息技术有限公司'>
// // Copyright 北京彼速信息技术有限公司版权所有
// // FileName: SystemManager.cs
// // Coder: Sum (2014-01-26)
// // </CopyRight>
// ############################################################

using System.ComponentModel;
using System.Diagnostics;
using System.Management;

namespace BasicFacility.SystemManager
{
    public class SystemManager
    {
        //######################################################################
        /// <summary>
        ///     判断操作系统是64位还是32位
        ///     32bit OS             64bit OS
        ///     32bit CPU    AddressWidth = 32    N/A
        ///     64bit CPU    AddressWidth = 32    AddressWidth = 64
        ///     故，若返回是64，则说明操作系统是64位
        /// </summary>
        /// <returns></returns>
        public static string Detect3264()
        {
            var oConn = new ConnectionOptions();
            var oMs = new ManagementScope("\\\\localhost", oConn);
            var oQuery = new ObjectQuery("select AddressWidth from Win32_Processor");
            var oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            var oReturnCollection = oSearcher.Get();
            string addressWidth = null;
            foreach (ManagementObject oReturn in oReturnCollection)
            {
                if (oReturn["AddressWidth"] != null)
                {
                    addressWidth = oReturn["AddressWidth"].ToString();
                }
            }
            if (addressWidth == null)
            {
                addressWidth = "";
            }
            return addressWidth;
        }

        /// <summary>
        ///     Judge if current mode is design mode
        ///     This method should be used in UserControl's Constructor and UserControl_Load event.(e.g.:if(CommonFunctions.DesignMode()) return;)
        /// </summary>
        /// <returns></returns>
        public static bool DesignMode()
        {
            var returnFlag = false;
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                returnFlag = true;
            }
            else if (Process.GetCurrentProcess().ProcessName.ToUpper().Equals("DEVENV"))
            {
                returnFlag = true;
            }
            return returnFlag;
        }
    }
}