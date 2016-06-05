using SearchMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchMicroservice.Dtos
{
    public class SearchAddOrUpdateResponseDto: SearchDto
    {
        public SearchAddOrUpdateResponseDto(Search entity)
        :base(entity)
        {

        }
    }
}
