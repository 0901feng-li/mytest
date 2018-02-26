using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (ClassLibrary1.InspectionWHEntities1 db = new InspectionWHEntities1())
            {
                //var trans = db.Database.BeginTransaction();
                try
                {
                    WorkOrderBaseInfo a = new WorkOrderBaseInfo();
                    a.InfoID = Guid.NewGuid();
                    a.WorkId = "test33333333-123";
                    WorkOrderBaseInfo b = new WorkOrderBaseInfo();
                    b.InfoID = Guid.NewGuid();
                    b.WorkId = "test4444444-123222222222222222222222222222222222222222222222222222222222222222222222222222222222222222";
                    db.WorkOrderBaseInfo.Add(a);
                    db.WorkOrderBaseInfo.Add(b);
                    db.SaveChanges();
                  //  trans.Commit();
                    Response.Write(a.WorkId + b.WorkId);
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                   // trans.Rollback();
                }
                
            }
               
        }
    }
}