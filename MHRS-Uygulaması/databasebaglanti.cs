using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ailehekimidonemproje
{
    public class databasebaglanti
    {
        public NpgsqlConnection conn()
        {
            NpgsqlConnection baglan = new NpgsqlConnection("Server=localhost;Port=5432;Database=AILEHEKIMIPROJE;User Id=postgres;Password=1234");
            baglan.Open();
            return baglan;
        }
    }
}