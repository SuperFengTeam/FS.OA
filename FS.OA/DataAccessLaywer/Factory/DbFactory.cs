using SqlSugar;

namespace FS.OA.DataAccessLaywer
{
    public class DbFactory
    {
        public static SqlSugarClient GetSugarInstance()
        {
            return SugarDao.GetInstance();
        }

    }
}
