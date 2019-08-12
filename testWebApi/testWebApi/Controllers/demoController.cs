using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testWebApi.Controllers
{
    public class demoController : ApiController
    {
         public string Get() {  
            return "Welcome To Web API";  
        }  
        public List < string > Get(int Id) {  
            return new List < string > {  
                "ANKIT PANDEY",
                "RAVI PRATAP",
                "RUDRA PRATAP",
                "GOPAL SINGH"








            };  
        }  
    }  
}   
 
