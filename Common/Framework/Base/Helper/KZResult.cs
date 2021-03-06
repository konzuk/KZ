﻿using System.Drawing;
using Framework.Base.App;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;

namespace Framework.Base.Helper
{
    public class KZResult<T> where T: IModelBase
    {
        public T Model { get; set; }
        public KZBindingList<T> Models { get; set; }
        public KZResultMessage Message { get; set; }
    }
}