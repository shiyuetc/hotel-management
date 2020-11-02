
using System;
using Dbflute.AllCommon.Dbm;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.Dbm.Info {
    
    public interface RelationInfo {

        String RelationPropertyName { get; }
        DBMeta LocalDBMeta { get; }
        DBMeta TargetDBMeta { get; }
        Map<ColumnInfo,ColumnInfo> LocalTargetColumnInfoMap { get; }
        bool IsOneToOne { get; }
        bool IsReferrer { get; }
    }
}
