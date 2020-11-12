
using System;

using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon {

    public static class CDef {

        /**
         * 従業員の職位を表す
         */
        public class Rank {
            /** System Maintenancer: システム保守 */
            public static readonly Rank SystemMaintenancer = new Rank("000", "SystemMaintenancer", "System Maintenancer");
            /** Assistant Manager: アシスタントマネージャー */
            public static readonly Rank AssistantManager = new Rank("001", "AssistantManager", "Assistant Manager");
            /** Financial Controller: ファイナンシャルコントローラー */
            public static readonly Rank FinancialController = new Rank("002", "FinancialController", "Financial Controller");
            /** Front Clerk: フロントクラーク */
            public static readonly Rank FrontClerk = new Rank("003", "FrontClerk", "Front Clerk");
            private static readonly Map<String, Rank> _codeValueMap = new LinkedHashMap<String, Rank>();
            static Rank() {
                _codeValueMap.put(SystemMaintenancer.Code.ToLower(), SystemMaintenancer);
                _codeValueMap.put(AssistantManager.Code.ToLower(), AssistantManager);
                _codeValueMap.put(FinancialController.Code.ToLower(), FinancialController);
                _codeValueMap.put(FrontClerk.Code.ToLower(), FrontClerk);
            }
            protected String _code; protected String _name; protected String _alias;
            public Rank(String code, String name, String alias) {
                _code = code; _name = name; _alias = alias;
            }
            public String Code { get { return _code; } }
            public String Name { get { return _name; } }
            public String Alias { get { return _alias; } }
            public static Rank CodeOf(Object code) {
                if (code == null) { return null; } if (code is Rank) { return (Rank)code; }
                return _codeValueMap.get(code.ToString().ToLower());
            }
            public static Rank[] Values { get {
                Rank[] values = new Rank[_codeValueMap.size()];
                int index = 0;
                foreach (Rank flg in _codeValueMap.values()) {
                    values[index] = flg;
                    ++index;
                }
                return values;
            }}
            public override int GetHashCode() { return 7 + _code.GetHashCode(); }
            public override bool Equals(Object obj) {
                if (!(obj is Rank)) { return false; }
                Rank cls = (Rank)obj;
                return _code.ToLower().Equals(cls.Code.ToLower());
            }
            public override String ToString() { return this.Code; }
        }

    }

}
