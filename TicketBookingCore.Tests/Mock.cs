

namespace TicketBookingCore.Tests
{
    internal class Mock<T>
    {
        public Mock()
        {
        }

        public ITicketBookingRepository Object { get; internal set; }

        internal object Setup(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}