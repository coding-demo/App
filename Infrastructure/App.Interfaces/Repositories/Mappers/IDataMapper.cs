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
        T MapToDTO(DataTable table);
        List<T> MapToDTOList(DataTable table); //where T : new();
        DataTable MapDTOListToTable(List<T> list);//;where T : new();
    }
}
