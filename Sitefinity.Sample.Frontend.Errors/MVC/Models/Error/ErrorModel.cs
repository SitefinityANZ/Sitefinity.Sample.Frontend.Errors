using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitefinity.Sample.Frontend.Errors.MVC.Models.Error
{
    public class ErrorModel
    {
        public int ErrorStatusCode { get; set; }

        public bool IsEmpty() {
            return ErrorStatusCode == 0;
        }

        public virtual ErrorViewModel ErrorViewModel()
        {
            var viewModel = new ErrorViewModel()

        }

    }
}
