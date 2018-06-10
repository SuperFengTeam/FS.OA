//-----------------------------------------------------------------------
// <copyright file="SetOfBooksDAL.cs" company="DHC">
//     Copyright (C) 2018
//     功能描述：SetOfBooksDAL 
//     创建标识：jbl     ADD     2018-01-22
//     修改标识：
// </copyright>
//-----------------------------------------------------------------------

using FY.MVC.Entity;
using FY.MVC.IDAL;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FY.MVC.DAL
{
    public class SetOfBooksDal : DalBase, ISetOfBooksDal
    {
        /// <summary>
        /// 查询账套
        /// </summary>
        /// <param name="total"></param>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <param name="searchParams"></param>
        /// <returns></returns>
        public IEnumerable<IEntityBase> GetList(ref int total, int take, int skip, Dictionary<string, string> searchParams)
        {
            var db = DbFactory.GetSugarInstance();
            var qable = db.Queryable<M_SetOfBooks>();

            if (searchParams.ContainsKey("q_SetOfBooksName"))
            {
                var setOfBooksName = (searchParams["q_SetOfBooksName"]).ToString();
                qable = qable.Where(s1 => s1.SetOfBooksName == setOfBooksName);
            }

            qable = qable.OrderBy(s1 => s1.SetOfBooksID, OrderByType.Asc);

            var valuePair = qable.ToPageListAsync((skip / take) + 1, take, 0);

            valuePair.Wait();

            var restult = valuePair.Result;

            var list = restult.Key;

            total = restult.Value;

            return list;
        }

        public M_SetOfBooks GetSetOfBooksByCode(M_SetOfBooks setOfBooksEntity)
        {
            var db = DbFactory.GetSugarInstance();
            var result = db.Queryable<M_SetOfBooks>().Where(x => x.SetOfBooksCode == setOfBooksEntity.SetOfBooksCode).SingleAsync();
            result.Wait();
            return result.Result;
        }

        public List<SelectEntity> GetAll()
        {
            var db = DbFactory.GetSugarInstance();
            var now = this.GetDateTime();

            var result = db.Queryable<M_SetOfBooks>()
                .Where(x => x.DelFlg!=false && x.StartTime <= (DateTime?)now && x.EndTime >= (DateTime?)now)
                .Select(x => new SelectEntity() { id = x.SetOfBooksID, text = x.SetOfBooksName }).ToListAsync();

            result.Wait();
            return result.Result;
        }

    }
}
