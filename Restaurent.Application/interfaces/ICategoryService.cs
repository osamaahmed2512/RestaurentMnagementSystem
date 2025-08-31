using Restaurent.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.interfaces
{
    public interface ICategoryService
    {
        Task create(CategoryDto dto);
    }
}
