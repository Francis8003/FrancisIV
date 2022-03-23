using System;
using System.Collections.Generic;
using System.Text;

namespace FrameworkByFrancis
{
    /// <summary>
    /// 事件基类
    /// </summary>
    public abstract class BaseEventArgs : GameFrameworkEventArgs
    {
        /// <summary>
        /// 获取类型编号
        /// </summary>
        public abstract int Id
        {
            get;
        }
    }
}
