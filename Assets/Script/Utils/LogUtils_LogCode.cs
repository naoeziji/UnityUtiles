namespace Utils
{
    namespace Log
    {
        /// <summary>
        /// ���b�Z�[�W�R�[�h
        /// </summary>
        public enum MessageCode
        {
            Code_000, Code_001, Code_002

        }

        /// <summary>
        /// �G���[�R�[�h
        /// </summary>
        public enum ErrorCode
        {
            ECode_000, ECode_001, ECode_002
        }


        /// <summary>
        /// ���O�̃��b�Z�[�W�R�[�h��G���[�R�[�h���܂Ƃ߂��N���X
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
            /// Code��string�ɕϊ�
            /// </summary>
            /// <param name="code">���b�Z�[�W�R�[�h</param>
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
            /// Code��string�ɕϊ�
            /// </summary>
            /// <param name="code">�G���[�R�[�h</param>
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


