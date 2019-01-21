using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVC.Controllers {
    public class HomeController {
        public string Index() {
            return "Hello from index in homecontroller";
        }
        public string About() {
            return "This is the about page";
        }
        public string Contact() {
            return "This is the contact page";
        }
    }
}
