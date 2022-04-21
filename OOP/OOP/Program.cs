using OOP;

var customer = new Customer();
customer.Id = 1;
customer.Name = "Hamid";
Console.WriteLine(customer.Id);
Console.WriteLine(customer.Name);

var order = new Order();
customer.Orders.Add(order);
