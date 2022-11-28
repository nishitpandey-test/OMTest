using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OmTest
{
    public partial class _Default : Page
    {
        string sConnectionString = @"Server=tcp:sqlauthsqlserver.database.windows.net,1433;Authentication=Active Directory Password;Database=repuverpv;UID=niitpaey@volvogroup.onmicrosoft.com;PWD=Janki@1954;";

        //string sConnectionString = @"Server=tcp:100274-q-use2-sql-01.database.windows.net,1433;Initial Catalog=AvaliacaoDesempenho;Persist Security Info=False;User ID=AZU-PEDAVD@volvogroup.onmicrosoft.com;Password=@!pedavdazu22;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Authentication=""Active Directory Password"";";

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TestTable", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            con.Close();
        }
    }
}