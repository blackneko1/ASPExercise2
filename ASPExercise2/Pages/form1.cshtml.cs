using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPExercise2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPExercise2.Pages
{
    public class form1Model : PageModel
    {
        [BindProperty]
        public RegisterClass Users { get; set; }

        public void OnGet()
        {
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Redirect("/Index");
            //string firstname = Request.Form["txtFN"];
            //string lastname = Request.Form["txtLN"];
            //string username = Request.Form["txtUN"];
            //string password = Request.Form["txtPW"];
            //string address = Request.Form["txtAD"];
            //string contactnumber = Request.Form["txtCN"];
            //string emailaddress = Request.Form["txtEA"];
            //HttpResponseWritingExtensions.WriteAsync(this.Response, "Hello Welcome to Pesbok "+Users.firstname+" "+Users.lastname+" Your Username is "+
            // Users.username+" And Your Password is "+Users.password+" Your Address is "+Users.address+
            // " Your Contact Number is " + Users.contactnumber+" Your Email Address is "+Users.emailaddress+" Please remember your data Thank you.");
        }
    }
}
