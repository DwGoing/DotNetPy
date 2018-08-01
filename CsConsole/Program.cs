using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using DotNetPy;

namespace CsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PyEngine pyEngine = new PyEngine();
            if (pyEngine.PyInitialize()) // 初始化PyEngine
            {
                pyEngine.PySetModulePath(null); // null 默认当前路径否则填绝对路径
                if (pyEngine.PyImportModule("t123")) // 导入模块
                {
                    object[] argss = new object[] { 1.2, 2 }; // 添加参数
                    object obj = pyEngine.PyCallFuncFromModule("t123", "F", argss, "D"); // 执行函数
                    Console.WriteLine(obj);
                }
            }
            Console.ReadLine();
        }
    }
}
