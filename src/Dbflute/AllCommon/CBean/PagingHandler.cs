
using System;
using System.Collections.Generic;

namespace Dbflute.AllCommon.CBean {

    public interface PagingHandler<ENTITY> {

        PagingBean PagingBean { get; }
        int Count();
        IList<ENTITY> Paging();
    }
}
