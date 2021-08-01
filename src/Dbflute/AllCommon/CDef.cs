
using System;

using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon {

    public static class CDef {

        /**
         * メニュー区分
         */
        public class メニュー区分 {
            /** ログアウト: 9999 */
            public static readonly メニュー区分 ログアウト = new メニュー区分("01", "ログアウト", "ログアウト");
            /** 予約管理: 10 */
            public static readonly メニュー区分 予約管理 = new メニュー区分("02", "予約管理", "予約管理");
            /** 宿泊履歴: 20 */
            public static readonly メニュー区分 宿泊履歴 = new メニュー区分("03", "宿泊履歴", "宿泊履歴");
            /** 顧客管理: 30 */
            public static readonly メニュー区分 顧客管理 = new メニュー区分("04", "顧客管理", "顧客管理");
            /** 従業員管理: 40 */
            public static readonly メニュー区分 従業員管理 = new メニュー区分("05", "従業員管理", "従業員管理");
            /** 客室管理: 50 */
            public static readonly メニュー区分 客室管理 = new メニュー区分("06", "客室管理", "客室管理");
            private static readonly Map<String, メニュー区分> _codeValueMap = new LinkedHashMap<String, メニュー区分>();
            static メニュー区分() {
                _codeValueMap.put(ログアウト.Code.ToLower(), ログアウト);
                _codeValueMap.put(予約管理.Code.ToLower(), 予約管理);
                _codeValueMap.put(宿泊履歴.Code.ToLower(), 宿泊履歴);
                _codeValueMap.put(顧客管理.Code.ToLower(), 顧客管理);
                _codeValueMap.put(従業員管理.Code.ToLower(), 従業員管理);
                _codeValueMap.put(客室管理.Code.ToLower(), 客室管理);
            }
            protected String _code; protected String _name; protected String _alias;
            public メニュー区分(String code, String name, String alias) {
                _code = code; _name = name; _alias = alias;
            }
            public String Code { get { return _code; } }
            public String Name { get { return _name; } }
            public String Alias { get { return _alias; } }
            public static メニュー区分 CodeOf(Object code) {
                if (code == null) { return null; } if (code is メニュー区分) { return (メニュー区分)code; }
                return _codeValueMap.get(code.ToString().ToLower());
            }
            public static メニュー区分[] Values { get {
                メニュー区分[] values = new メニュー区分[_codeValueMap.size()];
                int index = 0;
                foreach (メニュー区分 flg in _codeValueMap.values()) {
                    values[index] = flg;
                    ++index;
                }
                return values;
            }}
            public override int GetHashCode() { return 7 + _code.GetHashCode(); }
            public override bool Equals(Object obj) {
                if (!(obj is メニュー区分)) { return false; }
                メニュー区分 cls = (メニュー区分)obj;
                return _code.ToLower().Equals(cls.Code.ToLower());
            }
            public override String ToString() { return this.Code; }
        }

        /**
         * 職位区分
         */
        public class 職位区分 {
            /** システム保守: System Maintenancer */
            public static readonly 職位区分 システム保守 = new 職位区分("001", "システム保守", "システム保守");
            /** アシスタントマネージャー: Assistant Manager */
            public static readonly 職位区分 アシスタントマネージャー = new 職位区分("002", "アシスタントマネージャー", "アシスタントマネージャー");
            /** ファイナンシャルコントローラー: Financial Controller */
            public static readonly 職位区分 ファイナンシャルコントローラー = new 職位区分("003", "ファイナンシャルコントローラー", "ファイナンシャルコントローラー");
            /** フロントクラーク: Front Clerk */
            public static readonly 職位区分 フロントクラーク = new 職位区分("004", "フロントクラーク", "フロントクラーク");
            private static readonly Map<String, 職位区分> _codeValueMap = new LinkedHashMap<String, 職位区分>();
            static 職位区分() {
                _codeValueMap.put(システム保守.Code.ToLower(), システム保守);
                _codeValueMap.put(アシスタントマネージャー.Code.ToLower(), アシスタントマネージャー);
                _codeValueMap.put(ファイナンシャルコントローラー.Code.ToLower(), ファイナンシャルコントローラー);
                _codeValueMap.put(フロントクラーク.Code.ToLower(), フロントクラーク);
            }
            protected String _code; protected String _name; protected String _alias;
            public 職位区分(String code, String name, String alias) {
                _code = code; _name = name; _alias = alias;
            }
            public String Code { get { return _code; } }
            public String Name { get { return _name; } }
            public String Alias { get { return _alias; } }
            public static 職位区分 CodeOf(Object code) {
                if (code == null) { return null; } if (code is 職位区分) { return (職位区分)code; }
                return _codeValueMap.get(code.ToString().ToLower());
            }
            public static 職位区分[] Values { get {
                職位区分[] values = new 職位区分[_codeValueMap.size()];
                int index = 0;
                foreach (職位区分 flg in _codeValueMap.values()) {
                    values[index] = flg;
                    ++index;
                }
                return values;
            }}
            public override int GetHashCode() { return 7 + _code.GetHashCode(); }
            public override bool Equals(Object obj) {
                if (!(obj is 職位区分)) { return false; }
                職位区分 cls = (職位区分)obj;
                return _code.ToLower().Equals(cls.Code.ToLower());
            }
            public override String ToString() { return this.Code; }
        }

        /**
         * 客室利用区分
         */
        public class 客室利用区分 {
            /** 宿泊 */
            public static readonly 客室利用区分 宿泊 = new 客室利用区分("01", "宿泊", "宿泊");
            /** 清掃 */
            public static readonly 客室利用区分 清掃 = new 客室利用区分("02", "清掃", "清掃");
            /** 工事 */
            public static readonly 客室利用区分 工事 = new 客室利用区分("03", "工事", "工事");
            /** その他 */
            public static readonly 客室利用区分 その他 = new 客室利用区分("04", "その他", "その他");
            private static readonly Map<String, 客室利用区分> _codeValueMap = new LinkedHashMap<String, 客室利用区分>();
            static 客室利用区分() {
                _codeValueMap.put(宿泊.Code.ToLower(), 宿泊);
                _codeValueMap.put(清掃.Code.ToLower(), 清掃);
                _codeValueMap.put(工事.Code.ToLower(), 工事);
                _codeValueMap.put(その他.Code.ToLower(), その他);
            }
            protected String _code; protected String _name; protected String _alias;
            public 客室利用区分(String code, String name, String alias) {
                _code = code; _name = name; _alias = alias;
            }
            public String Code { get { return _code; } }
            public String Name { get { return _name; } }
            public String Alias { get { return _alias; } }
            public static 客室利用区分 CodeOf(Object code) {
                if (code == null) { return null; } if (code is 客室利用区分) { return (客室利用区分)code; }
                return _codeValueMap.get(code.ToString().ToLower());
            }
            public static 客室利用区分[] Values { get {
                客室利用区分[] values = new 客室利用区分[_codeValueMap.size()];
                int index = 0;
                foreach (客室利用区分 flg in _codeValueMap.values()) {
                    values[index] = flg;
                    ++index;
                }
                return values;
            }}
            public override int GetHashCode() { return 7 + _code.GetHashCode(); }
            public override bool Equals(Object obj) {
                if (!(obj is 客室利用区分)) { return false; }
                客室利用区分 cls = (客室利用区分)obj;
                return _code.ToLower().Equals(cls.Code.ToLower());
            }
            public override String ToString() { return this.Code; }
        }

    }

}
