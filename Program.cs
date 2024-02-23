using courses;

CourseManager courseManager = new CourseManager();
Course [] courses1 = courseManager.GetAll();
for (int i = 0; i < courses1.Length; i++)
{
    System.Console.WriteLine(courses1[i].Name + "/" + courses1[i].Description);
}


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdnetity = "412343453";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "1234";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdnetity = "412343455663";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "1234334";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "23411";
customer3.TaxNumber = "264354456";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abfjsh";
customer4.CustomerNumber = "93657";
customer4.TaxNumber = "9939204982";

BaseCustomer [] customers = {customer1, customer2, customer3, customer4};
foreach (BaseCustomer item in customers)
{
    System.Console.WriteLine("{0}, {1}, {2}", item.CustomerNumber, item.Id, customer3.TaxNumber);
}
