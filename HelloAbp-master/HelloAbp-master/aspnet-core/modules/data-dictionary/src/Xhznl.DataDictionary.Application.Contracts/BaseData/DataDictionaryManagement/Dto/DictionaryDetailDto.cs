﻿using System;
using Volo.Abp.Application.Dtos;

namespace Xhznl.DataDictionary.BaseData.DataDictionaryManagement.Dto
{
    public class DictionaryDetailDto:  ExtensibleAuditedEntityDto<Guid>
    {
        public Guid Pid { get; set; }

        public string Label { get; set; }

        public string Value { get; set; }

        public short Sort { get; set; }
    }
}