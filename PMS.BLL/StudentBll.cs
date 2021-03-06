﻿using PMS.Dao;
using PMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PMS.BLL
{
    public class StudentBll
    {
        StudentDao dao = new StudentDao();

        private PublicProcedure pdao = new PublicProcedure();
        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="student">学生实体</param>
        /// <returns></returns>
        public Enums.OpResult Insert(Student student)
        {
            int count = dao.Insert(student);
            if (count > 0)
            {
                return Enums.OpResult.添加成功;
            }
            else
            {
                return Enums.OpResult.添加失败;
            }
        }
        /// <summary>
        /// 删除学生
        /// </summary>
        /// <param name="StuAccount">学生主键</param>
        /// <returns></returns>
        public Enums.OpResult delete(String StuAccount)
        {
            int count = dao.delete(StuAccount);
            if (count > 0)
            {
                return Enums.OpResult.删除成功;
            }
            else
            {
                return Enums.OpResult.删除失败;
            }
        }
        /// <summary>
        /// 更新学生
        /// </summary>
        /// <param name="student">学生实体</param>
        /// <returns></returns>
        public Enums.OpResult Updata(Student student)
        {
            int count = dao.Updata(student);
            if (count > 0)
            {
                return Enums.OpResult.删除成功;
            }
            else
            {
                return Enums.OpResult.删除失败;
            }
        }

        /// <summary>
        /// 得到学生实体对象
        /// </summary>
        /// <param name="TeaAccount">学生账号</param>
        /// <returns>学生实体</returns>
        public Student GetModel(String stuAccount)
        {
            return dao.GetStudent(stuAccount);
        }

        /// <summary>
        /// 根据TableBuilder实体返回DataSet数据
        /// </summary>
        /// <param name="tablebuilder"></param>
        /// <param name="intPageCount"></param>
        /// <returns></returns>
        public DataSet SelectBypage(TableBuilder tablebuilder, out int intPageCount)
        {
            int pagecount;
            DataSet ds = pdao.SelectBypage(tablebuilder, out pagecount);
            intPageCount = pagecount;
            return ds;
        }
    }
}
