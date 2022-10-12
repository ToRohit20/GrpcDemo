// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcServer;
using GrpcServer.Protos;
using System;
using System.Threading.Tasks;

public class Program
{
    static async Task Main(string[] args)
    {
        //var input = new HelloRequest { Name = "Tim" };
        //var channel = GrpcChannel.ForAddress("http://localhost:5029");
        //var client = new Greeter.GreeterClient(channel);
        //var reply = await client.SayHelloAsync(input);
        //Console.WriteLine(reply.Message);

        //var channel = GrpcChannel.ForAddress("http://localhost:5029");
        //var customerClient = new Customer.CustomerClient(channel);
        //var clientRequested = new CustomerLookupModel() { Userid = 1 };
        //var customer = await customerClient.GetCustomerInfoAsync(clientRequested);



        var channel = GrpcChannel.ForAddress("http://localhost:5029");
        var client = new Customer.CustomerClient(channel);
        var customerRequest = new CustomerLookupModel() { Userid = 2 };
        var customer = await client.GetCustomerInfoAsync(customerRequest);
        Console.WriteLine(customer);

        Console.ReadKey();
    }
}