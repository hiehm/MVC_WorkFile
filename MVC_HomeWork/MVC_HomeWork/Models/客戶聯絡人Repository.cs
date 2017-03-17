using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC_HomeWork.Models
{   
	public  class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
	{
        public 客戶聯絡人 Find(int? id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }
        public async Task<List<客戶聯絡人>> GetTaskAll()
        {
            var data = await base.FindAllAsync();
            data = data.Where(p => p.是否已刪除 == false).ToList();
            return data;
        }
        public override IQueryable<客戶聯絡人> All()
        {
            var data = base.All();
            data = data.Where(p => p.是否已刪除 == false);
            return data;
        }
        public bool CheckEmail(int id,string email)
        {
            var data = base.All().Where(p => p.客戶Id == id).Where(p=>p.Email==email);
            if (data.Count()>0)
            {
                return true;
            }
            return false;
         }
    }

	public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}