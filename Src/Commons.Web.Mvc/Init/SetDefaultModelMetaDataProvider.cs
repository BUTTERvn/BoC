using System;
using System.ComponentModel;
using System.Web.Mvc;
using BoC.ComponentModel.TypeExtension;
using BoC.InversionOfControl;
using BoC.Tasks;
using BoC.Web.Mvc.MetaData;
using IDependencyResolver = BoC.InversionOfControl.IDependencyResolver;

namespace BoC.Web.Mvc.Init
{
    public class SetDefaultModelMetaDataProvider : IContainerInitializer
    {
        private readonly IDependencyResolver dependencyResolver;

        public SetDefaultModelMetaDataProvider(IDependencyResolver dependencyResolver)
        {
            this.dependencyResolver = dependencyResolver;
        }

        public void Execute()
        {
            if (!(dependencyResolver.IsRegistered(typeof(IExtendedTypesRegistry))))
            {
                dependencyResolver.RegisterSingleton<IExtendedTypesRegistry, ExtendedTypesRegistry>();
            }
            if (!(dependencyResolver.IsRegistered(typeof(ModelMetadataProvider))))
            {
                dependencyResolver.RegisterSingleton<ModelMetadataProvider, ExtraModelMetadataProvider>();
            }
        }

   }
}