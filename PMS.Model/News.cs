using System;
using System.Data;
namespace PMS.Model
{
    /// <summary>
    /// TNews(�����ʵ����)
    /// </summary>
    [Serializable()]
    public class News
    {  
        /// <summary>
        /// ����id
        /// </summary>
        public int NewsId { get; set; }
       
        /// <summary>
        /// �������
        /// </summary>
        public string NewsTitle { get; set; }
    
        /// <summary>
        /// ��������
        /// </summary>
        public string NewsContent { get; set; }
       
        /// <summary>
        /// ���淢��ʱ��
        /// </summary>
        public System.DateTime CreateTime { get; set; }
    
        /// <summary>
        /// ���淢����(�����ʦ��Ϣ��)
        /// </summary>
        public Teacher teacher { get; set; }

        /// <summary>
        /// ��Ժ��Ϣ�������Ժ��
        /// </summary>
        public College college { get; set; }

        /// <summary>
        /// �޲ι��캯��
        /// </summary>
        public News() { }

        /// <summary>
        /// �вι��캯��
        /// </summary>
        /// <param name="newsId"></param>
        /// <param name="newsTitle"></param>
        /// <param name="newsContent"></param>
        /// <param name="createTime"></param>
        /// <param name="teacher"></param>
        public News(int newsId, string newsTitle, string newsContent, DateTime createTime, Teacher teacher)
        {
            NewsId = newsId;
            NewsTitle = newsTitle;
            NewsContent = newsContent;
            CreateTime = createTime;
            this.teacher = teacher;
        }

    }
}
