using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcServer.Handle;
using GrpcServer.Models;

namespace GrpcServer.Services
{
    public class MedicationPlanService : MedicationPlan.MedicationPlanBase
    {
        private readonly ILogger<MedicationPlanService> logger;
        private PlanHandler planHandler = new PlanHandler();
        

        public MedicationPlanService(ILogger<MedicationPlanService> logger)
        {
            this.logger = logger;
        }

        public override Task<ReturnMessage> DeleteMedicationPlan(DeleteMP request, ServerCallContext context)
        {
            ReturnMessage returnMessage = new ReturnMessage();

            returnMessage.DONE = planHandler.deletePlan(request.Id);

            return Task.FromResult(returnMessage);
        }

        public override async Task GetMedicationPlanFromPatient(MPFromPatient request, IServerStreamWriter<MPModel> responseStream, ServerCallContext context)
        {
            List<Medication_Plan> medication_Plan = planHandler.getMPfromPatient(request.Patient);

            foreach (var plan in medication_Plan)
            {
                MPModel mPModel = new MPModel();

                mPModel.Id = plan.Id;
                mPModel.Patient = plan.Patient;
                mPModel.Medication = plan.Medication;
                mPModel.MedicationPlan = plan.Medication_Schedule;
                mPModel.Time = plan.time.ToString();

                await responseStream.WriteAsync(mPModel);
            }
        }

        public override Task<ReturnMessage> AddReport(ReportModel request, ServerCallContext context)
        {
            ReturnMessage returnMessage = new ReturnMessage();
            Report report = new Report(request.Id, request.Patient, request.MedicationSchedule, short.Parse(request.Taken.ToString()));

            returnMessage.DONE = planHandler.addReport(report);

            return Task.FromResult(returnMessage);
        }
    }
}
