using System.Threading.Tasks;
using Danea_Gabriel_Lab11.Models;
namespace Danea_Gabriel_Lab11.Danea_Gabriel_Lab11.Data
  

{
    public interface IRestService
    {
        public interface IRestService
        {
            Task<List<ShopList>> RefreshDataAsync();
            Task SaveShopListAsync(ShopList item, bool isNewItem);
            Task DeleteShopListAsync(int id);
        }

    }
}
