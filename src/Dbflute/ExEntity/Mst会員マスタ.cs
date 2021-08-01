
namespace Dbflute.ExEntity {

    partial class Mst会員マスタ {

        /// <summary>
        /// 氏名
        /// </summary>
        public string 氏名
        {
            get
            {
                return $"{this.名字} {this.名前}";
            }
        }
    }
}
