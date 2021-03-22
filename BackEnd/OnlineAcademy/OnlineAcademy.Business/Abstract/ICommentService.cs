using Core.Utilities.Results.Abstract;
using OnlineAcademy.Entities.Dtos.Get;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Abstract
{
    public interface ICommentService
    {
        Task<IResult> AddAsync(CommentAddDto commentDto);
        Task<IResult> UpdateAsync(CommentUpdateDto commentDto);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> HardDeleteAsync(int id);
        Task<IDataResult<CommentGetDto>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<CommentGetDto>>> GetAllAsync();
    }
}
