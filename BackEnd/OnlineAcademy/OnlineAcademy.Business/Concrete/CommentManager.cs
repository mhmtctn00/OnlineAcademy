using Core.Utilities.Results.Abstract;
using OnlineAcademy.Business.Abstract;
using OnlineAcademy.Entities.Dtos.Get;
using OnlineAcademy.Entities.Dtos.Add;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineAcademy.DataAccess.Abstract;
using AutoMapper;
using OnlineAcademy.Entities.Concrete;
using Core.Utilities.Results.Concrete;
using Core.Aspects.Autofac.Exception;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

namespace OnlineAcademy.Business.Concrete
{
    [ExceptionLogAspect]
    [LogAspect(typeof(FileLogger))]
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;
        private readonly IMapper _mapper;

        public CommentManager(ICommentDal commentDal, IMapper mapper)
        {
            _commentDal = commentDal;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(CommentAddDto commentDto)
        {
            var commnet = _mapper.Map<CommentAddDto, Comment>(commentDto);
            await _commentDal.AddAsync(commnet);
            return new SuccessResult("Comment added.");
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            var comment = await _commentDal.GetAsync(c => c.Id == id);
            comment.IsDeleted = true;
            await _commentDal.UpdateAsync(comment);
            return new SuccessResult("Comment updated.");
        }

        public async Task<IDataResult<IEnumerable<CommentGetDto>>> GetAllAsync()
        {
            var comments = await _commentDal.GetListAsync();
            return new SuccessDataResult<IEnumerable<CommentGetDto>>(_mapper.Map<IEnumerable<Comment>, IEnumerable<CommentGetDto>>(comments));
        }

        public async Task<IDataResult<CommentGetDto>> GetByIdAsync(int id)
        {
            var comment = await _commentDal.GetAsync(c => c.Id == id);
            return new SuccessDataResult<CommentGetDto>(_mapper.Map<Comment, CommentGetDto>(comment));
        }

        public async Task<IResult> HardDeleteAsync(int id)
        {
            var comment = await _commentDal.GetAsync(c => c.Id == id);
            await _commentDal.DeleteAsync(comment);
            return new SuccessResult("Comment hard deleted");
        }

        public async Task<IResult> UpdateAsync(CommentUpdateDto commentDto)
        {
            var comment = _mapper.Map<CommentUpdateDto, Comment>(commentDto);
            await _commentDal.UpdateAsync(comment);
            return new SuccessResult("Comment updated");
        }
    }
}
