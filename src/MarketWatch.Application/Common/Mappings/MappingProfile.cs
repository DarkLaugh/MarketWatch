using AutoMapper;
using MarketWatch.Application.DTOs.Requests;
using MarketWatch.Application.DTOs.Responses;
using MarketWatch.Domain.Entities;

namespace MarketWatch.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Stock, StockResponseModel>().ReverseMap();
            CreateMap<Comment, CommentResponseModel>().ReverseMap();
            CreateMap<CommentRequestModel, Comment>().ReverseMap();
        }
    }
}
