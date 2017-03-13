using System.Collections.Generic;

namespace App.Interfaces.DataAccess
{

    public interface IDataBaseAccess  
    {
        List<object> GetRecords();

        object GetRowById(int id);

        object InsertRecord(object record);

    }
}
