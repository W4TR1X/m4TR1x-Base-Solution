using Autofac;
using m4TR1x.Core.Winforms.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Business.Winforms.Interfaces
{
    public interface IFormFactoryService : IDisposable
    {
        public List<IApplicationForm> Forms { get; set; }

        FormType GetForm<FormType>() where FormType : IApplicationForm;
        IList<FormType> GetForms<FormType>() where FormType : IApplicationForm;

        FormType GetOrCreateForm<FormType>() where FormType : IApplicationForm;

        FormType CreateForm<FormType>() where FormType : IApplicationForm;
        FormType CreateForm<FormType>(NamedParameter[] namedParameters) where FormType : IApplicationForm;

        bool DestroyForm(IApplicationForm instance);
    }
}
