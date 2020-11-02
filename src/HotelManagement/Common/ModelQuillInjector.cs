using Seasar.Quill;

namespace HotelManagement.Common
{
    public class ModelQuillInjector<T>
    {
        readonly public T Model;

        public ModelQuillInjector()
        {
            QuillInjector.GetInstance().Inject(this);
        }
    }
}
