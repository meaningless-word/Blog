using System.Collections.Generic;
using AutoMapper;
using Blog.BLL.DTO;
using Blog.BLL.Interfaces;
using Blog.DAL.Interfaces;

namespace Blog.BLL.Services
{
    public class CommentService : ICommentService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public CommentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        public IEnumerable<CommentDTO> GetByPostId(string postId)
        {
            var comments = _mapper.Map<IEnumerable<CommentDTO>>(_unitOfWork.Comments.Find(x => x.PostId == postId));
            return comments;
        }

        public void Create(CommentDTO comment)
        {
            throw new System.NotImplementedException();
        }
    }
}