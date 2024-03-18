﻿using DataVerse.Application.Features.CQRS.Queries.AboutQueries;
using DataVerse.Application.Features.CQRS.Results.AboutResults;
using DataVerse.Application.Interfaces;
using DataVerse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVerse.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAboutByIdQueryResult
            {
                Id = values.Id,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                Title = values.Title,
            };
        }
    }
}
