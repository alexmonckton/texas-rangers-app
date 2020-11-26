using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TexasRangersApp.Models;
using SQLite;

namespace TexasRangersApp.Data
{
    public class ReservationDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public ReservationDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Reservation>().Wait();
        }

        public Task<List<Reservation>> GetNotesAsync()
        {
            return _database.Table<Reservation>().ToListAsync();
        }

        public Task<Reservation> GetNoteAsync(int id)
        {
            return _database.Table<Reservation>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Reservation reservation)
        {
            if (reservation.ID != 0)
            {
                return _database.UpdateAsync(reservation);
            }
            else
            {
                return _database.InsertAsync(reservation);
            }
        }

        public Task<int> DeleteNoteAsync(Reservation reservation)
        {
            return _database.DeleteAsync(reservation);
        }
    }
}
