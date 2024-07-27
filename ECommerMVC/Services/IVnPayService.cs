using ECommerMVC.ViewModels;

namespace ECommerMVC.Services
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(HttpContext context, VnPaymentRequestModel model);
        VnPaymentRequestModel PaymentExecute(IQueryCollection collections);
    }
}
