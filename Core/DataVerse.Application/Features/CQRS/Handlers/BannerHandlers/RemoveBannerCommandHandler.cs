﻿using DataVerse.Application.Features.CQRS.Commands.BannerCommands;
using DataVerse.Application.Interfaces;
using DataVerse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVerse.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class RemoveBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public RemoveBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(values);
        }
    }
}