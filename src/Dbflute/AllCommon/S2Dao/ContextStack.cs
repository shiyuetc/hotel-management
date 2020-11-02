
using System;
using System.Collections.Generic;
using System.Threading;

using Dbflute.AllCommon;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.OutsideSql;

namespace Dbflute.AllCommon.S2Dao {

    public class ContextStack {

        private static LocalDataStoreSlot _slot = Thread.AllocateDataSlot();

        public static Stack<ContextStack> GetContextStackOnThread() {
            return (Stack<ContextStack>)Thread.GetData(_slot);
        }

        public static void ClearContextStackOnThread() {
            Thread.SetData(_slot, null);
        }

        public static bool IsExistContextStackOnThread() {
            return (Thread.GetData(_slot) != null);
        }

        public static void SaveAllContextOnThread() {
            if (!IsExistContextStackOnThread()) {
                Thread.SetData(_slot, new Stack<ContextStack>());
            }
            ContextStack contextStack = new ContextStack();
            if (ConditionBeanContext.IsExistConditionBeanOnThread()) {
                contextStack.ConditionBean = ConditionBeanContext.GetConditionBeanOnThread();
            }
            if (OutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                contextStack.OutsideSqlContext = OutsideSqlContext.GetOutsideSqlContextOnThread();
            }
            if (FetchNarrowingBeanContext.IsExistFetchNarrowingBeanOnThread()) {
                contextStack.FetchNarrowingBean = FetchNarrowingBeanContext.GetFetchNarrowingBeanOnThread();
            }
            if (InternalMapContext.IsExistInternalMapOnThread()) {
                contextStack.InternalMap = InternalMapContext.GetInternalMap();
            }
            GetContextStackOnThread().Push(contextStack);
        }

        public static void RestoreAllContextOnThreadIfExists() {
            if (!IsExistContextStackOnThread()) {
                return;
            }
            Stack<ContextStack> stackOnThread = GetContextStackOnThread();
            if (stackOnThread.Count == 0) {
                ClearContextStackOnThread();
                return;
            }
            ContextStack contextStack = stackOnThread.Pop();
            ConditionBean cb = contextStack.ConditionBean;
            if (cb != null) {
                ConditionBeanContext.SetConditionBeanOnThread(cb);
            }
            OutsideSqlContext outsideSqlContext = contextStack.OutsideSqlContext;
            if (outsideSqlContext != null) {
                OutsideSqlContext.SetOutsideSqlContextOnThread(outsideSqlContext);
            }
            FetchNarrowingBean fetchNarrowingBean = contextStack.FetchNarrowingBean;
            if (fetchNarrowingBean != null) {
                FetchNarrowingBeanContext.SetFetchNarrowingBeanOnThread(fetchNarrowingBean);
            }
            IDictionary<String, Object> internalMap = contextStack.InternalMap;
            if (internalMap != null) {
                InternalMapContext.ClearInternalMapOnThread();
                foreach (String key in internalMap.Keys) {
                    Object value = internalMap[key];
                    InternalMapContext.SetObject(key, value);
                }
            }
        }

        public static void ClearAllCurrentContext() {
            if (ConditionBeanContext.IsExistConditionBeanOnThread()) {
                ConditionBeanContext.ClearConditionBeanOnThread();
            }
            if (OutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                OutsideSqlContext.ClearOutsideSqlContextOnThread();
            }
            if (FetchNarrowingBeanContext.IsExistFetchNarrowingBeanOnThread()) {
                FetchNarrowingBeanContext.ClearFetchNarrowingBeanOnThread();
            }
            if (InternalMapContext.IsExistInternalMapOnThread()) {
                InternalMapContext.ClearInternalMapOnThread();
            }
        }

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected ConditionBean _conditionBean;
        protected OutsideSqlContext _outsideSqlContext;
        protected FetchNarrowingBean _fetchNarrowingBean;
        protected IDictionary<String, Object> _internalMap;

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public ConditionBean ConditionBean {
            get { return _conditionBean; }
            set { this._conditionBean = value; }
        }

        public OutsideSqlContext OutsideSqlContext {
            get { return _outsideSqlContext; }
            set { this._outsideSqlContext = value; }
        }

        public FetchNarrowingBean FetchNarrowingBean {
            get { return _fetchNarrowingBean; }
            set { this._fetchNarrowingBean = value; }
        }

        public IDictionary<String, Object> InternalMap {
            get { return _internalMap; }
            set { this._internalMap = value; }
        }
    }
}
