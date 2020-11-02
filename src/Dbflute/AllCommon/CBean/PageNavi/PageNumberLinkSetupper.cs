
using System;

namespace Dbflute.AllCommon.CBean.PageNavi {

    public delegate LINK PageNumberLinkSetupper<LINK>(int pageNumberElement, bool current) where LINK : PageNumberLink;
}

