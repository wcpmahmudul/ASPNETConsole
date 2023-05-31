// See https://aka.ms/new-console-template for more information
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Security.Principal;



//WindowsIdentity currentUser = WindowsIdentity.GetCurrent();
//if (currentUser != null)
//{
//    Console.WriteLine("User Name: " + currentUser.Name);
//    Console.WriteLine("Authenticated Type: " + currentUser.AuthenticationType);
//    Console.WriteLine("Is Authenticated: " + currentUser.IsAuthenticated);
//    Console.WriteLine("Is Guest: " + currentUser.IsGuest);
//    Console.WriteLine("Is System: " + currentUser.IsSystem);
//    Console.WriteLine("SID: " + currentUser.User?.Value);
//}
//else
//{
//    Console.WriteLine("Failed to retrieve current user information.");
//}

HttpContext context = new DefaultHttpContext();
if (context.User.Identity.IsAuthenticated)
{
    string userName = context.User.Identity.Name;
    string authenticationType = context.User.Identity.AuthenticationType;

    Console.WriteLine("User Name: " + userName);
    Console.WriteLine("Authentication Type: " + authenticationType);
}
else
{
    Console.WriteLine("User is not authenticated.");
}

Console.ReadLine();