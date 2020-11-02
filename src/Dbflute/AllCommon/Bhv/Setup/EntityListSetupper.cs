
using System;
using System.Collections.Generic;

using Dbflute.AllCommon;

namespace Dbflute.AllCommon.Bhv.Setup {

    public delegate void EntityListSetupper<ENTITY>(IList<ENTITY> entityList) where ENTITY : Entity;
}
