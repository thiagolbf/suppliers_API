using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace DevIO.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {

        protected readonly MeuDbContext Db;
        protected readonly DbSet<TEntity> Dbset;

        protected Repository(MeuDbContext db)
        {
            Db = db;
            Dbset = db.Set<TEntity>();
        }


        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await Dbset.FindAsync(id);
        }
        public virtual async Task<List<TEntity>> ObterTodos(Guid id)
        {
            return await Dbset.ToListAsync();
        }
        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await Dbset.AsNoTracking().Where(predicate).ToListAsync();
        }
        public virtual async Task Adicionar(TEntity entity)
        {
            Dbset.Add(entity);
            await SaveChanges();
        }
        public virtual async Task Atualizar(TEntity entity)
        {
            Dbset.Update(entity);
            await SaveChanges();
        }                           
        public virtual async Task Remover(Guid id)
        {
            Dbset.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
