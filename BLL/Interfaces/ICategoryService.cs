﻿using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICategoryService : IService<CategoryDTO,int>
    {
        public IEnumerable<CategoryDTO> GetAllByLanguageId(int languageId);
    }
}
