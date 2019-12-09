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
        PlanHandler handler = new PlanHandler();

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

        public override Task<MPModel> GetMedicationPlanFromPatient(MPFromPatient request, ServerCallContext context)
        {
            MPModel mPModel = new MPModel();
            Medication_Plan medication_Plan = planHandler.getMPfromPatient(request.Patient);

            mPModel.Id = medication_Plan.Id;
            mPModel.Medication = medication_Plan.Medication;
            mPModel.MedicationPlan = medication_Plan.Medication_Schedule;
            mPModel.Time = medication_Plan.time.ToString();


            return Task.FromResult(mPModel);
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
