using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoGalleryMicroservice.Services
{
    public interface ICacheProvider
    {
        ICache GetCache();
    }
}
