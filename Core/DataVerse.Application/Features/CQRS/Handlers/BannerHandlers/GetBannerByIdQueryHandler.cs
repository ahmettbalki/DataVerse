﻿using DataVerse.Application.Features.CQRS.Queries.AboutQueries;
using DataVerse.Application.Features.CQRS.Queries.BannerQueries;
using DataVerse.Application.Features.CQRS.Results.AboutResults;
using DataVerse.Application.Features.CQRS.Results.BannerResults;
using DataVerse.Application.Interfaces;
using DataVerse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVerse.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetBannerByIdQueryResult
            {
                Id = values.Id,
                Description = values.Description,
                Title = values.Title,
                VideoDescription = values.VideoDescription,
                VideoUrl = values.VideoUrl,
            };
        }
    }
}