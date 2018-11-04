﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Infrastructure.Services
{
    public interface IPropertyMapping
    {
        Dictionary<string, List<MappedProperty>> MappingDictionary { get; }
    }
}
