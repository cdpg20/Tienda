using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    public class Client
    {
        Dictionary<string, int> ClientList = new Dictionary<string, int>();
        string client;
        int nit;


        // Un cliente no debe manejar su propio lista de clientes
        // Cliente (nombre, apellido, nitOCi)
        public Client(string client, int nit)
        {
            this.client = client;
            this.nit = nit;
        }

        public void AddClient(string Name, int Nit)
        {
            ClientList.Add(Name, Nit);
        }

        public void DeleteClient(string Name)
        {
            ClientList.Remove(Name);
        }

        public void PrintClient()
        {
            foreach (KeyValuePair<string, int> pair in ClientList)
                Console.WriteLine("The name of the client is: " + pair.Key + "The NIT is:" + pair.Value);
        }

        public void DeleteAllClients()
        {
            ClientList.Clear();
        }
    }
}
