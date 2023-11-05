using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel_Specflow.ConstantHelpers
{
    public class FrameworkConstants
    {
        public static string WebUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        public static string GraphqlBaseUrl = "https://hasura.io/learn";
        public static string GraphqlEndpoint = "/graphql";
        public static string APIBaseUrl = "https://reqres.in/";

        public static string username = "Admin";
        public static string password = "admin123";

        public static string bearertoken = "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6Ik9FWTJSVGM1UlVOR05qSXhSRUV5TURJNFFUWXdNekZETWtReU1EQXdSVUV4UVVRM05EazFNQSJ9.eyJodHRwczovL2hhc3VyYS5pby9qd3QvY2xhaW1zIjp7IngtaGFzdXJhLWRlZmF1bHQtcm9sZSI6InVzZXIiLCJ4LWhhc3VyYS1hbGxvd2VkLXJvbGVzIjpbInVzZXIiXSwieC1oYXN1cmEtdXNlci1pZCI6ImF1dGgwfDY1MzY2NzMwNzIxMjcwOWI1NTQyZGQwYSJ9LCJuaWNrbmFtZSI6InJhdml1a29sdGUiLCJuYW1lIjoicmF2aXVrb2x0ZUBnbWFpbC5jb20iLCJwaWN0dXJlIjoiaHR0cHM6Ly9zLmdyYXZhdGFyLmNvbS9hdmF0YXIvNjBhNWM1MDNjYjgwOTlhY2IwOTEwM2U4YmE3ZjU3NWM_cz00ODAmcj1wZyZkPWh0dHBzJTNBJTJGJTJGY2RuLmF1dGgwLmNvbSUyRmF2YXRhcnMlMkZyYS5wbmciLCJ1cGRhdGVkX2F0IjoiMjAyMy0xMC0yOFQwNDoyMToyMS4xNjZaIiwiaXNzIjoiaHR0cHM6Ly9ncmFwaHFsLXR1dG9yaWFscy5hdXRoMC5jb20vIiwiYXVkIjoiUDM4cW5GbzFsRkFRSnJ6a3VuLS13RXpxbGpWTkdjV1ciLCJpYXQiOjE2OTg0NjY4ODIsImV4cCI6MTY5ODUwMjg4Miwic3ViIjoiYXV0aDB8NjUzNjY3MzA3MjEyNzA5YjU1NDJkZDBhIiwiYXRfaGFzaCI6IkgwWFgtd3FpZUxxVlQ1VUxtRzd6dEEiLCJzaWQiOiIwaXVwWUV0RnhKTGctUGpWMEd3aFVzODFzZ0FBcmZKYSIsIm5vbmNlIjoiTndlMlN2NnNnLm14QW51Xy1EMy1vMTc0NVU2VmVSMy4ifQ.KHYg3OtRDNBd5gNAC95c23Hz5qgEr106M_k4T4zUkSXWVI73ssj_GNMyBYy4HFqqktxJGTkMoaITG5Q_51oxajpq_1Pu1YpDKMrHntwyTVuQGSiex1348UfY0yIfDHJV8WWXKuuKIRF_PrYpT7IV9NqxV062iYN1cxjCEdv1KGS_o52p6x9J9uqG3SWRy-kut3BaC68BGB4WE7Tav7GH9C5QIv4mCCA_DOfXGFO3YhogdjTHUL4-r831HXax9zvoEtgWAsPTxFo7TCVX_vok7OKof-M7gzNxbd5DYnyID1ikD-bG1egEsQl4t_y-Qi4IGwfBFvCD_DGkHjtpep2LRw";


        public void SendText(IWebElement element, string text)
        {
            try
            {
                element.Clear();
                element.SendKeys(text);
            }
            catch (ElementClickInterceptedException)
            {
                
                element.Clear();
                element.SendKeys(text);
            }
        }

    }
}
