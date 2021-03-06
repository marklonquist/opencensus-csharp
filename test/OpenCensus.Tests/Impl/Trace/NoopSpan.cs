﻿// <copyright file="NoopSpan.cs" company="OpenCensus Authors">
// Copyright 2018, OpenCensus Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace OpenCensus.Trace.Test
{
    using System;
    using System.Collections.Generic;
    using OpenCensus.Trace.Export;

    public class NoopSpan : SpanBase
    {
        public NoopSpan(ISpanContext context, SpanOptions options)
            : base(context, options)
        {
        }

        public override DateTimeOffset EndTime { get; }

        public override TimeSpan Latency { get; }

        public override bool IsSampleToLocalSpanStore { get; }

        public override Status Status { get; set; }

        public override SpanKind? Kind { get; set; }

        public override string Name { get; set; }

        public override ISpanId ParentSpanId { get; }

        public override bool HasEnded => true;

        public override void AddAnnotation(string description, IDictionary<string, IAttributeValue> attributes)
        {
        }

        public override void AddAnnotation(IAnnotation annotation)
        {
        }

        public override void AddLink(ILink link)
        {
        }

        public override void AddMessageEvent(IMessageEvent messageEvent)
        {
        }

        public override void End(EndSpanOptions options)
        {
        }

        public override void PutAttributes(IDictionary<string, IAttributeValue> attributes)
        {
        }

        public override ISpanData ToSpanData()
        {
            return null;
        }
    }
}
