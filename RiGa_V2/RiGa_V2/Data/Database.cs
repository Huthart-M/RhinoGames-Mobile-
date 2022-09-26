using System;
using System.Collections.Generic;
using System.Text;
//ADD NS
using System.Threading.Tasks;
using SQLite;
using RiGa_V2.Data;
using RiGa_V2.Model;

namespace RiGa_V2.Data
{
    public class Database
    {
        /// <summary>
        /// Synchronous/asynchronous APIs are application programming interfaces that return data for requests either
        ///immediately or at a later time, 
        /// respectively. The synchronous and asynchronous nature of an API is a function of the time frame from
        /// the request to the return of data.
        /// </summary>
        readonly SQLiteAsyncConnection database;

        public Database(string Path)
        {
            database = new SQLiteAsyncConnection(Path);
            database.CreateTableAsync<User>().Wait();
        }

        public Task<int> Insert(User item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<List<User>> GetAllItems()
        {
            return database.Table<User>().ToListAsync();
        }
    }
}

