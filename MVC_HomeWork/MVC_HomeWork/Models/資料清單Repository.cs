using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC_HomeWork.Models
{   
	public  class 資料清單Repository : EFRepository<資料清單>, I資料清單Repository
	{

	}

	public  interface I資料清單Repository : IRepository<資料清單>
	{

	}
}