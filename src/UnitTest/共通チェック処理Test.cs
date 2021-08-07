using HotelManagement.Common;
using HotelManagement.Common.Functions;
using NUnit.Framework;

namespace UnitTest
{
    public class 共通チェック処理Test
    {
        [Test]
        public void 入力可能日付_最小値()
        {
            var res = 共通チェック処理.Is入力可能日付(Constants.システム日付.最小値);
            Assert.IsTrue(res);
        }

        [Test]
        public void 入力可能日付_最大値()
        {
            var res = 共通チェック処理.Is入力可能日付(Constants.システム日付.最大値);
            Assert.IsTrue(res);
        }

        [Test]
        public void 入力可能日付_最小値超過()
        {
            var res = 共通チェック処理.Is入力可能日付(Constants.システム日付.最小値.AddDays(-1));
            Assert.IsFalse(res);
        }

        [Test]
        public void 入力可能日付_最大値超過()
        {
            var res = 共通チェック処理.Is入力可能日付(Constants.システム日付.最大値.AddDays(1));
            Assert.IsFalse(res);
        }
    }
}