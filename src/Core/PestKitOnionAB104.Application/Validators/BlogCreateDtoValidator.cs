using FluentValidation;
using PestKitOnionAB104.Application.DTOs.Blogs;

namespace PestKitOnionAB104.Application.Validators
{
    internal class BlogCreateDtoValidator : AbstractValidator<BlogCreateDto>
    {
        public BlogCreateDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(50).MinimumLength(5);
        }
    }
}
