using System;
using System.Text;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Utils
{
    namespace Log
    {
        /// <summary>
        /// ���O�̏o�͂���@�\
        /// </summary>
        public static class LogUtils
        {

            /// <summary>
            /// ���b�Z�[�W���O���o��
            /// </summary>
            /// <param name="code">���b�Z�[�W�R�[�h</param>
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
            /// �G���[���O���o��
            /// </summary>
            /// <param name="code">�G���[�R�[�h</param>
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
            /// ���O���o��
            /// </summary>
            /// <param name="code">���b�Z�[�W</param>
            public static void Log(string code,
                [CallerLineNumber] int lineNumber = 0,
                [CallerFilePath] string filePath = "")
            {
                OutputConsole(MessageConnect("Normal", code, lineNumber.ToString(), filePath));
            }

            /// <summary>
            /// �������A������
            /// </summary>
            /// <param name="codeType">���b�Z�[�W�^�C�v</param>
            /// <param name="memberName">���W���[����</param>
            /// <param name="lineNumber">�s�ԍ�</param>
            /// <param name="filePath">�t�@�C���p�X</param>
            /// <returns>�A���ϕ�����</returns>
            private static string MessageConnect(string codeType, string msg,
                                                 string lineNumber, string filePath)
            {                          
                DateTime dayTime = DateTime.Now;

                //������A��
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
            /// �R���\�[���ɏo��
            /// </summary>
            /// <param name="msg">���O���b�Z�[�W</param>
            private static void OutputConsole(string msg)
            {
                //�o��
                Debug.Log(msg);
            }
        }
    }

    
}

