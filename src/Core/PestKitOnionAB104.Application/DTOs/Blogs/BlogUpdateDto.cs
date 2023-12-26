namespace PestKitOnionAB104.Application.DTOs.Blogs
{
    public record BlogUpdateDto(string Title,string Description,int ReplyCount,int AuthorId,ICollection<int> TagIds);
}
