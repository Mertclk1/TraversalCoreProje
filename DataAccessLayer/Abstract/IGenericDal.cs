﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IGenericDal <T> 
	{
		void Insert(T p);
		void Delete(T p);
		void Update(T p);
		List<T> GetList();
	}
}
