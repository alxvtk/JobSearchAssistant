using JsaCqrsApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync();
    }
}