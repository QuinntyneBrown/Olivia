using TvShowMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvShowMicroservice.Dtos
{
    public class TvShowAddOrUpdateResponseDto: TvShowDto
    {
        public TvShowAddOrUpdateResponseDto(TvShow entity)
        :base(entity)
        {

        }
    }
}
