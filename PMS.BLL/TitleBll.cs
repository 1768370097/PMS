﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMS.Dao;
using PMS.Model;

namespace PMS.BLL
{
    using System.Data;
    using Result = Enums.OpResult;
    public class TitleBll
    {
        private TitleDao dao = new TitleDao();
        private PublicProcedure pdao = new PublicProcedure();

        /// <summary>
        /// 添加题目
        /// </summary>
        /// <param name="news">题目实体</param>
        /// <returns>返回处理结果</returns>
        public Enums.OpResult Insert(Title title)
        {
            int count = dao.Insert(title);
            if (count>0)
            {
                return Result.添加成功;
            }
            else
            {
                return Result.添加失败;
            }
        }

        /// <summary>
        /// 修改题目
        /// </summary>
        /// <param name="news">题目实体</param>
        /// <returns>返回处理结果</returns>
        public Enums.OpResult Delete(int titleId)
        {
            int count = dao.Delete(titleId);
            if (count>0)
            {
                return Result.删除成功;
            }
            else
            {
                return Result.删除失败;
            }
        }

        public Enums.OpResult Update(Title title)
        {
            int count = dao.Update(title);
            if (count>0)
            {
                return Result.更新成功;
            }
            else
            {
                return Result.更新失败;
            }
        }

        /// <summary>
        /// 根据id查询题目信息
        /// </summary>
        /// <param name="newsId">题目id</param>
        /// <returns>返回查询结果</returns>
        public DataSet Select(int titleId)
        {
            DataSet ds = dao.Select(titleId);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return ds;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 分页查询方法
        /// </summary>
        /// <param name="tablebuilder">参数实体</param>
        /// <param name="intPageCount">输出参数，总页数</param>
        /// <returns>返回分页结果数据</returns>
        public DataSet SelectBypage(TableBuilder tablebuilder, out int intPageCount)
        {
            DataSet ds = pdao.SelectBypage(tablebuilder, out intPageCount);
            if (ds!=null && ds.Tables[0].Rows.Count > 0)
            {
                return ds;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获得题目实体对象
        /// </summary>
        /// <param name="titleId"></param>
        /// <returns></returns>
        public Title GetTitle(int titleId)
        {
           return dao.GetTitle(titleId);
        }


    }
}
