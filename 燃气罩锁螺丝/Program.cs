using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
namespace 燃气罩锁螺丝
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            HOperatorSet.SetSystem("clip_region", "false");
            HOperatorSet.SetSystem("flush_graphic", "false");
            HOperatorSet.SetSystem("alloctmp_max_blocksize", -1);
            HOperatorSet.SetSystem("image_cache_capacity", 4194304);
            //Free the image imediatly
            HOperatorSet.SetSystem("global_mem_cache", "idle");
            //Free the operator imediatly
            //.SetSystem("temporary_mem_cache", "false");
            HOperatorSet.SetSystem("do_low_error", "disabled");
            HOperatorSet.SetSystem("thread_num", 4);
            HOperatorSet.SetSystem("reentrant", "true");
            HOperatorSet.SetSystem("temporary_mem_cache", "false");
            HOperatorSet.SetSystem("backing_store", "true");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
