using System.Collections.Generic;
using System.Data;

namespace App.Interfaces.DataAccess
{

    public interface IDataBaseAccess  
    {
        List<DataRow> GetRecords();

        DataRow GetRowById(int id);

        void InsertRecord(DataRow record);

        void UpdateRecord(DataRow record);

        void DeleteRecord(int id);
    }
}
