using System;
using System.Data;

namespace PMS.Model
{
    /// <summary>ѡ���¼��</summary>
    public class T_TitleRecord
    {
        /// <summary>ѡ���¼id</summary>
        public int titleRecordId { get; set;}
        /// <summary>ѧ��id(���ѧ����)</summary>
        public string stuAccount{ get; set; }
        /// <summary>��Ŀid(�����Ŀ��)</summary>
        public int titleId{ get; set; }
        /// <summary>���С��id</summary>
        public int defeseTeamId{ get; set; }
    }
}
