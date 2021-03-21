using Core.Utilities.Results.Abstract;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        public Task<IResult> AddAsync(CommentGetDto commentDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(CommentGetDto commentDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<CommentGetDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<CommentGetDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDeleteAsync(CommentGetDto commentDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(CommentGetDto commentDto)
        {
            throw new NotImplementedException();
        }
    }
}
