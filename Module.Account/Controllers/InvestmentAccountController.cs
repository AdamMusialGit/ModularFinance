using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.Controllers
{
    public class InvestmentAccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InvestmentAccountController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
