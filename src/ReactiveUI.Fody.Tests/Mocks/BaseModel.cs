﻿// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUI.Fody.Tests
{
    public class BaseModel : ReactiveObject
    {
        public virtual int IntProperty { get; set; } = 5;

        public virtual string StringProperty { get; set; } = "Initial Value";
    }
}
