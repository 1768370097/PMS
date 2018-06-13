using System;
using System.Data;
namespace PMS.Model
{

    /// <summary>T_Teacher</summary>
    [Serializable()]
    public class T_Teacher
    {
        /// <summary>��ʦ����Ա�˺�</summary>
        public string teaAccount { get; set; }

        /// <summary>��ʦ����Ա����</summary>
        public string teaPwd { get; set; }
        
        /// <summary>��ʦ����Ա����</summary>
        public string teaName { get; set; }
       
        /// <summary>��ʦ����Ա�Ա�</summary>
        public string sex { get; set; }
        
        /// <summary>��ʦ����Ա��ϵ�绰</summary>
        public string phone { get; set; }
        
        /// <summary>��ʦ����Ա����</summary>
        public string Email { get; set; }
        
        /// <summary>��Ժid(�����Ժ��)</summary>
        public int collegeId { get; set; }
        
        /// <summary>��ɫ�������(��ʦ1,����Ա2,��������Ա3)</summary>
        public int teaType { get; set; }

        public T_Teacher() { }

    }
}
