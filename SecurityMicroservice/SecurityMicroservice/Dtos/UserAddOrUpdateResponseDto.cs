using SecurityMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityMicroservice.Dtos
{
    public class UserAddOrUpdateResponseDto: UserDto
    {
        public UserAddOrUpdateResponseDto(User entity)
        :base(entity)
        {

        }
    }
}
