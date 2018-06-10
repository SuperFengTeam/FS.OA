using FY.MVC.Entity;
using FY.MVC.IDAL;
using System.Collections.Generic;
using System.Linq;

namespace FY.MVC.DAL
{
    public class PageAuthorityDal : DalBase, IPageAuthorityDal
    {
        public bool UpdatePageAuthority(List<M_PageAuthority> entitys)
        {
            var db = DbFactory.GetSugarInstance();

            var result = db.Ado.UseTran(() =>
            {
                var delete = db.Deleteable<M_PageAuthority>();
                var RoleId = entitys.First().RoleId;
                var userId = entitys.First().UserId;

                if (RoleId != null)
                {
                    delete = delete.Where(x => x.RoleId == RoleId);
                }
                else
                {
                    delete = delete.Where(x => x.UserId == userId);
                }

                var deleteResult = delete.ExecuteCommandAsync();

                deleteResult.Wait();

                db.Insertable<M_PageAuthority>(entitys).ExecuteCommandAsync();
            });

            return result.IsSuccess;
        }

        public List<M_PageAuthority> SelectPageAuthority(string id)
        {
            var db = DbFactory.GetSugarInstance();

            return db.Queryable<M_PageAuthority>().Where(x => x.Id.ToString() == id).ToListAsync().Result;
        }

    }
}
