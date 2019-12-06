using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcServer.Handle;

namespace GrpcServer.Services
{
    public class MedicationPlanService : MedicationPlan.MedicationPlanBase
    {
        private readonly ILogger<MedicationPlanService> logger;
        PlanHandler handler = new PlanHandler();

        public MedicationPlanService(ILogger<MedicationPlanService> logger)
        {
            this.logger = logger;
        }

        public override Task<ReturnMessage> DeleteMedicationPlan(DeleteMP request, ServerCallContext context)
        {
            return base.DeleteMedicationPlan(request, context);
        }
    }
}
