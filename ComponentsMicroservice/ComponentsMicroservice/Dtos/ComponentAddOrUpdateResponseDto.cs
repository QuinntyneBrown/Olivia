using ComponentsMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsMicroservice.Dtos
{
    public class ComponentAddOrUpdateResponseDto: ComponentDto
    {
        public ComponentAddOrUpdateResponseDto(Component entity)
        :base(entity)
        {

        }
    }
}
