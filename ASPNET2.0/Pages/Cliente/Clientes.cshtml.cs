using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Data.SqlClient ;


namespace ASPNET2._0.Pages.Clients
{
    public class index : PageModel
    {
        private readonly ILogger<index> _logger;

        public index(ILogger<index> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            try {
                string connectionstring = "Data Source=DESKTOP-PD85F3K\\SQLEXPRESS;Initial Catalog=teste;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                using (Microsoft.Data.SqlClient.SqlConnection connection = new Microsoft.Data.SqlClient.SqlConnection(connectionstring))
                {
                    connection.Open();
                    String sql = "Select * from clients";
                    using (SqlCommand comando = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader ler = comando.ExecuteReader())
                        {

                        }
                    }
                }
                
            }
            catch (Exception) {
            }finally{

            }
        }
    }
}