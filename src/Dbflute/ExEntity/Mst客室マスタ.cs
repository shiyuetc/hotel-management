
namespace Dbflute.ExEntity {

    partial class Mst客室マスタ {

        /// <summary>
        /// 階層
        /// </summary>
        public int 階層
        {
            get
            {
                return int.Parse(this.客室番号.Substring(0, 1));
            }
        }
    }
}
