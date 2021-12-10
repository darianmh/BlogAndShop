using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.ViewModel.Admin;
using BlogAndShop.Data.ViewModel.PaymentInfo;
using BlogAndShop.Data.ViewModel.User;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.User;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.PaymentInfo
{
    public class PaymentService : MainService<Payment>, IPaymentService
    {
        #region Fields

        private readonly IAddressService _addressService;
        private readonly IPaymentItemService _paymentItemService;

        #endregion
        #region Methods

        public async Task<List<PaymentModel>> GetUserPaymentsModel(int userId)
        {
            var userPayments = await GetUserPayments(userId);
            var result = new List<PaymentModel>();
            foreach (var userPayment in userPayments)
            {
                var tempModel = await GetPaymentModel(userPayment);
                result.Add(tempModel);
            }

            return result;
        }



        public async Task<List<Payment>> GetUserPayments(int userId)
        {
            return await Queryable.Where(x => x.OwnerId == userId).ToListAsync();
        }

        public async Task<List<NewNotificationModel>> GetNewOrders()
        {
            var allNew = await Queryable.Where(x => x.Status == PaymentStatus.Waiting).ToListAsync();
            return allNew.Select(x => new NewNotificationModel
            {
                Id = x.Id,
                Date = x.CreateDateTime,
                NewNotificationType = NewNotificationType.Product,
                Text = x.Text
            }).ToList();
        }

        #endregion
        #region Utilities

        private async Task<PaymentModel> GetPaymentModel(Payment userPayment)
        {
            var model = userPayment.ToModel();
            model.Address = await GetPaymentAddress(userPayment);
            model.PaymentItems = await GetPaymentItems(userPayment);
            return model;
        }

        private async Task<List<PaymentItemModel>> GetPaymentItems(Payment userPayment)
        {
            var items = await _paymentItemService.GetPaymentItemsModel(userPayment.Id);
            return items;
        }

        private async Task<AddressModel> GetPaymentAddress(Payment userPayment)
        {
            var address = await _addressService.GetByIdAsync(userPayment.AddressId);
            return address == null ? new AddressModel() : address.ToModel();
        }

        #endregion
        #region Ctor
        public PaymentService(ApplicationDbContext db, IAddressService addressService, IPaymentItemService paymentItemService) : base(db)
        {
            _addressService = addressService;
            _paymentItemService = paymentItemService;
        }
        #endregion

    }
}