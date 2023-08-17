using System;
using System.Collections; // 2022/05/08 추가
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;
using System.Windows.Forms; // 2021/07/18
using System.Runtime.InteropServices; // 2021/07/18
using System.IO;

namespace Common
{

    class Base  //  ini(kernel32)
    {

        static public string IniFilePath = Application.StartupPath + "\\Config.ini";

        static public string NoteFilePath = Application.StartupPath + "\\Note.ini"; // 2022/06/19 추가

        #region API 선언

        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(String section, String key, String val, String IniPath);

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(String section, String key, String def, StringBuilder retVal, int size, String IniPath);

        #endregion

        #region Ini 파일에 값을 작성하는 함수
        public static void WriteInformation(String section, String key, String val, String IniPath)
        {
            WritePrivateProfileString(section, key, val, IniPath);
        }

        public static string ReadInformation(String section, String key, String IniPath)
        {
            // C#에서는 포인터를 명시적으로 가져올 수 없으므로 StringBuilder 사용
            StringBuilder temp = new StringBuilder(255); //현재까지 32767 자 까지는 허용되는 것 확인. ini에 특수 문자, 엔터는 허용되지 않으므로 ini에 특수문자 포함 방법이나 텍스트 파일 활용하는 방법 고민.
            int i = GetPrivateProfileString(section, key, "", temp, 255, IniPath);
            return temp.ToString();
        }

        #endregion

        public static bool FileExistsCheck(string oldFile) // 파일 존재 유무 . true flase 반환
        {
            if (File.Exists(oldFile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public object Group_List(ComboBox Group) // 2022/05/15 그룹 추가
        {
            Group.Items.Add("전체");

            // 조회용 그룹, 입력용 그룹, 나뉘게 되면 입력용 그룹에서는 '전체'를 없애던가 입력에서는 2번째 index부터 불러오도록 할 것.
            // 이하 config.txt 에서 입력된 리스트를 가져오도록 할 것.

            return Group;
        }

    }

}
