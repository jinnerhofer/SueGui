using MvvmCross.ViewModels;
using SueGui.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SueGui.Core
{
    public class Setup : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
