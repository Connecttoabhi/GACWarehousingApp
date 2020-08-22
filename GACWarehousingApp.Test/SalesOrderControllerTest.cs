using GACWarehousingApp.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace GACWarehousingApp.Test
{
    
    public class SalesOrderControllerTest
    {
        [Fact]
        public void Add_TestClassObjectPassed_ProperMethodCalled()
        {
           var testObject = new SalesOrder();
            var context = new Mock<AppDbContext>();
            var dbSetMock = new Mock<DbSet<SalesOrder>>();
            context.Setup(x => x.Set<SalesOrder>()).Returns(dbSetMock.Object);
            dbSetMock.Setup(x => x.Add(It.IsAny<SalesOrder>()));
            context.Verify(x => x.Set<SalesOrder>());
            dbSetMock.Verify(x => x.Add(It.Is<SalesOrder>(y => y == testObject)));
            
        }
    }
}
