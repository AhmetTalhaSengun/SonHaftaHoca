using Microsoft.EntityFrameworkCore;
using SonHaftaHoca.Abstracts;
using SonHaftaHoca.Data;

namespace SonHaftaHoca.Repostories
{
    public abstract class BaseRepostory<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        protected readonly ToDoDbContext _context;

        protected readonly DbSet<TEntity> _table;

        public BaseRepostory(ToDoDbContext context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }

        public TEntity Bul(int id)
        {
            return _table.Find(id);


        }

        public void Ekle(TEntity entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Guncelle(TEntity entity)
        {
            _table.Update(entity);
            _context.SaveChanges();
        }

        public List<TEntity> Listele()
        {
            return _table.ToList();

        }

       

        public void Sil(int id)
        {
            _table.Remove(Bul(id));
            _context.SaveChanges();
        }
    }
}
