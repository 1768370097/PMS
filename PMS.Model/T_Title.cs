using System;
using System.Data;

namespace PMS.Model
{
    /// <summary>��Ŀ��ʵ��</summary>
    public class T_Title
    {
        /// <summary>��Ŀid</summary>
        public int titleId{ get;  set;}
        /// <summary>��Ŀ����</summary>
        public string title{ get; set; }
        /// <summary>��Ŀ����</summary>
        public string titleContent { get; set; }
        /// <summary>���ʱ��</summary>
        public System.DateTime createTime { get; set; }
        /// <summary>��ѡ����</summary>
        public int selected { get; set; }
        /// <summary>��Ŀ����ѡ������</summary>
        public int limit { get; set; }
        /// <summary>����id(������α�)</summary>
        public int planId { get; set; }
        /// <summary>������id(�����ʦ��)</summary>
        public string teaAccount{ get; set; }
        /// <summary>רҵid(���רҵ��)</summary>
        public int proId { get; set; }
    }
}
