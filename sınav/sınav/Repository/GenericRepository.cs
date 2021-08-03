using sınav.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sınav.Repository
{
    public class GenericRepository<T> where T: class, new() { 

    Context c = new Context();
    public List<T> Tlist()
    {
        return c.Set<T>().ToList();

    }

    public void TAdd(T a)
    {
        c.Set<T>().Add(a);
        c.SaveChanges();

    }
    public void  TDelete(T a)
    {
        c.Set<T>().Remove(a);
        c.SaveChanges();

    }
    public void TUpdate(T a)
    {
        c.Set<T>().Update(a);
        c.SaveChanges();

    }
    public T GetT(int id)
    {
        return c.Set<T>().Find(id);
    }
}}
