using System;
using System.Data;
namespace PMS.Model
{
    /// <summary>TNews(�����ʵ����)</summary>
    [Serializable()]
    public class News
    {

        /// <summary>����id</summary>
        public int newsId { get; set; }
       
        /// <summary>�������</summary>
        public string newsTitle { get; set; }
    
        /// <summary>��������</summary>
        public string newsContent { get; set; }
       
        /// <summary>���淢��ʱ��</summary>
        public System.DateTime createTime { get; set; }
    
        /// <summary>���淢����(�����ʦ��Ϣ��)</summary>
        public string teaAccount { get; set; }

        public News() { }
        
    }
}
