using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IGenericRepository
    {
        // We will use the 'Generic Repository Pattern' to built up this application.
        // So we need two folders: 'IRepository' and 'Repository'. The first is for
        // creating the generic interface, the second for the related generic class that will
        // inherit from the interface. 

        // This interface will take on any class and will implement the basic CRUD-functions into
        // the 'Repository' classes that inherit from this interface.
        public interface IGenericRepository<T> where T : class
        {
            //****************************************************************************************

            // 1. READ or SELECT  ('READ ALL' and 'READ ONE')

            // When dealing with async programming we have to use tasks. In this first method
            // 'GetAll' we are returning a task<IList> of the generic class and adding three
            // optional parameters. This action will get a list of ALL instances!
            Task<IList<T>> GetAll(

                Expression<Func<T, bool>> expression = null,
                string checkInDate = null,
                string checkOutDate = null,//todo: volgorde ter preventie van error.
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                List<string> includes = null,
                List<string> includes2 = null,
                List<string> includes3 = null,
                List<string> includes4 = null
            );

            // Then we will have a follow up function 'Get', where only the second parameter
            // is optional. This action will only get ONE instance!
            Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null,
                List<string> includes2 = null,
                List<string> includes3 = null,
                List<string> includes4 = null,
                string checkInDate = null, 
                string checkOutDate = null
            );

            //****************************************************************************************

            // 2. CREATE ('CREATE ONE')

            // With this 'Insert'-function we will be able to insert one entity to our database.
            Task Create(T entity);
            //****************************************************************************************

            // 3. DELETE ('DELETE ONE' and 'DELETE RANGE')

            // With this 'Delete'-function we will be able to delete one entity to our database.
            Task Delete(int id);

            // The 'DeleteRange'-function enables us to delete multiple instances to our database.
            void DeleteRange(IEnumerable<T> entities);

            //****************************************************************************************

            // 4. UPDATE

            // With the 'Update'-function we can change the values of a specific instance from our database.
            void Update(T entity);

            //****************************************************************************************
        }
    }
}
