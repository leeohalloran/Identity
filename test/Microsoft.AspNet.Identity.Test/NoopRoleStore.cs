using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Identity.Test
{
    public class NoopRoleStore : IRoleStore<TestRole>
    {
        public Task Create(TestRole user, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult(0);
        }

        public Task Update(TestRole user, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult(0);
        }

        public Task<string> GetRoleName(TestRole role, CancellationToken cancellationToken = new CancellationToken())
        {
            return Task.FromResult<string>(null);
        }

        public Task<TestRole> FindById(string roleId, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult<TestRole>(null);
        }

        public Task<TestRole> FindByName(string userName, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult<TestRole>(null);
        }

        public void Dispose()
        {
        }

        public Task Delete(TestRole user, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult(0);
        }

        public Task<string> GetRoleId(TestRole role, CancellationToken cancellationToken = new CancellationToken())
        {
            return Task.FromResult<string>(null);
        }
    }
}