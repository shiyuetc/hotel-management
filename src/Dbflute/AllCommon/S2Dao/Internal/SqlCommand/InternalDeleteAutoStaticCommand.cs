
using System.Text;
using Seasar.Extension.ADO;
using Seasar.Dao;
using Seasar.Dao.Impl;

using Dbflute.AllCommon.S2Dao.Internal.SqlHandler;

namespace Dbflute.AllCommon.S2Dao.Internal.SqlCommand {

    public class InternalDeleteAutoStaticCommand : InternalAbstractAutoStaticCommand {

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public InternalDeleteAutoStaticCommand(IDataSource dataSource, ICommandFactory commandFactory,
            IBeanMetaData beanMetaData, string[] propertyNames)
            : base(dataSource, commandFactory, beanMetaData, propertyNames) {
        }

        // ===============================================================================
        //                                                                        Override
        //                                                                        ========
        protected override InternalAbstractAutoHandler CreateAutoHandler() {
            return new InternalDeleteAutoHandler(DataSource, CommandFactory, BeanMetaData, PropertyTypes);
        }
        protected override void SetupSql() {
            SetupDeleteSql();
        }
        protected override void SetupPropertyTypes(string[] propertyNames) {
            SetupDeletePropertyTypes(propertyNames);
        }
	}
}
