using Seasar.Quill;

namespace HotelManagement.Common
{
    /// <summary>
    /// Modelクラスを初期化するクラス
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ModelQuillInjector<T>
    {
        readonly public T Model;

        /// <summary>
        /// ModelQuillInjectorクラスを初期化します。
        /// </summary>
        public ModelQuillInjector()
        {
            QuillInjector.GetInstance().Inject(this);
        }
    }
}
