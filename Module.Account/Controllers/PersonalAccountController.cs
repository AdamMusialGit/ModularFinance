using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.Controllers
{
    public class PersonalAccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonalAccountController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
