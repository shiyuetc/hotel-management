using HotelManagement.Common;
using HotelManagement.Common.Functions;
using NUnit.Framework;

namespace UnitTest
{
    public class ���ʃ`�F�b�N����Test
    {
        [Test]
        public void ���͉\���t_�ŏ��l()
        {
            var res = ���ʃ`�F�b�N����.Is���͉\���t(Constants.�V�X�e�����t.�ŏ��l);
            Assert.IsTrue(res);
        }

        [Test]
        public void ���͉\���t_�ő�l()
        {
            var res = ���ʃ`�F�b�N����.Is���͉\���t(Constants.�V�X�e�����t.�ő�l);
            Assert.IsTrue(res);
        }

        [Test]
        public void ���͉\���t_�ŏ��l����()
        {
            var res = ���ʃ`�F�b�N����.Is���͉\���t(Constants.�V�X�e�����t.�ŏ��l.AddDays(-1));
            Assert.IsFalse(res);
        }

        [Test]
        public void ���͉\���t_�ő�l����()
        {
            var res = ���ʃ`�F�b�N����.Is���͉\���t(Constants.�V�X�e�����t.�ő�l.AddDays(1));
            Assert.IsFalse(res);
        }
    }
}