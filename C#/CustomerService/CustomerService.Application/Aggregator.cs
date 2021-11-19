using CustomerService.Application.Services;

namespace CustomerService.Application
{
    public class Aggregator
    {
        //IoC?  https://www.c-sharpcorner.com/UploadFile/cda5ba/dependency-injection-di-and-inversion-of-control-ioc/

        public LookupOrderService LookupOrderService = new LookupOrderService(); //Something with a Singleton Design Pattern.

    }
}