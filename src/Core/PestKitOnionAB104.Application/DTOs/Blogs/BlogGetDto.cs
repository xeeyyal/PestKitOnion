using PestKitOnionAB104.Application.DTOs.Authors;

namespace PestKitOnionAB104.Application.DTOs.Blogs
{
    public record BlogGetDto(int Id,string Title,string Description,int ReplyCount,int AuthorId,IncludeAuthorDto Author);
}
