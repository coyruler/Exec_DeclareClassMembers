using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// 將指定文字內容存檔, 由於要存放的文字內容與檔案存放位置都會變化, 所以我們可以將這兩項資訊設計成 method 的參數, 由外界傳入
 /// 請設計一個FileManager class, 內含一個 Save method, 只需要設定method,不必實作出功能
    internal class Program
    {
        static void Main(string[] args)
        {
            FileManager file = new FileManager();
            string sourceFile = "123456";
            string targetPath = @"e:\files\";
            file.Save(sourceFile, targetPath);
        }
    }
     class FileManager
    {
        public void Save(string source, string targetPath)
        {

        }
    }
}
