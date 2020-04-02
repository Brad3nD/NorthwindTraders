using Northwind.Application.Customers.Commands.UpdateCustomer;
using System.Threading;
using Northwind.Application.UnitTests.Common;
using Xunit;

namespace Northwind.Application.UnitTests.Customers.Commands.CreateCustomer
{
    public class UpdateCustomerCommandTests : CommandTestBase
    {
        [Fact]
        public void Handle_GivenValidRequest_ShouldRaiseCustomerUpdatedNotification()
        {
            var sut = new UpdateCustomerCommand.Handler(_context);
            var validId = "QAZQ1";

            var result = sut.Handle(new UpdateCustomerCommand { Id = validId }, CancellationToken.None);
            var customer = _context.Customers.FindAsync(validId);
            var newId = "L10S1";

            Assert.Equal(validId, newId);
        }
    }
}
