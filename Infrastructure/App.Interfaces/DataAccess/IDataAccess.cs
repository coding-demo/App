using System.Collections.Generic;
using System.Data;

namespace App.Interfaces.DataAccess
{

    public interface IDataBaseAccess  
    {
        List<DataRow> GetRecords();

        DataRow GetRowById(int id);

        DataRow InsertRecord(DataRow record);

        DataRow UpdateRecord(DataRow record);

        void DeleteRecord(int id);
    }
}
