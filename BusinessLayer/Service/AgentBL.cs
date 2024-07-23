﻿using BusinessLayer.Interface;
using MediatR;
using ModelLayer;
using RepositoryLayer.Commands.Agent;
using RepositoryLayer.Entity;
using RepositoryLayer.Handlers.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class AgentBL : IAgentBL
    {
        private readonly IMediator mediator;
        public AgentBL(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<InsuranceAgentEntity> CreateAgentAsync(InsuranceAgentML insuranceAgentML)
        {
            try
            {
                return await mediator.Send(new CreateAgentCommand(insuranceAgentML.Username,insuranceAgentML.FullName,insuranceAgentML.Email,insuranceAgentML.Password));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
