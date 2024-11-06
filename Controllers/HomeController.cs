using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instâncias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Jonathan C. A. Rocha", "088.395.930-55", "jonathan.rocha.ti@gmail.com", "Madruga");
        Cliente cliente2 = new Cliente(02, "William Henry Gates III", "556.153.590-05", "william@gmail.com", "Diguiua");
        Cliente cliente3 = new Cliente(03, "Soame Dohia Faplu", "461.053.860-10", "soame@gmail.com", "Love");
        Cliente cliente4 = new Cliente(04, "Cakus Zeys Civil", "524.049.130-50", "kacus@gmail.com", "quasenada");
        Cliente cliente5 = new Cliente(05, "Tithalion Gapudor Xuindîr", "406.052.120-58", "gapudor@gmail.com", "elfo");
        
        //Lista clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        //Instâncias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(1, "Pet Lovers","48.992.310/0001-82", "pet_lovers@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(2, "Bicho Mania","75.418.654/0001-36", "bicho_manias@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(3, "Mundo Animal","11.744.985/0001-09", "mundo_animal@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(4, "Patas e Pelos","27.061.328/0001-53", "patas_pelos@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(5, "Auau Miau","89.537.091/0001-17", "auau_miau@gmail.com");

        //Lista fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

	    return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
