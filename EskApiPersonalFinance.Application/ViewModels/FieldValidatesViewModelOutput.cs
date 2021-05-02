using System.Collections.Generic;

namespace EskApiPersonalFinance.Application.ViewModels
{
    public class FieldValidatesViewModelOutput
    {
        public IEnumerable<string> Erros { get; private set; }

        public FieldValidatesViewModelOutput(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
