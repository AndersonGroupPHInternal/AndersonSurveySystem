using System;
using Microsoft.Practices.Unity;
using AndersonSurveySystemData;
using AndersonSurveySystemFunction;
using AccountExternalData;
using AccountExternalFunction;

namespace AndersonSurveySystem.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();
            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();

            #region Data
            container.RegisterType<IDAnsweredQuestion, DAnsweredQuestion>(new PerRequestLifetimeManager());
            container.RegisterType<IDAnsweredSurvey, DAnsweredSurvey>(new PerRequestLifetimeManager());
            container.RegisterType<IDQuestion, DQuestion>(new PerRequestLifetimeManager());
            container.RegisterType<IDQuestionResult, DQuestionResult>(new PerRequestLifetimeManager());
            container.RegisterType<IDSurvey, DSurvey>(new PerRequestLifetimeManager());
            #endregion

            #region Data Reference
            container.RegisterType<IDCredential, DCredential>(new PerRequestLifetimeManager());
            #endregion

            #region Function
            container.RegisterType<IFAnsweredQuestion, FAnsweredQuestion>(new PerRequestLifetimeManager());
            container.RegisterType<IFAnsweredSurvey, FAnsweredSurvey>(new PerRequestLifetimeManager());
            container.RegisterType<IFQuestion, FQuestion>(new PerRequestLifetimeManager());
            container.RegisterType<IFQuestionResult, FQuestionResult>(new PerRequestLifetimeManager());
            container.RegisterType<IFSurvey, FSurvey>(new PerRequestLifetimeManager());
            #endregion

            #region Function Reference
            container.RegisterType<IFCredential, FCredential>(new PerRequestLifetimeManager());
            #endregion
        }
    }
}
