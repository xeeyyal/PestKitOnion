using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnionAB104.Application.DTOs.Blogs
{
    public record BlogCreateDto(string Title,string Description,int ReplyCount,int AuthorId,ICollection<int> Tagids);
}
