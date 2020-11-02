
using System;
using System.Collections.Generic;

using Dbflute.AllCommon;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.Bhv.Setup;

namespace Dbflute.AllCommon.Bhv.Load {

    public class LoadReferrerOption<REFERRER_CB, REFERRER_ENTITY> where REFERRER_CB : ConditionBean where REFERRER_ENTITY : Entity {

        // ===================================================================================
        //                                                                           Attribute
        //                                                                           =========
        protected ConditionBeanSetupper<REFERRER_CB> _conditionBeanSetupper;
        protected EntityListSetupper<REFERRER_ENTITY> _entityListSetupper;
        protected REFERRER_CB _referrerConditionBean;

        // ===================================================================================
        //                                                                         Constructor
        //                                                                         ===========
        public LoadReferrerOption() {
        }

        public LoadReferrerOption<REFERRER_CB, REFERRER_ENTITY> xinit(
                ConditionBeanSetupper<REFERRER_CB> conditionBeanSetupper) { // internal
            this.ConditionBeanSetupper = conditionBeanSetupper;
            return this;
        }

        // ===================================================================================
        //                                                                         Easy-to-Use
        //                                                                         ===========
        public void delegateConditionBeanSettingUp(REFERRER_CB cb) { // internal
            if (_conditionBeanSetupper != null) {
                _conditionBeanSetupper.Invoke(cb);
            }
        }

        public void delegateEntitySettingUp(IList<REFERRER_ENTITY> entityList) { // internal
            if (_entityListSetupper != null) {
                _entityListSetupper.Invoke(entityList);
            }
        }

        // ===================================================================================
        //                                                                            Accessor
        //                                                                            ========
        public ConditionBeanSetupper<REFERRER_CB> ConditionBeanSetupper { get {
            return _conditionBeanSetupper;
        } set {
            this._conditionBeanSetupper = value;
        }}

        public EntityListSetupper<REFERRER_ENTITY> EntityListSetupper { get {
            return _entityListSetupper;
        } set {
            this._entityListSetupper = value;
        }}

        public REFERRER_CB ReferrerConditionBean { get {
            return _referrerConditionBean;
        } set {
            this._referrerConditionBean = value;
        }}
    }
}
