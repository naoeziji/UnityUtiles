namespace Utils
{
    namespace Log
    {
        /// <summary>
        /// メッセージコード
        /// </summary>
        public enum MessageCode
        {
            Code_000, Code_001, Code_002

        }

        /// <summary>
        /// エラーコード
        /// </summary>
        public enum ErrorCode
        {
            ECode_000, ECode_001, ECode_002
        }


        /// <summary>
        /// ログのメッセージコードやエラーコードをまとめたクラス
        /// </summary>
        public static class LogUtils_LogCode
        {
            private static string MCode_000 = "";
            private static string MCode_001 = "";
            private static string MCode_002 = "";

            private static string ECode_000 = "Null";
            private static string ECode_001 = "Null";
            private static string ECode_002 = "Null";

            /// <summary>
            /// Codeをstringに変換
            /// </summary>
            /// <param name="code">メッセージコード</param>
            /// <returns></returns>
            public static string ConvertMessage(MessageCode code)
            {
                switch(code)
                {
                    case MessageCode.Code_000: return MCode_000;
                    case MessageCode.Code_001: return MCode_001;
                    case MessageCode.Code_002: return MCode_002;
                }

                return "No MessageCode";
            }

            /// <summary>
            /// Codeをstringに変換
            /// </summary>
            /// <param name="code">エラーコード</param>
            /// <returns></returns>
            public static string ConvertMessage(ErrorCode code)
            {
                switch (code)
                {
                    case ErrorCode.ECode_000: return ECode_000;
                    case ErrorCode.ECode_001: return ECode_001;
                    case ErrorCode.ECode_002: return ECode_002;
                }

                return "No ErrorCode";
            }
        }
    }

}


