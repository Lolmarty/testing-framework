﻿using Ninject;
using ProofOfConcept.Configuration;
using ProofOfConcept.Services;

namespace ProofOfConcept.Tests.Component.TestObjects.Contexts
{
    public class ContextBase
    {
        protected readonly IPageFactory PageFactory;
        protected readonly NavigationService NavigationService;

        public ContextBase()
        {
            PageFactory = DependencyManager.Kernel.Get<IPageFactory>();
            NavigationService = DependencyManager.Kernel.Get<NavigationService>();    
        }
    }
}