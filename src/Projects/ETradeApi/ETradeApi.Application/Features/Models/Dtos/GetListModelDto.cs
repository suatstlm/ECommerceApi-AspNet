﻿
namespace ETradeApi.Application.Features.Models.Dtos
{
    public class GetListModelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public decimal DailyPrice { get; set; }
        public string ImageUrl { get; set; }
    }
}
