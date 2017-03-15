using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Interfaces.Repositories.Mappers
{
    public interface IDataMapper<T> where T : new()
    {
        T MapToDto(DataTable table);
        List<T> MapToDtoList(DataTable table);  
        DataTable MapDtoListToTable(List<T> list); 
        DataRow MapDtoToRow(T type);
    }
}
