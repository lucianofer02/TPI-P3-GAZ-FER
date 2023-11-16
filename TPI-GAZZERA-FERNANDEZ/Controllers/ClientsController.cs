using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using TPI_GAZZERA_FERNANDEZ.Entities;

namespace TPI_GAZZERA_FERNANDEZ.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientsController : ControllerBase
    {
        private readonly ClientsDataStore _clientsDataStore;
        public ClientsController(ClientsDataStore clientsDataStore)
        {
            _clientsDataStore = clientsDataStore;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetClients()
        {
            return Ok(ClientsDataStore.Current.Clients);
        }

        [HttpGet]
        [Route("{id}")]

        public IActionResult GetId(int id)
        {
            Client? clients = _clientsDataStore.GetId(id);

            if (clients == null)
            {
                return NotFound();
            }
            return Ok(clients);
        }
    }
}
