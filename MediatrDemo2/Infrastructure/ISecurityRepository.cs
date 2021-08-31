using System.Threading.Tasks;
using MediatrDemo2.Models;

namespace MediatrDemo2.Infrastructure
{
    public interface ISecurityRepository
    {
        Task<Security> Add(Security security);
        Task<Security> GetById(string id);
    }
}