using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC_HomeWork.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        public 客戶資料 Find(int? id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }
        public async Task<List<客戶資料>> GetTaskAll()
        {
            var data =await base.FindAllAsync();
            data = data.Where(p => p.是否已刪除 == false).ToList();
            return data;
        }
        public override IQueryable<客戶資料> All()
        {
            var data = base.All();
            data = data.Where(p => p.是否已刪除 == false);
            return data;
        }
    }

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}