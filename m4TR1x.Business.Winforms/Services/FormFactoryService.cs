using m4TR1x.Business.Winforms.Interfaces;
using m4TR1x.Core.Winforms.Interfaces;
using System.Collections.Generic;
using m4TR1x.Core.Services;
using System.Linq;
using Autofac;

namespace m4TR1x.Business.Winforms.Services
{
    public class FormFactoryService : BaseService, IFormFactoryService
    {
        public List<IApplicationForm> Forms { get; set; }

        private readonly IComponentContext _componentContext;

        public FormFactoryService(IComponentContext componentContext)
        {
            _componentContext = componentContext;
            Forms = new List<IApplicationForm>();
        }

        public FormType GetOrCreateForm<FormType>() where FormType : IApplicationForm
        {
            return Forms.OfType<FormType>().FirstOrDefault() ?? CreateForm<FormType>();
        }

        public FormType GetForm<FormType>() where FormType : IApplicationForm
        {
            return Forms.OfType<FormType>().FirstOrDefault();
        }

        public FormType CreateForm<FormType>() where FormType : IApplicationForm
        {
            var instance = _componentContext.Resolve<FormType>();
            setupForm(instance);
            return instance;
        }

        public FormType CreateForm<FormType>(NamedParameter[] namedParameters) where FormType : IApplicationForm
        {
            var instance = _componentContext.Resolve<FormType>(namedParameters);
            setupForm(instance);
            return instance;
        }

        void setupForm(IApplicationForm instance)
        {
            if (!Forms.Contains(instance))
            {
                Forms.Add(instance);
                instance.Disposed += formDisposed;
            }
        }

        public bool DestroyForm(IApplicationForm instance)
        {
            if (Forms.Contains(instance))
            {
                instance.Disposed -= formDisposed;
                Forms.Remove(instance);

                return true;
            }
            return false;
        }

        private void formDisposed(object sender, System.EventArgs e)
        {
            if (sender is IApplicationForm instance)
            {
                DestroyForm(instance);
            }
        }

        public override void Dispose(bool disposing)
        {
            if (disposing)
            {
                do
                {
                    Forms[0].Dispose();
                    Forms.RemoveAt(0);
                } while (Forms.Count > 0);

                Forms = null;
            }
        }
    }
}
