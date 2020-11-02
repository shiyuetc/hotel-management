
using System;

namespace Dbflute.AllCommon.CBean.Grouping {

public class GroupingOption<ENTITY> {

    // =====================================================================================
    //                                                                             Attribute
    //                                                                             =========
    protected int _elementCount;

    protected GroupingRowEndDeterminer<ENTITY> _groupingRowEndDeterminer;

    // =====================================================================================
    //                                                                           Constructor
    //                                                                           ===========
    /**
     * Constructor. You should set the determiner of grouping row end after you create the instance.
     */
    public GroupingOption() {
    }

    /**
     * Constructor.
     * @param elementCount The count of row element in a group.
     */
    public GroupingOption(int elementCount) {
        _elementCount = elementCount;
    }

    // =====================================================================================
    //                                                                              Accessor
    //                                                                              ========
    public int ElementCount { get {
        return this._elementCount;
    }}

    public GroupingRowEndDeterminer<ENTITY> GroupingRowEndDeterminer { get {
        return this._groupingRowEndDeterminer;
    } set {
        this._groupingRowEndDeterminer = value;
    }}
}

}
