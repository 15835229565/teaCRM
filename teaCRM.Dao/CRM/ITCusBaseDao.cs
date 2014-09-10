using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NLite.Data;
using teaCRM.DBContext;
using teaCRM.Entity;

namespace teaCRM.Dao
{
    public interface ITCusBaseDao : ITableDao<TCusBase>, IViewDao<TCusBase>
    {
        #region ��д����չ���� 2014-09-05 14:58:50 By �����

        /// <summary>
        /// ʹ��where sql�����Ŀͻ�״̬(ֻ��������) 2014-09-05 14:58:50 By �����
        /// </summary>
        /// <param name="strSet">Ҫ���µ��ֶ�</param>
        /// <param name="strWhere">����</param>
        /// <returns></returns>
        bool UpdateCustomerStatusByWhere(string strSet, string strWhere);

        /// <summary>
        /// ʹ��LINQ���Ŀͻ�״̬��ֻ�������� 2014-09-05 14:58:50 By �����
        /// </summary>
        /// <param name="fields">Ҫ���µ��ֶ�</param>
        /// <param name="predicate">����</param>
        /// <returns></returns>
        bool UpdateCustomerStatusByLINQ(Dictionary<string, object> fields,
            Expression<Func<TCusBase, bool>> predicate);

        #endregion
    }
}