﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise
{
    public abstract class BaseFieldBody : BaseSizableComponent
    {
        #region Members

        #endregion

        #region Methods

        protected override void RegisterClasses()
        {
            ClassMapper
                .Add( () => ClassProvider.FieldBody() );

            base.RegisterClasses();
        }

        #endregion

        #region Properties

        [Parameter] public RenderFragment ChildContent { get; set; }

        #endregion
    }
}