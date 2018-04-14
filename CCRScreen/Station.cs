using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CCRScreen
{
    public partial class Station : UserControl
    {
        
        /*
         * 1、创建工位状态对象；
         * 2、为必须的变量赋值；
         * 3、初始化：初始化时判断必须的变量是否有值，没有的话提示后退出；连接到OPC、添加TagItem、注册DataChange事件
         * 4、进入运行状态（在Change事件中调用状态改变）
         * 5、退出时释放TagItem，断开OPC连接
         * 
         * 6、对象类型：只有工位机没有Andon；既有工位机又有Andon
         * 根据不同的方式执行对应的初始化过程
         * 7、
         */

            
        /*
         * 1、网络通断；
         * 2、标签值变化；
         * 
         * 根据工位号获取fAndonOPCServerNo，fAndonChn，fAndonDev
         * 标签则固定为6个，TagID需要计算
         * 两个字典：a、TagID， TagName； b、TagName，TagValue
         * 系统初始化时将标签信息保存到字典a中，在DataChange事件中为字典b赋值
         * 将字典b当参数，确定界面如何变化
             */

        private string _WorkStationIP;        //工位机IP
        private string _WorkStatiomName;      //工位名称
        private string _AndonOPCServerIP;   //
         

        private string _AndonIP;            //Andon模块IP？
        private string _AndonName;          //Andon OPC 设备名称
        //private string _AndonID;            
        //private string _DeviceID;

        
        
        private Dictionary<int, string> _TagValue;


        #region test
        public string status1;
        public string status2;
        public string status3;
        public string status4;
        public string status5;
        public string status6;

        #endregion

        public Station()
        {
            InitializeComponent();
        }



        #region test

        public void SetStatus(string StatusValue, int StatusType)
        {
            if (StatusType == 1)
                status1 = StatusValue;
            else if(StatusType == 2)
                status2 = StatusValue;
            else if (StatusType == 3)
                status3 = StatusValue;
            else if (StatusType == 4)
                status4 = StatusValue;
            else if (StatusType == 5)
                status5 = StatusValue;
            else if (StatusType == 6)
                status6 = StatusValue;
        }

        private void ChangeStatusDiaplay()
        {
            //if(status1 == "1")
           
        }

        #endregion

    }
}
