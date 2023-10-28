using System;
using System.Text;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Utils
{
    namespace Log
    {
        /// <summary>
        /// ログの出力する機能
        /// </summary>
        public static class LogUtils
        {

            /// <summary>
            /// メッセージログを出力
            /// </summary>
            /// <param name="code">メッセージコード</param>
            public static void Log(MessageCode code,
                [CallerLineNumber] int lineNumber = 0,
                [CallerFilePath] string filePath = "")
            {
                OutputConsole(MessageConnect("Message",
                                             LogUtils_LogCode.ConvertMessage(code),
                                             lineNumber.ToString(),
                                             filePath));
            }

            /// <summary>
            /// エラーログを出力
            /// </summary>
            /// <param name="code">エラーコード</param>
            public static void Log(ErrorCode code,
                [CallerLineNumber] int lineNumber = 0,
                [CallerFilePath] string filePath = "")
            {
                OutputConsole(MessageConnect("Error",
                                             LogUtils_LogCode.ConvertMessage(code), 
                                             lineNumber.ToString(),
                                             filePath));
            }

            /// <summary>
            /// ログを出力
            /// </summary>
            /// <param name="code">メッセージ</param>
            public static void Log(string code,
                [CallerLineNumber] int lineNumber = 0,
                [CallerFilePath] string filePath = "")
            {
                OutputConsole(MessageConnect("Normal", code, lineNumber.ToString(), filePath));
            }

            /// <summary>
            /// 文字列を連結する
            /// </summary>
            /// <param name="codeType">メッセージタイプ</param>
            /// <param name="memberName">モジュール名</param>
            /// <param name="lineNumber">行番号</param>
            /// <param name="filePath">ファイルパス</param>
            /// <returns>連結済文字列</returns>
            private static string MessageConnect(string codeType, string msg,
                                                 string lineNumber, string filePath)
            {                          
                DateTime dayTime = DateTime.Now;

                //文字列連結
                StringBuilder sb = new();
                sb.Append(dayTime.ToString("yyyy/MM/dd HH:mm:ss"));
                sb.Append(" | ");
                sb.Append(codeType);
                sb.Append(" | ");               
                sb.Append(filePath);
                sb.Append(" [Line : ");
                sb.Append(lineNumber);
                sb.Append("]");
                sb.Append(" : ");
                sb.Append(msg);

                return sb.ToString();
            }

            /// <summary>
            /// コンソールに出力
            /// </summary>
            /// <param name="msg">ログメッセージ</param>
            private static void OutputConsole(string msg)
            {
                //出力
                Debug.Log(msg);
            }
        }
    }

    
}

