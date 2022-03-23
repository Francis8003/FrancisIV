using System;
using System.Collections.Generic;
using System.Text;

namespace FrameworkByFrancis
{
    /// <summary>
    /// 版本号类
    /// </summary>
    public static partial class Version
    {
        private const string GameFrameworkVersionString = "2022.03.23";

        private static IVersionHelper s_VersionHelper = null;

        public static string GameframeworkVerison
        {
            get
            {
                return GameFrameworkVersionString;
            }
        }

        ///<summary>
        ///获取游戏版本号
        /// </summary>
        public static string GameVersion
        {
            get
            {
                if (s_VersionHelper == null)
                {
                    return string.Empty;
                }
                return s_VersionHelper.GameVersion;
            }
        }
        /// <summary>
        /// 获取内部游戏版本号
        /// </summary>
        public static int InternalGameVersion
        {
            get
            {
                if (s_VersionHelper == null)
                {
                    return 0;
                }
                return s_VersionHelper.InternalGameVersion;
            }
        }
        public static void SetVersionHelper(IVersionHelper versionHelper)
        {
            s_VersionHelper = versionHelper;
        }
    }
}
