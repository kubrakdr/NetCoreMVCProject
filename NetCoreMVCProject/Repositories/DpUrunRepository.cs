using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using NetCoreMVCProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCProject.Repositories
{
    public class DpUrunRepository
    { 
        public List<Urun> GetirHepsi()
        {
            using var connection = new SqlConnection("server=.\\SQLEXPRESS; database=YoutubeNetCore; integrated security=true");
           
            return connection.GetAll<Urun>().ToList();
        }
    }
}
