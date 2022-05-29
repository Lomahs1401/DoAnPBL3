using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    class MyApplicationContext : ApplicationContext
    {
        private void onFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        }

        public MyApplicationContext()
        {
            //If WinForms exposed a global event that fires whenever a new Form is created,
            //we could use that event to register for the form's `FormClosed` event.
            //Without such a global event, we have to register each Form when it is created
            //This means that any forms created outside of the ApplicationContext will not prevent the 
            //application close.

            var forms = new List<Form>() {
            new FormLoading3(),
            //new FormIntro(),
            //new FormLogin()
        };
            foreach (var form in forms)
            {
                form.FormClosed += onFormClosed;
            }

            //to show all the forms on start
            //can be included in the previous foreach
            

            //to show only the first form on start
            forms[0].Show();
           
            

        }
    }
}
