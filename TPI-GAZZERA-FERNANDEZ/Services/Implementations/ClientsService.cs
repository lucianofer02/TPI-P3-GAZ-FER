Using System;

namespace TPI-P3-GAZ-FER.Services.Implementations
{
    public class ClientsService : IClientsService
{
    private readonly ClientContext _context;

    public ClientsService(ClientsService context)
    {
        _context = context;
    }
    public List<User> GetClients()
    {
        return _context.Client.Where(p => p.UserType == "Client").ToList();
    }
}
}
