
using System;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;

namespace Dbflute.AllCommon.CBean {

// JavaLike
public interface ConditionQuery {

    // ===================================================================================
    //                                                                          Table Name
    //                                                                          ==========
    String getTableDbName();
    String getTableSqlName();
	
    // ===================================================================================
    //                                                                  Important Accessor
    //                                                                  ==================
    ConditionQuery xgetReferrerQuery();
    SqlClause xgetSqlClause();
    String xgetAliasName();
    String toColumnRealName(String columnName);
    int xgetNestLevel();
    int xgetNextNestLevel();
    bool isBaseQuery();
	String xgetForeignPropertyName();
    String xgetRelationPath();
    String xgetLocationBase();
	
    // ===================================================================================
    //                                                                 Reflection Invoking
    //                                                                 ===================
    ConditionValue invokeValue(String columnFlexibleName);
    void invokeQuery(String columnFlexibleName, String conditionKeyName, Object value);
    void invokeOrderBy(String columnFlexibleName, bool isAsc);
    ConditionQuery invokeForeignCQ(String foreignPropertyName);
    bool invokeHasForeignCQ(String foreignPropertyName);
}

}
