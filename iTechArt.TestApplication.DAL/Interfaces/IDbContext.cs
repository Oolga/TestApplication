using iTechArt.TestApplication.DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTechArt.TestApplication.DAL.Interfaces
{
	public interface IDbContext
	{
		IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
		int SaveChanges();
	}
}
