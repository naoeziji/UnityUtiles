using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Utils
{
    namespace log
    {
        /// <summary>
        /// ログの出力する機能
        /// </summary>
        public static class LogUtils
        {

            public static void Log(string msg,
                [CallerLineNumber] int lineNumber = 0,
                [CallerMemberName] string memberName = "",
                [CallerFilePath] string filePath = "")
            {

            }
        }
    }

    
}

