using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Transfer.Controllers
{
    public class CashTransferController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CashTransferController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
