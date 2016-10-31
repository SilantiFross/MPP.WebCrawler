﻿using System.Collections.Generic;
using WebCrawler.Contracts.OutputModels;

namespace WebCrawler.Contracts.Services
{
    internal interface IMapperService
    {
        T Map<T>(IEnumerable<ICrawlNode> nodeList);
        T Map<T>(string url, int nestingLevel, IEnumerable<ICrawlNode> nodes);
    }
}
