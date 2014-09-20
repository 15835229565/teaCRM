
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using NLite.Data;
using teaCRM.DBContext;
using teaCRM.Entity;

namespace teaCRM.Dao
{
public  interface ITCusConDao:ITableDao<TCusCon>
{
    #region ��д����չ���� 2014-08-21 14:58:50 By �����
    /// <summary>
    /// ��ȡ��ϵ����Ϣ�б�
    /// </summary>
    /// <param name="compNum">��ҵ���</param>
    /// <param name="selectFields">ѡ����ֶ�</param>
    /// <param name="pageIndex">ҳ��</param>
    /// <param name="pageSize">ÿҳ����Ŀ</param>
    /// <param name="strWhere">ɸѡ����</param>
    /// <param name="filedOrder">�����ֶ�</param>
    /// <param name="recordCount">��¼����</param>
    /// <returns>DataTable</returns>
    DataTable GetContactLsit(string compNum, string[] selectFields, int pageIndex, int pageSize,
        string strWhere, string filedOrder, out int recordCount);
    #endregion
}
	   }
