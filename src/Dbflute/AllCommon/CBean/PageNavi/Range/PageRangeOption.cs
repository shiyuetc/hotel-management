
using System;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.CBean.PageNavi.Range {

[System.Serializable]
public class PageRangeOption {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    public int _pageRangeSize;
    public int PageRangeSize { get { return _pageRangeSize; } set { _pageRangeSize = value; } }
    public bool _isFillLimit;
    public bool IsFillLimit { get { return _isFillLimit; } set { _isFillLimit = value; } }

    // ===================================================================================
    //                                                                      Basic Override
    //                                                                      ==============
    public override String ToString() {
        StringBuilder sb = new StringBuilder();
        sb.append("{");
        sb.append("pageRangeSize=").append(PageRangeSize);
        sb.append(", fillLimit=").append(IsFillLimit);
        sb.append("}");
        return sb.toString();
    }
}

}
