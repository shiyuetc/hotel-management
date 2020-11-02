
using System;
using System.Text;
using Seasar.Extension.ADO;
using Seasar.Dao;
using Seasar.Dao.Impl;

using Dbflute.AllCommon.S2Dao.Internal.SqlHandler;

namespace Dbflute.AllCommon.S2Dao.Internal.SqlCommand {

    public class InternalUpdateDynamicCommand : AbstractDynamicCommand {

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public InternalUpdateDynamicCommand(IDataSource dataSource, ICommandFactory commandFactory)
            : base(dataSource, commandFactory) {
        }

        // ===============================================================================
        //                                                                         Execute
        //                                                                         =======
        public override object Execute(object[] args) {
            ICommandContext ctx = Apply(args);
            InternalBasicUpdateHandler handler = new InternalBasicUpdateHandler(DataSource, ctx.Sql, CommandFactory);
            Object[] bindVariables = ctx.BindVariables;
            handler.LoggingMessageSqlArgs = bindVariables;
            return handler.Execute(bindVariables, ctx.BindVariableTypes);
        }
	}
}
