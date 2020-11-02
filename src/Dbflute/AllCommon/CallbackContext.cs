
using System;
using System.Threading;

using Dbflute.AllCommon.Ado;

namespace Dbflute.AllCommon {

    public class CallbackContext {

        private static LocalDataStoreSlot _slot = Thread.AllocateDataSlot();

        public static CallbackContext GetCallbackContextOnThread() {
            return (CallbackContext)Thread.GetData(_slot);
        }

        public static void SetCallbackContextOnThread(CallbackContext context) {
            if (context == null) {
                String msg = "The argument[context] must not be null.";
                throw new ArgumentNullException(msg);
            }
            Thread.SetData(_slot, context);
        }

        public static void ClearCallbackContextOnThread() {
            Thread.SetData(_slot, null);
        }

        public static bool IsExistCallbackContextOnThread() {
            return (Thread.GetData(_slot) != null);
        }

		protected SqlLogHandler _sqlLogHandler;
		protected SqlResultHandler _sqlResultHandler;

		public SqlLogHandler SqlLogHandler {
		    get { return _sqlLogHandler; }
			set { _sqlLogHandler = value; }
		}
		public SqlResultHandler SqlResultHandler {
		    get { return _sqlResultHandler; }
			set { _sqlResultHandler = value; }
		}
    }
}
