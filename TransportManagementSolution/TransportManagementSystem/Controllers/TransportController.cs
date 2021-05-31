using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TransportManagementSystem.Models;

namespace TransportManagementSystem.Controllers
{
    public class TransportController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Login login)
        {
            if (login.Username == "Admin" && login.Password == "KadhaipomaAdmin")
            {
                return RedirectToAction("Home");
            }
            else
            {
                ViewData["message"] = "Incorrect Username or Password";
                return View();
            }
        }
        public IActionResult Home()
        {
            return View();
        }
        public async Task<ActionResult> Vehicles()
        {
            string Baseurl = "http://localhost:45302/";
            var VehicleInfo = new List<Vehicle>();
            //HttpClient cl = new HttpClient();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Vehicles");
                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   

                    var VehicleResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    VehicleInfo = JsonConvert.DeserializeObject<List<Vehicle>>(VehicleResponse);

                }
                //returning the employee list to view  
                return View(VehicleInfo);
            }
        }
        public async Task<ActionResult> Employees()
        {
            string Baseurl = "http://localhost:45302/";
            var EmployeeInfo = new List<Employee>();
            //HttpClient cl = new HttpClient();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Employees");
                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   

                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    EmployeeInfo = JsonConvert.DeserializeObject<List<Employee>>(EmpResponse);

                }
                //returning the employee list to view  
                return View(EmployeeInfo);
            }
        }
        public async Task<ActionResult> Routes()
        {
            string Baseurl = "http://localhost:45302/";
            var RouteInfo = new List<Route>();
            //HttpClient cl = new HttpClient();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Routes");
                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   

                    var RouteResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    RouteInfo = JsonConvert.DeserializeObject<List<Route>>(RouteResponse);

                }
                //returning the employee list to view  
                return View(RouteInfo);
            }
        }
        public async Task<ActionResult> AllocationList()
        {
            string Baseurl = "http://localhost:45302/";
            var AllocateInfo = new List<Allocation>();
            //HttpClient cl = new HttpClient();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Allocations");
                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   

                    var RouteResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    AllocateInfo = JsonConvert.DeserializeObject<List<Allocation>>(RouteResponse);

                }
                //returning the employee list to view  
                return View(AllocateInfo);
            }
        }
        [HttpGet]
        public IActionResult AddVehicle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddVehicle(Vehicle vehicle)
        {

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(vehicle), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:45302/api/Vehicles", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<Vehicle>(apiResponse);
                }
            }
            return RedirectToAction("Vehicles");

        }
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:45302/api/Employees", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<Employee>(apiResponse);
                }
            }
            return RedirectToAction("Employees");
        }
        public IActionResult AddRoute()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRoute(Route route)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(route), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:45302/api/Routes", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<Route>(apiResponse);
                }
            }
            return RedirectToAction("Routes");
        }

        public async Task<IActionResult> EditVehicle(string VehicleNumber)
        {
            Vehicle vehicle = new Vehicle();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:45302/api/Vehicles/" + VehicleNumber))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    vehicle = JsonConvert.DeserializeObject<Vehicle>(apiResponse);
                }
            }
            return View(vehicle);
        }
        [HttpPost]
        public async Task<IActionResult> EditVehicle(Vehicle vehicle)
        {
            Vehicle v = new Vehicle();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(vehicle), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("http://localhost:45302/api/Vehicles/" + vehicle.VehicleNumber, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    v = JsonConvert.DeserializeObject<Vehicle>(apiResponse);
                }
            }
            return RedirectToAction("Vehicles");
        }
        public async Task<IActionResult> EditEmployee(int id)
        {
            Employee employee = new Employee();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:45302/api/Employees/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    employee = JsonConvert.DeserializeObject<Employee>(apiResponse);
                }
            }
            return View(employee);
        }
        [HttpPost]
        public async Task<IActionResult> EditEmployee(Employee employee)
        {
            Employee e = new Employee();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("http://localhost:45302/api/Employees/" + employee.EmployeeId, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    e = JsonConvert.DeserializeObject<Employee>(apiResponse);
                }
            }
            return RedirectToAction("Employees");
        }
        public async Task<IActionResult> EditRoute(int RouteNumber)
        {
            Route route = new Route();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:45302/api/Routes/" + RouteNumber))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    route = JsonConvert.DeserializeObject<Route>(apiResponse);
                }
            }
            return View(route);
        }
        [HttpPost]
        public async Task<IActionResult> EditRoute(Route route)
        {
            Route r = new Route();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(route), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("http://localhost:45302/api/Vehicles/" + route.RouteNumber, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    r = JsonConvert.DeserializeObject<Route>(apiResponse);
                }
            }
            return RedirectToAction("Routes");
        }
        public async Task<IActionResult> DeleteVehicle(string VehicleNumber)
        {
            TempData["id"] = VehicleNumber;
            Vehicle vehicle = new Vehicle();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:45302/api/Vehicles/" + VehicleNumber))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    vehicle = JsonConvert.DeserializeObject<Vehicle>(apiResponse);
                   // TempData["id"] = vehicle.VehicleNumber;
                }
            }
            return View(vehicle);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteVehicle(Vehicle v)
        {
            // string id =Convert.ToString( TempData.Peek("id"));
            string id =Convert.ToString( TempData["id"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:45302/api/Vehicles/" + id))
                {
                
                    string apiResponse = await response.Content.ReadAsStringAsync();

                }
            }
            return RedirectToAction("Vehicles");
        }
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            Employee employee = new Employee();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:45302/api/Employees/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    employee = JsonConvert.DeserializeObject<Employee>(apiResponse);
                }
            }
            return View(employee);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteEmployee(Employee employee)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:45302/api/Employees/" + employee.EmployeeId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("Employees");
        }
        public async Task<IActionResult> DeleteRoute(int RouteNumber)
        {
            Route route = new Route();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:45302/api/Routes/" + RouteNumber))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    route = JsonConvert.DeserializeObject<Route>(apiResponse);
                }
            }
            return View(route);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteRoute(Route route)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:45302/api/Routes/" + route.RouteNumber))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("Routes");
        }
        public async Task<IActionResult> DeleteAllocation(int id)
        {
            Allocation allocation = new Allocation();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:45302/api/Allocations/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    allocation = JsonConvert.DeserializeObject<Allocation>(apiResponse);
                }
            }
            return View(allocation);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteAllocation(Allocation allocation)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:45302/api/Allocations/" + allocation.EmployeeId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("AllocationList");
        }
        public IActionResult Allocate()
        {
            return View();
        }
        public async Task<IActionResult> GetRoutes(string Location)
        {
            TempData["Location"] = Location;
            List<Route> route = new List<Route>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:45302/api/Allocations/" + Location))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    route = JsonConvert.DeserializeObject<List<Route>>(apiResponse);
                }
            }
            return View(route);
        }
        public async Task<IActionResult> AllocateEmployee(int RouteNumber)
        {
            Route route = new Route();
            //Allocation allocation = new Allocation();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:45302/api/Routes/" + RouteNumber))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    route = JsonConvert.DeserializeObject<Route>(apiResponse);
                }
            }
            TempData["RouteNumber"] = route.RouteNumber;
            TempData["VehicleNumber"] =route.VehicleNumber;
            var vNum = route.VehicleNumber;
            return RedirectToAction("CheckSeat", new { VehicleNumber = vNum });
           // return View(allocation);
        }
        [HttpGet]
        public async Task<IActionResult> CheckSeat(string VehicleNumber)
        {
            Vehicle vehicle = new Vehicle();
            Allocation allocation = new Allocation();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:45302/api/Vehicles/" + VehicleNumber))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    vehicle = JsonConvert.DeserializeObject<Vehicle>(apiResponse);
                }
            }
            TempData["AvailableSeats"] = vehicle.AvailableSeats;
            if (vehicle.AvailableSeats != 0)
            {
                return View();
            }
            else
            {
                return RedirectToAction("NotAvailable");
            }           
        }
        public IActionResult NotAvailable()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AllocateEmployee(Allocation allocation)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(allocation), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:45302/api/Allocations", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<Allocation>(apiResponse);
                }
            }
            return RedirectToAction("AllocationList");
        }
    }
}

    


