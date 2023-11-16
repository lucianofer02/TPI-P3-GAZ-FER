using TPI_GAZZERA_FERNANDEZ.Entities;

namespace TPI_GAZZERA_FERNANDEZ
{
    public class ClientsDataStore
    {
        public List<Client> Clients {  get; set; }
        public static ClientsDataStore Current{ get;} = new ClientsDataStore();

        public ClientsDataStore() 
        {
            Clients = new List<Client>()
            {
                new Client()
                {
                    Id = 1,
                    Name = "Luciano",
                    LastName = "Fernández",
                    Email = "luciano@gmail.com",
                    Password = "password",
                    Adress = "Pje. 518 6353"
                },
                new Client()
                {
                    Id = 2,
                    Name = "Franco",
                    LastName = "Cambiaso",
                    Email = "franco@gmail.com",
                    Password = "password",
                    Adress = "Pje. Noruega 3295"
                }
            };
        }

        public Client? GetId(int id)
        {
            return Clients.SingleOrDefault(c => c.Id == id);
        }
    }

}
