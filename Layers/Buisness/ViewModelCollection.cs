using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Emash.GeoPat.Layers.Data;
using System.Data.Entity;
using System.Reflection;
namespace Emash.GeoPat.Layers.Buisness
{
    public class ViewModelCollection<M,VM> : ObservableCollection<VM> 
    where  M : ModelBase
    where VM : ViewModelBase<M>
    {
        public DbContext DbContext { get;  set; }
        private DbSet<M> DbSet { get;  set; }
        private ConstructorInfo ViewModelConstructorInfo { get;  set; }
        public ViewModelCollection()
        {           
            this.ViewModelConstructorInfo = typeof(VM).GetConstructor(new Type[] {typeof (M) });
        }

        public void Load(DbContext dbContext)
        {
            this.DbContext = dbContext;
            this.DbSet = this.DbContext.Set<M>();
            this.Clear();
            IQueryable<M> queryable = DbSet.AsQueryable<M>();
            foreach (M model in queryable)
            {
                VM viewModel = this.ViewModelConstructorInfo.Invoke(new Object[] { model }) as VM;
                this.Add(viewModel);
            }
            Console.WriteLine("Load " + this.Count + " item " + typeof(M).Name);
        }
    }
}
