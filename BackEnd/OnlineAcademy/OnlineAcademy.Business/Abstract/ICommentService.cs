using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Abstract
{
    public interface ICommentService
    {
        Task<IResult> AddAsync(CommentGetDto commentDto);
        Task<IResult> UpdateAsync(CommentGetDto commentDto);
        Task<IResult> DeleteAsync(CommentGetDto commentDto);
        Task<IResult> HardDeleteAsync(CommentGetDto commentDto);
        Task<IDataResult<CommentGetDto>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<CommentGetDto>>> GetAllAsync();
    }
}
