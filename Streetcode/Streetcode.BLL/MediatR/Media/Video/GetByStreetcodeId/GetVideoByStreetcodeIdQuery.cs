﻿using FluentResults;
using MediatR;
using Streetcode.BLL.DTO.Media;

namespace Streetcode.BLL.MediatR.Media.Video.GetByStreetcodeId
{
    public record GetVideoByStreetcodeIdQuery(int streetcodeId) : IRequest<Result<IEnumerable<VideoDTO>>>;
}
