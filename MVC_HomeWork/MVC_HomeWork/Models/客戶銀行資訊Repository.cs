using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC_HomeWork.Models
{   
	public  class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
	{
        public 客戶銀行資訊 Find(int? id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }
        public async Task<List<客戶銀行資訊>> GetTaskAll()
        {
            var data = await base.FindAllAsync();
            data = data.Where(p => p.是否已刪除 == false).ToList();
            return data;
        }
        public override IQueryable<客戶銀行資訊> All()
        {
            var data = base.All();
            data = data.Where(p => p.是否已刪除 == false);
            return data;
        }
    }

	public  interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
	{

	}
}