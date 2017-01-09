using System;
using System.Collections.Generic;
using System.Linq;

class ConstructorInjectionPattern
{

    public interface IService
    {
        void Serve();
    }

    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service Called");
            //To Do: Some Stuff
        }
    }

    public class Client
    {
        private IService _service;

        public Client(IService service)
        {
            this._service = service;
        }

        public void Start()
        {
            Console.WriteLine("Service Started");
            this._service.Serve();
            //To Do: Some Stuff
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new Service());
            client.Start();

            Console.ReadKey();
        }
    }

}
/*Output
 * 
 * 
*/

class PropertyInjectionPattern
{
    public interface IService
    {
        void Serve();
    }

    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service Called");
            //To Do: Some Stuff
        }
    }

    public class Client
    {
        private IService _service;

        public IService Service
        {
            set
            {
                this._service = value;
            }
        }

        public void Start()
        {
            Console.WriteLine("Service Started");
            this._service.Serve();
            //To Do: Some Stuff
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Service = new Service();
            client.Start();

            Console.ReadKey();
        }
    }
}


class MethodInjection
{
    public interface IService
    {
        void Serve();
    }

    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service Called");
            //To Do: Some Stuff
        }
    }

    public class Client
    {
        private IService _service;

        public void Start(IService service)
        {
            this._service = service;
            Console.WriteLine("Service Started");
            this._service.Serve();
            //To Do: Some Stuff
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Start(new Service());

            Console.ReadKey();
        }
    }
}