using System;

namespace BigFormsApplication.Forms.DataSourceForGridView
{
    public class ClientDS   // Client Data Source voor een DataGrid
    {
        public int ClientId { get; set; } // Maken we hidden
        public int ClientNumber { get; set; }
        public string FirstName { get; set; }
        public string Birthdate { get; set; }
    }
}
