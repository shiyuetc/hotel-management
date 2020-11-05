
using System;
using System.Collections.Generic;

using Seasar.Quill.Attrs;
using Seasar.Dao.Attrs;

using Dbflute.AllCommon;
using Dbflute.AllCommon.S2Dao;
using Dbflute.ExEntity;
using Dbflute.CBean;

namespace Dbflute.ExDao {

    [Implementation]
    [S2Dao(typeof(S2DaoSetting))]
    [Bean(typeof(Employee))]
    public partial interface EmployeeDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(EmployeeCB cb);
        IList<Employee> SelectList(EmployeeCB cb);

        int Insert(Employee entity);
        int UpdateModifiedOnly(Employee entity);
        int UpdateNonstrictModifiedOnly(Employee entity);
        int UpdateByQuery(EmployeeCB cb, Employee entity);
        int Delete(Employee entity);
        int DeleteNonstrict(Employee entity);
        int DeleteByQuery(EmployeeCB cb);// {DBFlute-0.7.9}

        long? SelectNextVal();
    }
}
