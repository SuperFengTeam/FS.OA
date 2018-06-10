using FY.MVC.Entity;
using FY.MVC.IDAL;
using SqlSugar;
using System;
using System.Collections.Generic;

namespace FY.MVC.DAL
{
    public class SetOfBooksRecordDal : DalBase,  ISetOfBooksRecordDal
    {
        public IEnumerable<IEntityBase> GetList(ref int total, int take, int skip, Dictionary<string, string> searchParams)
        {
            var db = DbFactory.GetSugarInstance();
            var qable = db.Queryable<M_SetOfBooks_Record>();

            if (searchParams.ContainsKey("SetOfBooksID"))
            {
                var setOfBooksId = new Guid(searchParams["SetOfBooksID"]);

                qable = qable.Where(x => x.SetOfBooksID == setOfBooksId);
            }

            qable = qable.OrderBy(s1 => s1.SetOfBooksID, OrderByType.Asc);

            var valuePair = qable.ToPageListAsync((skip / take) + 1, take, 0);

            valuePair.Wait();

            var restult = valuePair.Result;

            var list = restult.Key;

            total = restult.Value;

            return list;
        }
    }
}
