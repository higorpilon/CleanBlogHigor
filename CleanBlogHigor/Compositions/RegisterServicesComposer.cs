using CleanBlogHigor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Composing;
using Umbraco.Core;

namespace CleanBlogHigor.Compositions
{
        public class RegisterServicesComposer : IUserComposer
        {
            public void Compose(Composition composition)
            {
                composition.Register<ISmtpService, SmtpService>(Lifetime.Singleton);
                composition.Register<IArticleService, ArticleService>(Lifetime.Request);
            }
        }
    
}