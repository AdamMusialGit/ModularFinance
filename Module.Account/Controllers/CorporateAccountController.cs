using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.Controllers
{
    public class CorporateAccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CorporateAccountController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
