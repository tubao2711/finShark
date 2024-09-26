using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTos.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMappers
    {
        public static CommentDto toCommentDto(this Comment commentModel)
        {
          return new CommentDto
          {
            Id = commentModel.Id,
            Title = commentModel.Title,
            Content = commentModel.Content,
            CreatedOn = commentModel.CreatedOn,
            CreatedBy = commentModel.AppUser.UserName,
            StockId = commentModel.StockId
          };
        }

        public static Comment toCommentFromCreate(this CreateCommentDto commentDto, int stockId)
        {
          return new Comment
          {
            Title = commentDto.Title,
            Content = commentDto.Content,
            StockId = stockId
          };
        }

        public static Comment toCommentFromUpdate(this UpdateCommentRequestDto commentDto)
        {
          return new Comment
          {
            Title = commentDto.Title,
            Content = commentDto.Content
          };
        }
    }
}