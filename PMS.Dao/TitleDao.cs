﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using PMS.DBHelper;
using PMS.Model;

namespace PMS.Dao
{
    public class TitleDao
    {
        private SQLHelper db = new SQLHelper();

        /// <summary>
        /// 向数据库中添加一条题目信息
        /// </summary>
        /// <param name="title">题目实体</param>
        /// <returns>受影响行数</returns>
        public int Insert(Title title)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("insert into T_Title ");
            strBuilder.Append("values(");          
            strBuilder.Append("@title, @titleContent,@createTime,@selected,@limit,@planId,@teaAccount,@proId)");
            string[] param = { "@title", "@titleContent","@createTime","@selected","@limit","@planId","@teaAccount","@proId" };
            object[] values = {title.title,title.TitleContent,title.CreateTime,title.Selected,title.Limit
            ,title.plan.PlanId,title.teacher.TeaAccount,title.profession.ProId};
            return db.ExecuteNoneQuery(strBuilder.ToString(), param, values);
        }

        /// <summary>
        /// 通过id删除一条题目信息
        /// </summary>
        /// <param name="TitleiId">题目id</param>
        /// <returns>返回受影响行数</returns>
        public int Delete(int TitleId)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("delete T_Title where ");
            strBuilder.Append("titleId=@titleId");
            string[] param = {"@titleId" };
            string[] values = { TitleId.ToString() };
            return db.ExecuteNoneQuery(strBuilder.ToString(),param,values);
        }

        /// <summary>
        /// 修改题目信息
        /// </summary>
        /// <param name="title">题目实体</param>
        /// <returns>受影响行数</returns>
        public int Update(Title title)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("update T_Title set ");
            strBuilder.Append("title=@title,");
            strBuilder.Append("titleContent=@titleContent,");
            strBuilder.Append("createTime=@createTime,");
            strBuilder.Append("selected=@selected,");
            strBuilder.Append("limit=@limit,");
            strBuilder.Append("planId=@planId,");
            strBuilder.Append("teaAccount=@teaAccount,");
            strBuilder.Append("proId=@proId  ");
            strBuilder.Append("where titleId=@titleId");
            string[] param = { "@titleId", "@title", "@titleContent", "@createTime", "@selected", "@limit",
            "@planId","@teaAccount","@proId"};
            string[] values = {title.TitleId.ToString(),title.title,title.TitleContent,title.CreateTime.ToString(),title.Selected.ToString(),
            title.Limit.ToString(),title.plan.PlanId.ToString(),title.teacher.TeaAccount,title.profession.ProId.ToString()};
            return db.ExecuteNoneQuery(strBuilder.ToString(), param, values);
        }

        /// <summary>
        /// 通过题目id查询题目信息
        /// </summary>
        /// <param name="titleId">题目id</param>
        /// <returns>返回结果集</returns>
        public DataSet Select(int titleId)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("slect * from V_Title");
            strBuilder.Append("where titleId=@titleid");
            string[] param = { "titleid" };
            string[] values = {titleId.ToString() };
            return db.FillDataSet(strBuilder.ToString(), param, values);
        }

        public Title GetTitle(int titleId)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("select * from V_Title where ");
            strBuilder.Append("titleId=@titleId");
            string[] param = {"@titleId" };
            string[] values = {titleId.ToString() };
            DataSet ds = db.FillDataSet(strBuilder.ToString(), param, values);
            Title title = new Title();
            Teacher teacher = new Teacher();
            College college = new College();
            Plan plan = new Plan();
            Profession profession = new Profession();
            if (ds != null && ds.Tables[0].Rows.Count >0)
            {
                if (ds.Tables[0].Rows[0]["titleId"].ToString()!="" && titleId.ToString() == ds.Tables[0].Rows[0]["titleId"].ToString())
                {
                    title.TitleId = int.Parse(ds.Tables[0].Rows[0]["titleId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["title"].ToString() != "")
                {
                    title.title = ds.Tables[0].Rows[0]["title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["titleContent"].ToString() != "")
                {
                    title.TitleContent = ds.Tables[0].Rows[0]["titleContent"].ToString();
                }
                if (ds.Tables[0].Rows[0]["createTime"].ToString() != "")
                {
                    title.CreateTime =DateTime.Parse(ds.Tables[0].Rows[0]["createTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["selected"].ToString() != "")
                {
                    title.Selected =int.Parse(ds.Tables[0].Rows[0]["selected"].ToString());
                }
                if (ds.Tables[0].Rows[0]["limit"].ToString() != "")
                {
                    title.Limit = int.Parse(ds.Tables[0].Rows[0]["limit"].ToString());
                }
                if (ds.Tables[0].Rows[0]["teaAccount"].ToString() != "")
                {
                    teacher.TeaAccount = ds.Tables[0].Rows[0]["teaAccount"].ToString();
                }
                if (ds.Tables[0].Rows[0]["teaPwd"].ToString() != "")
                {
                    teacher.TeaPwd = ds.Tables[0].Rows[0]["teaPwd"].ToString();
                }
                if (ds.Tables[0].Rows[0]["teaName"].ToString() != "")
                {
                    teacher.TeaName = ds.Tables[0].Rows[0]["teaName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sex"].ToString() != "")
                {
                    teacher.Sex = ds.Tables[0].Rows[0]["sex"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Email"].ToString() != "")
                {
                    teacher.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                }
                if (ds.Tables[0].Rows[0]["phone"].ToString() != "")
                {
                    teacher.Phone = ds.Tables[0].Rows[0]["phone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["teaType"].ToString() != "")
                {
                    teacher.TeaType =int.Parse(ds.Tables[0].Rows[0]["teaType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["planId"].ToString()!="")
                {
                    plan.PlanId =int.Parse(ds.Tables[0].Rows[0]["planId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["planName"].ToString() != "")
                {
                    plan.PlanName = ds.Tables[0].Rows[0]["planName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["startTime"].ToString() != "")
                {
                    plan.StartTime =DateTime.Parse(ds.Tables[0].Rows[0]["startTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["endTime"].ToString() != "")
                {
                    plan.EndTime =DateTime.Parse(ds.Tables[0].Rows[0]["endTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["state"].ToString() != "")
                {
                    plan.State =int.Parse(ds.Tables[0].Rows[0]["state"].ToString());
                }
                if (ds.Tables[0].Rows[0]["collegeId"].ToString() != "")
                {
                    college.ColID = int.Parse(ds.Tables[0].Rows[0]["collegeId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["proId"].ToString() != "")
                {
                    profession.ProId = int.Parse(ds.Tables[0].Rows[0]["proId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["proName"].ToString()!="")
                {
                    profession.ProName = ds.Tables[0].Rows[0]["proName"].ToString();
                }
                if (teacher !=null)
                {
                    title.teacher = teacher;
                }
                if (college!=null)
                {
                    title.college = college;
                }
                if (plan!=null)
                {
                    title.plan = plan;
                }
                if (profession!=null)
                {
                    title.profession = profession;
                }

            }
            return title;
        }


    }
}
